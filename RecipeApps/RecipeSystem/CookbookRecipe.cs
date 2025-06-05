
namespace RecipeSystem
{
    public class CookbookRecipe
    {
        public static void SaveRecipes(DataTable dtrecipe, int cookbookid)
        {
            foreach (DataRow dr in dtrecipe.Select("", "", DataViewRowState.Added))
            {
                dr["CookbookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dtrecipe, "CookbookRecipeUpdate");   

        }

        public static DataTable LoadRecipesByCookbookId(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            return SQLUtility.GetDataTable(cmd);
        }


        public static DataTable LoadRecipes()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void DeleteRecipe(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookRecipeId", cookbookrecipeid);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
