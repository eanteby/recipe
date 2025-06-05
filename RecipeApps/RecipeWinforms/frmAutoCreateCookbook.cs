
namespace RecipeWinforms
{
    public partial class frmAutoCreateCookbook : Form
    {
        int userid;
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            BindData();
            btnCreate.Click += BtnCreate_Click;
        }

        private void BindData()
        {
            WindowsFormsUtility.SetListBinding(lstUserName, Cookbook.GetUserList(), null, "HeartyHearthUser");
        }

        private void Create()
        {
            userid = WindowsFormsUtility.GetIdFromComboBox(lstUserName);
            try
            {
                int newcookbookid = Cookbook.AutoCreateCookbook(userid);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), newcookbookid);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            Create();
        }

    }
}
