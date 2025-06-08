
using RecipeSystem;

namespace RecipeWinforms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new();
        DataTable dtrecipes = new();
        DataTable dtusers = new();
        BindingSource bindsource = new();
        string deletecol = "Delete";
        int cookbookid;
        public frmCookbook()
        {
            InitializeComponent();
            btnDeleteCookbook.Click += BtnDeleteCookbook_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            gRecipes.CellContentClick += GRecipes_CellContentClick;
            this.FormClosing += FrmCookbook_FormClosing;

        }

        public void ShowForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.LoadCookbook(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0) { 
                dtcookbook.Rows.Add();
            }
            dtusers = Cookbook.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtcookbook, "HeartyHearthUser");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(numCookbookPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateCreated, bindsource);
            
            cbIsActive.DataBindings.Add("Checked", bindsource, "IsActive", true, DataSourceUpdateMode.OnPropertyChanged);
            LoadRecipes();
            this.Text = GetCookbookDesc();
            EnableDisableButtons();
            this.Show();
              
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                Cookbook.SaveCookbook(dtcookbook);
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId"); ;
                this.Tag = cookbookid;
                this.Text = GetCookbookDesc();
                EnableDisableButtons();
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Cursor = Cursors.WaitCursor;
            try
            {
                Cookbook.DeleteCookbook(cookbookid);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
        }

        private void LoadRecipes()
        {            
            gRecipes.Columns.Clear();
            gRecipes.AutoGenerateColumns = true;
            dtrecipes = CookbookRecipe.LoadRecipesByCookbookId(cookbookid);
            gRecipes.DataSource = dtrecipes;
            WindowsFormsUtility.FormatGridForEdit(gRecipes, "Recipe");
            WindowsFormsUtility.AddComboBoxToGrid(gRecipes, CookbookRecipe.LoadRecipes(), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipes, "Delete");
        }

        private void SaveRecipe()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                CookbookRecipe.SaveRecipes(dtrecipes, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
        }

        private void DeleteRecipe(int rowindex)
        {
            var resp = MessageBox.Show("Are you sure you want to remove this row?", Application.ProductName, MessageBoxButtons.YesNoCancel);
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowindex, "CookbookRecipeId");
            if (resp == DialogResult.Yes) 
            {
                if (id > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    try
                    {
                        CookbookRecipe.DeleteRecipe(id);
                        LoadRecipes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                    finally { Cursor = Cursors.Default; }
                }
                else if (id == 0 && rowindex < gRecipes.Rows.Count)
                {
                    gRecipes.Rows.RemoveAt(rowindex);
                }
            }
            else if (resp == DialogResult.No)
            {
                return;
            }
        }

        private void EnableDisableButtons()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDeleteCookbook.Enabled = b;
            btnSaveRecipe.Enabled = b;
            gRecipes.Enabled = b;
        }

        private string GetCookbookDesc()
        {
            string s = "New Cookbook";
            int pk = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pk > 0)
            {
                s  = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return s; 
        }

        private void btnSaveCookbook_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnDeleteCookbook_Click(object? sender, EventArgs e)
        {
            Delete();

        }

        private void GRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gRecipes.Columns[e.ColumnIndex].Name == deletecol)
            {
                DeleteRecipe(e.RowIndex);
            }
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveRecipe();
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtcookbook) || SQLUtility.TableHasChanges(dtrecipes))
            {
                var resp = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (resp)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

    }
}
