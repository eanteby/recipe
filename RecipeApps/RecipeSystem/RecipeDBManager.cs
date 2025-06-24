using CPUFramework;

namespace RecipeSystem
{
    public class RecipeDBManager
    {
        public static void SetConnectionString(string connectionstring, bool tryopen, string userid = "", string password = "")
        {
            SQLUtility.SetConnectionString(connectionstring, tryopen, userid, password);
        }
    }
}
