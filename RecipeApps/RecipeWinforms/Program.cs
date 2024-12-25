using CPUFramework;

namespace RecipeWinforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SQLUtility.ConnnectionString = "Server=tcp:eanteby.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;User ID=eanteby;Password=CpuAdmin123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            Application.Run(new frmRecipeSearch());
        }
    }
}