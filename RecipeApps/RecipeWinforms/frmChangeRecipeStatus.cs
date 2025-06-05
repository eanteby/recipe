
namespace RecipeWinforms
{
    public partial class frmChangeRecipeStatus : Form
    {   
        BindingSource bindsource = new BindingSource();
        private enum RecipeStatusEnum { drafted, published, archived}
        RecipeStatusEnum currentstatus = RecipeStatusEnum.drafted;
        public frmChangeRecipeStatus()
        {
            InitializeComponent();
            BindData();
            SetUpButtons();
        }

        private void BindData()
        {
            frmRecipe.dtrecipe = Recipe.LoadForm(frmRecipe.recipeid);
            bindsource.DataSource = frmRecipe.dtrecipe;
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
        }

        private void SetUpButtons()
        {
            btnDateArchived.Tag = RecipeStatusEnum.archived;
            btnDatePublished.Tag = RecipeStatusEnum.published;
            btnDateDrafted.Tag = RecipeStatusEnum.drafted;

            EnableDisableButtons();
            foreach (Button b in tblButtons.Controls)
            {
                b.Click += B_Click;
            }
        }

        private void EnableDisableButtons(bool draft, bool publish, bool archive)
        {
            btnDateArchived.Enabled = archive;
            btnDatePublished.Enabled = publish;
            btnDateDrafted.Enabled = draft;
        }

        private void EnableDisableButtons()
        {
            Enum.TryParse(frmRecipe.dtrecipe.Rows[0]["RecipeStatus"].ToString(), out RecipeStatusEnum currentstatus);
            switch (currentstatus) 
            { 
                case RecipeStatusEnum.drafted:
                    EnableDisableButtons(false, true, true);
                    break;
                case RecipeStatusEnum.published:
                    EnableDisableButtons(false, false, true);
                    break;
                case RecipeStatusEnum.archived:
                    EnableDisableButtons(true, false, false);
                    break;
            }
        }

        private void UpdateStatus(Button b)
        {
            var resp = MessageBox.Show("Are you sure you want to change recipe status to " + b.Tag.ToString() + "?", Application.ProductName, MessageBoxButtons.YesNo);
            if (resp == DialogResult.No)
            {
                return;
            }
            else if (resp == DialogResult.Yes)
            {
                if (b.Tag != null && b.Tag is RecipeStatusEnum)
                {
                    currentstatus = (RecipeStatusEnum)b.Tag;
                }

                frmRecipe.dtrecipe.Rows[0][b.Name.Substring(3)] = DateTime.Now.ToString();

                if (currentstatus == RecipeStatusEnum.drafted)
                {
                    frmRecipe.dtrecipe.Rows[0]["DatePublished"] = DBNull.Value;
                    frmRecipe.dtrecipe.Rows[0]["DateArchived"] = DBNull.Value;
                }

                Recipe.SaveRecipe(frmRecipe.dtrecipe);
                bindsource.ResetBindings(false);
                EnableDisableButtons();
            }
        }

        private void B_Click(object? sender, EventArgs e)
        {
            if (sender != null && sender is Button)
            {
                UpdateStatus((Button)sender);
            }
        }

    }
}
