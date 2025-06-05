namespace RecipeWinforms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuCloneRecipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuNewCookbook = new ToolStripMenuItem();
            mnuAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuTile = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1142, 28);
            mnuMain.TabIndex = 3;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(165, 26);
            mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuNewRecipe, mnuCloneRecipe });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(74, 24);
            mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(191, 26);
            mnuRecipeList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(191, 26);
            mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneRecipe
            // 
            mnuCloneRecipe.Name = "mnuCloneRecipe";
            mnuCloneRecipe.Size = new Size(191, 26);
            mnuCloneRecipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(62, 24);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealList
            // 
            mnuMealList.Name = "mnuMealList";
            mnuMealList.Size = new Size(114, 26);
            mnuMealList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuNewCookbook, mnuAutoCreate });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(97, 24);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(194, 26);
            mnuCookbookList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            mnuNewCookbook.Name = "mnuNewCookbook";
            mnuNewCookbook.Size = new Size(194, 26);
            mnuNewCookbook.Text = "New Cookbook";
            // 
            // mnuAutoCreate
            // 
            mnuAutoCreate.Name = "mnuAutoCreate";
            mnuAutoCreate.Size = new Size(194, 26);
            mnuAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(144, 24);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(154, 26);
            mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuTile, mnuCascade });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(84, 24);
            mnuWindows.Text = "Windows";
            // 
            // mnuTile
            // 
            mnuTile.Name = "mnuTile";
            mnuTile.Size = new Size(147, 26);
            mnuTile.Text = "Tile";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(147, 26);
            mnuCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(0, 28);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1142, 25);
            tsMain.TabIndex = 5;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 646);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "Hearty Hearth";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuCascade;
        private ToolStrip tsMain;
    }
}