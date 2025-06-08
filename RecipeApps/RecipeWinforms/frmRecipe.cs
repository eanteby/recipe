
namespace RecipeWinforms
{
    public partial class frmRecipe : Form
    {
        public static DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipestep = new();
        BindingSource bindsource = new BindingSource();
        private enum RecipeChildEnum { RecipeIngredient, RecipeStep }
        RecipeChildEnum recipechild;
        string deletecolname = "Delete";
        public static int recipeid = 0;
        public frmRecipe()
        {
            InitializeComponent();
            this.Shown += FrmRecipe_Shown;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnSaveStep.Click += BtnSaveStep_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            this.FormClosing += FrmRecipe_FormClosing;
        }

        public void ShowForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.LoadForm(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisines = Recipe.GetCuisineList();
            DataTable dtusers = Recipe.GetUsersList();
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisines, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "HeartyHearthUser");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(numNumCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            this.Text = GetRecipeDesc();
            EnableDisableButtons();

            this.Show();
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.SaveRecipe(dtrecipe);
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                this.Text = GetRecipeDesc();
                EnableDisableButtons();
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Application.UseWaitCursor = false; }
            return b;
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.DeleteRecipe(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally { Application.UseWaitCursor = false; }
        }
        private void DisplayChildRecord(DataGridView grid, RecipeChildEnum recipechild)
        {
            grid.Columns.Clear();
            grid.AutoGenerateColumns = true;
            if (recipechild == RecipeChildEnum.RecipeStep)
            {
                dtrecipestep = RecipeChild.LoadByRecipeId(recipeid, "RecipeStepGet");
                gSteps.DataSource = dtrecipestep;
            }
            else if (recipechild == RecipeChildEnum.RecipeIngredient)
            {
                dtrecipeingredient = RecipeChild.LoadByRecipeId(recipeid, "RecipeIngredientGet");
                gIngredients.DataSource = dtrecipeingredient;
                WindowsFormsUtility.AddComboBoxToGrid(gIngredients, RecipeChild.LoadChildTable("MeasurementTypeGet"), "MeasurementType", "MeasurementTypeDesc");
                WindowsFormsUtility.AddComboBoxToGrid(gIngredients, RecipeChild.LoadChildTable("IngredientGet"), "Ingredient", "IngredientName");

            }
            WindowsFormsUtility.AddDeleteButtonToGrid(grid, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(grid, recipechild.ToString());
        }

        private void DeleteChildRow(DataGridView grid, int rowindex, RecipeChildEnum recipechild)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(grid, rowindex, recipechild.ToString() + "Id");
            var resp = MessageBox.Show("Are you sure you want to delete this " + recipechild + "?", Application.ProductName, MessageBoxButtons.YesNoCancel);
            if (resp == DialogResult.Yes)
            {
                if (id > 0)
                {
                    try
                    {
                        RecipeChild.DeleteRecipeChild(id, "@" + recipechild.ToString() + "Id", recipechild.ToString() + "delete");
                        DisplayChildRecord(grid, recipechild);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
                }
                else if (id == 0 && rowindex < grid.Rows.Count)
                {
                    grid.Rows.RemoveAt(rowindex);
                }
            }
            if (resp == DialogResult.No)
            {
                return;
            }
        }

        private void EnableDisableButtons()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredient.Enabled = b;
            btnSaveStep.Enabled = b;
            btnChangeStatus.Enabled = b;
            gIngredients.Enabled = b;
            gSteps.Enabled = b;
        }

        private void ChangeStatus()
        {
            Form frm = new frmChangeRecipeStatus();
            frm.FormClosed += Frm_FormClosed;
            if (this.MdiParent != null && this.MdiParent is frmMain) 
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeRecipeStatus));
            }
            frm.Text = this.Text + " - Change recipe status";
        }

        private string GetRecipeDesc()
        {
            String s = "New Recipe";
            int pk = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pk > 0)
            {
                s = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return s;
        }

        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            DisplayChildRecord(gIngredients, RecipeChildEnum.RecipeIngredient);
            DisplayChildRecord(gSteps, RecipeChildEnum.RecipeStep);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ;
            bindsource.DataSource = dtrecipe;
            bindsource.ResetBindings(false);
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gSteps.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteChildRow(gSteps, e.RowIndex, RecipeChildEnum.RecipeStep);
            }

        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gIngredients.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteChildRow(gIngredients, e.RowIndex, RecipeChildEnum.RecipeIngredient);
            }

        }

        private void BtnSaveStep_Click(object? sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RecipeChild.SaveDataTable(dtrecipestep, "RecipeStepUpdate", recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RecipeChild.SaveDataTable(dtrecipeingredient, "RecipeIngredientUpdate", recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally { Cursor = Cursors.Default; }

        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeStatus();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtrecipe) || SQLUtility.TableHasChanges(dtrecipeingredient) || SQLUtility.TableHasChanges(dtrecipestep))
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
