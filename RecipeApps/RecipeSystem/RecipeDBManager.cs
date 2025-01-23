using CPUFramework;

namespace RecipeSystem
{
    public class RecipeDBManager
    {
        public static void SetConnectionString(string connectionstring)
        {
            SQLUtility.ConnectionString = connectionstring;
        }
    }
}
