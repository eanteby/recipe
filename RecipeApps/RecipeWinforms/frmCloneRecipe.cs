
namespace RecipeWinforms
{
    public partial class frmCloneRecipe : Form
    {   
        int recipeid = 0;
        BindingSource bindsource = new BindingSource();
        public frmCloneRecipe()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
            BindData();
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe"), null, "Recipe");
        }
        private void Clone(int recipeid)
        {
            recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipeName);
            try
            {
                int newid = Recipe.CloneRecipe(recipeid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), newid);
                }
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            Clone(recipeid);
        }
    }
}
