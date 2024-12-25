using CPUFramework;
using System.Configuration;
using System.Data;

namespace RecipeWinforms
{
    public partial class frmRecipeSearch : Form
    {
        public frmRecipeSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            FormatGrid();
            gRecipe.CellDoubleClick += gRecipe_CellDoubleClick;
        }


        private void SearchForRecipe(string lastname)
        {
            string sql = "select * from recipe r join heartyhearthuser h on r.heartyhearthuserid = h.heartyhearthuserid join cuisine c on r.cuisineid = c.cuisineid where r.recipename like '%" + txtRecipeName.Text + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }

        private void FormatGrid()
        {
            gRecipe.AllowUserToAddRows = false;
            gRecipe.ReadOnly = true;
            gRecipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void gRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(lblRecipe.Text);
        }
    }
}
