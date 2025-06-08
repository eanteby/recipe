
namespace RecipeWinforms
{
    
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuMealList.Click += MnuMealList_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuCloneRecipe.Click += MnuCloneRecipe_Click;
            mnuAutoCreate.Click += MnuAutoCreate_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCascade.Click += MnuCascade_Click;
            this.Shown += FrmMain_Shown;
        }



        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype, pkvalue);
            if (!b)
            {
                Form? newfrm = null;

                if (frmtype == typeof(frmDashboard))
                {
                    newfrm = new frmDashboard();
                }
                else if (frmtype == typeof(frmRecipeList)) 
                {
                    newfrm = new frmRecipeList();
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    newfrm = new frmCookbookList();
                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmMeal))
                {
                    newfrm = new frmMeal();
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    newfrm = new frmDataMaintenance();
                }
                else if(frmtype == typeof(frmCloneRecipe))
                {
                    newfrm = new frmCloneRecipe();
                }
                else if (frmtype == typeof(frmAutoCreateCookbook))
                {
                    newfrm = new frmAutoCreateCookbook();
                }
                else if (frmtype == typeof(frmChangeRecipeStatus))
                {
                    newfrm = new frmChangeRecipeStatus();
                }

                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }

        }

        public void NewRecipe()
        {
            OpenForm(typeof(frmRecipe));
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));

        }
        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }


        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }

        private void MnuCloneRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            NewRecipe();
        }

        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMeal));
        }

        private void MnuAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }
    }
}
