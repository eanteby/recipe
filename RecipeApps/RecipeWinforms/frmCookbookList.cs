
namespace RecipeWinforms
{
    public partial class frmCookbookList : Form
    {

        public frmCookbookList()
        {
            InitializeComponent();
            this.Activated += FrmCookbookList_Activated;
            btnNew.Click += BtnNew_Click;
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            gCookbookList.KeyDown += GCookbookList_KeyDown;
        }

        private void BindData()
        {
            gCookbookList.DataSource = Cookbook.LoadCookbooklist();
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "Cookbook");
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbookList, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }

        private void GCookbookList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbookList.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gCookbookList.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook));
            }
        }

    }
}
