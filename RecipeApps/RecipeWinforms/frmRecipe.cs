using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinforms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "select * from recipe r join heartyhearthuser h on r.heartyhearthuserid = h.heartyhearthuserid join cuisine c on r.cuisineid = c.cuisineid where r.recipeid = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtUserName.DataBindings.Add("Text", dt, "UserName");
            txtCuisine.DataBindings.Add("Text", dt, "CuisineType");
            txtNumCalories.DataBindings.Add("Text", dt, "NumCalories");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtRecipePic.DataBindings.Add("Text", dt, "RecipePic");
            this.Show();
        }

    }
}
