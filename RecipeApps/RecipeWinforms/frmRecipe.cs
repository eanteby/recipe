using CPUFramework;
using System.Data;
using CPUWindowsFormsFramework;

namespace RecipeWinforms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select * from recipe r join heartyhearthuser h on r.heartyhearthuserid = h.heartyhearthuserid join cuisine c on r.cuisineid = c.cuisineid where r.recipeid = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisines = SQLUtility.GetDataTable("select cuisineid, cuisinetype from cuisine");
            DataTable dtusers = SQLUtility.GetDataTable("select HeartyHearthUserId, UserName from HeartyHearthUser");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtcuisines, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusers, dtrecipe, "HeartyHearthUser");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtNumCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipePic, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",   
                    $"HeartyHearthUserId = '{r["HeartyHearthUserId"]}',",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"NumCalories = '{r["NumCalories"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}'",
                    $"where RecipeId = '{r["RecipeId"]}'");
            }
            else
            {
                sql = "insert Recipe(RecipeName, HeartyHearthUserId, CuisineId, NumCalories, DateDrafted) ";
                sql += $"select '{r["RecipeName"]}', {r["HeartyHearthUserId"]}, {r["CuisineId"]}, {r["NumCalories"]}, '{r["DateDrafted"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
            
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where recipeId =" + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
            SQLUtility.DebugPrintDataTable(dtrecipe);
        }


    }
}
