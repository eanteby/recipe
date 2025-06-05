
namespace RecipeWinforms
{
    public partial class frmMeal : Form
    {
        public frmMeal()
        {
            InitializeComponent();
            this.Activated += FrmMeal_Activated;
        }
        private void BindData()
        {
            gMeal.DataSource = DataMaintenance.GetDataList("MealList"); 
            WindowsFormsUtility.FormatGridForSearchResults(gMeal, "Meal");
        }
        private void FrmMeal_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}
