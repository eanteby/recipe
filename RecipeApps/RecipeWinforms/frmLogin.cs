using System.Configuration;

namespace RecipeWinforms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text += " - DEV";
#endif
            this.ShowDialog();
            return loginsuccess;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";
                //this.Text  += " - DEV";
#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                //string connstring = "Server=tcp:eanteby.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                RecipeDBManager.SetConnectionString(connstring, true, txtUsername.Text, txtPassword.Text);
                loginsuccess = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Login", Application.ProductName);
            }

        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
