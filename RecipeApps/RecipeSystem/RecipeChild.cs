
namespace RecipeSystem
{
    public class RecipeChild
    {
        public static DataTable LoadByRecipeId(int recipeid, string sprocname)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);
            cmd.Parameters["@RecipeId"].Value = recipeid;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadChildTable(string sprocname)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveDataTable(DataTable dt, string sprocname, int recipeid)
        {
            foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added)) 
            {
                dr["RecipeId"] = recipeid;
            }
            
            SQLUtility.SaveDataTable(dt, sprocname);
        }

        public static void DeleteRecipeChild(int id, string param, string sprocname)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(sprocname);
            SQLUtility.SetParamValue(cmd, param, id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
