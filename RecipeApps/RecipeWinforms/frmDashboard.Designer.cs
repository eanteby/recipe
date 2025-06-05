namespace RecipeWinforms
{
    partial class frmDashboard
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
            tblMain = new TableLayoutPanel();
            lblHeader = new Label();
            lblDesc = new Label();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblGrid = new TableLayoutPanel();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblHeader, 0, 0);
            tblMain.Controls.Add(lblDesc, 0, 1);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Controls.Add(tblGrid, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 3, 3, 15);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.10287F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2057514F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 51.58851F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1028728F));
            tblMain.Size = new Size(992, 545);
            tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(239, 10);
            lblHeader.Margin = new Padding(3, 10, 3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(513, 55);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(9, 80);
            lblDesc.Margin = new Padding(3, 15, 3, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(973, 116);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks. You can also....";
            lblDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Bottom;
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 2, 0);
            tblButtons.Controls.Add(btnCookbookList, 1, 0);
            tblButtons.Location = new Point(279, 483);
            tblButtons.Margin = new Padding(3, 3, 3, 15);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(434, 47);
            tblButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.AutoSize = true;
            btnRecipeList.BackColor = Color.WhiteSmoke;
            btnRecipeList.Font = new Font("Segoe UI", 13.8F);
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(133, 41);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.AutoSize = true;
            btnMealList.BackColor = Color.WhiteSmoke;
            btnMealList.Font = new Font("Segoe UI", 13.8F);
            btnMealList.Location = new Point(315, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(116, 41);
            btnMealList.TabIndex = 2;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.BackColor = Color.WhiteSmoke;
            btnCookbookList.Font = new Font("Segoe UI", 13.8F);
            btnCookbookList.Location = new Point(142, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(167, 41);
            btnCookbookList.TabIndex = 1;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // tblGrid
            // 
            tblGrid.ColumnCount = 3;
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblGrid.Controls.Add(gData, 1, 0);
            tblGrid.Dock = DockStyle.Fill;
            tblGrid.Location = new Point(3, 199);
            tblGrid.Name = "tblGrid";
            tblGrid.RowCount = 1;
            tblGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblGrid.Size = new Size(986, 275);
            tblGrid.TabIndex = 4;
            // 
            // gData
            // 
            gData.BackgroundColor = Color.White;
            gData.BorderStyle = BorderStyle.None;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(249, 3);
            gData.MultiSelect = false;
            gData.Name = "gData";
            gData.ReadOnly = true;
            gData.RowHeadersWidth = 51;
            gData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gData.Size = new Size(487, 269);
            gData.TabIndex = 3;
            gData.TabStop = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(992, 545);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblDesc;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private TableLayoutPanel tblGrid;
        private DataGridView gData;
    }
}