
using RecipeSystem;

namespace RecipeWinforms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            this.Activated += FrmRecipeList_Activated;
            btnNewRcipe.Click += BtnNewRcipe_Click;
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
        }


        private void BindData()
        {
            gData.DataSource = Recipe.LoadForm(0, true);
            foreach(DataGridViewColumn col  in gData.Columns)
            {
                if (col.ToString().Contains("Date"))
                {
                    col.Visible = false;
                }
            }
            WindowsFormsUtility.FormatGridForSearchResults(gData, "Cookbook");
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "RecipeId");
            }

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gData.SelectedRows.Count > 0)
            {
                if (gData.SelectedRows[0].Index != -1)
                {
                    ShowRecipeForm(gData.SelectedRows[0].Index);
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ShowRecipeForm(e.RowIndex);
            }
        }


        private void BtnNewRcipe_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).NewRecipe();
            }
        }
    }
}
