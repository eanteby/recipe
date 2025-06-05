
namespace RecipeSystem
{
    public class Cookbook
    {
        public static void SaveCookbook(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0) 
            {
                throw new Exception("cannot call SaveCookbook method because no rows in table"); 
            }
            else
            {
                DataRow dr = dtcookbook.Rows[0];
                SQLUtility.SaveDataRow(dr, "CookbookUpdate");
            }
        }

        public static void DeleteCookbook(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookDelete");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            SQLUtility.ExecuteSQL(cmd);
        }
        public static DataTable LoadCookbooklist()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookListGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadCookbook(int id)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            cmd.Parameters["@CookbookId"].Value = id;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUserList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("UserGet");
            cmd.Parameters["@All"].Value = 1;
            return SQLUtility.GetDataTable(cmd);
        }

        public static int AutoCreateCookbook(int userid)
        {
            int cookbookid;
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookCreate");
            SQLUtility.SetParamValue(cmd, "@HeartyHearthUserId", userid);
            SQLUtility.ExecuteSQL(cmd);  
            return cookbookid = (int)cmd.Parameters["@CookbookId"].Value;

        }


    }
}
