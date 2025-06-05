
namespace RecipeWinforms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            BindData();
            gData.ClearSelection();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;

        }

        private void BindData()
        {
            gData.DataSource = RecipeSystem.DataMaintenance.GetDashboardData();
            gData.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            WindowsFormsUtility.FormatGridForSearchResults(gData, "dt");
            gData.DataBindingComplete += GData_DataBindingComplete;            

        }

        public void OpenFormInfrmMain(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(frmtype);
            }
        }

        private void GData_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            gData.ClearSelection();
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            OpenFormInfrmMain(typeof(frmRecipeList));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            OpenFormInfrmMain(typeof(frmCookbookList));
        }


        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            OpenFormInfrmMain(typeof(frmMeal));
        }

    }
}
