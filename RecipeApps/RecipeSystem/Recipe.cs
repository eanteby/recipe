
namespace RecipeSystem
{
    public class Recipe
    {
        public static void SetUpNav()
        {
           
        }
        public static DataTable SearchRecipe(string recipename )
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeListGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadForm(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveRecipe(DataTable dtrecipe)
        {
            //SQLUtility.DebugPrintDataTable(dtrecipe);
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("cannot call SaveRecipe method because no rows in table");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
            //SQLUtility.ExecuteSQL(sql);
        }

        public static void DeleteRecipe(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUsersList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("HeartyHearthUserGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static int CloneRecipe(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CloneRecipe");
            SQLUtility.SetParamValue(cmd, "@BaseRecipeId", recipeid);
            SQLUtility.ExecuteSQL(cmd);
            return (int)cmd.Parameters["@RecipeId"].Value;
        }
    }
}
