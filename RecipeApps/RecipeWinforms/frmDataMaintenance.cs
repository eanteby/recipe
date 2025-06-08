
using RecipeSystem;

namespace RecipeWinforms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum {HeartyHearthUser, Cuisine, Ingredient, MeasurementType, Course}
        TableTypeEnum currenttabletype = TableTypeEnum.HeartyHearthUser;
        string deletecolname = "Delete";
        DataTable dtlist = new DataTable();
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.EditingControlShowing += GData_EditingControlShowing;
            SetUpRadioButtons();
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(tabletype.ToString());
            gData.Columns.Clear();
            gData.AutoGenerateColumns = true;
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, tabletype.ToString());
        }

        private void Delete(int rowindex)
        {
            var resp = MessageBox.Show(DeleteMessage() , Application.ProductName, MessageBoxButtons.YesNoCancel);
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (resp == DialogResult.No)
            {
                return;
            }

            else if (resp == DialogResult.Yes)
            { 
                if (id > 0)
                {
                    try
                    {
                        DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                        BindData(currenttabletype);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName);
                    }
      
                }
                else
                {
                    gData.Rows.RemoveAt(rowindex);
                }
            }

        }

        private bool Save()
        {
            bool b = false;
            try
            {
                DataMaintenance.SaveDataTable(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            return b;
        }

        private void SetUpRadioButtons()
        {
            foreach(RadioButton rb in pnlButtons.Controls)
            {
                rb.Click += Rb_Click;
            }
            optCourses.Tag = TableTypeEnum.Course;
            optCuisines.Tag = TableTypeEnum.Cuisine;
            optMeasurements.Tag = TableTypeEnum.MeasurementType;
            optIngredients.Tag = TableTypeEnum.Ingredient;
            optUsers.Tag = TableTypeEnum.HeartyHearthUser;
        }

        private string DeleteMessage()
        {
            string msg = "Are you sure you want to delete this row and all related ";
            switch (currenttabletype)
            {
                case TableTypeEnum.Cuisine:
                case TableTypeEnum.Ingredient:
                    msg += "recipes?";
                    break;
                case TableTypeEnum.MeasurementType:
                    msg += "recipe ingredients?";
                    break;
                case TableTypeEnum.Course:
                    msg += "meal courses?";
                    break;
                case TableTypeEnum.HeartyHearthUser:
                    msg += "recipes, meals and cookbooks?";
                    break;
            }
            return msg;
        }
        private void Rb_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum){
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
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

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname) 
            {
                Delete(e.RowIndex);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GData_EditingControlShowing(object? sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (currenttabletype == TableTypeEnum.Course)
            {
                if (gData.CurrentCell.ColumnIndex == gData.Columns["CourseSequence"].Index)
                {
                    TextBox textBox = e.Control as TextBox;
                    if (textBox != null)
                    {
                        textBox.KeyPress += TextBox_KeyPress;
                    }
                }
            }
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
