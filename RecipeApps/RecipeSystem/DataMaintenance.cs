
namespace RecipeSystem
{
    public static class DataMaintenance
    {
        public static DataTable GetDashboardData()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetDataList(string tablename)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static void SaveDataTable(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void DeleteRow(string tablename, int pkvalue)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, "@" + tablename + "Id", pkvalue);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
