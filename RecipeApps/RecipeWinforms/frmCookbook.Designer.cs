namespace RecipeWinforms
{
    partial class frmCookbook
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
            btnDeleteCookbook = new Button();
            gRecipes = new DataGridView();
            lblCookbookNameCaption = new Label();
            lblUserCaption = new Label();
            lblIsActiveCaption = new Label();
            lblPriceCaption = new Label();
            txtCookbookName = new TextBox();
            tbl2 = new TableLayoutPanel();
            lblDateCreatedCaption = new Label();
            lblDateCreated = new Label();
            numCookbookPrice = new NumericUpDown();
            cbIsActive = new CheckBox();
            lstUserName = new ComboBox();
            btnSaveRecipe = new Button();
            lblDivider = new Label();
            btnSaveCookbook = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            tbl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCookbookPrice).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(btnDeleteCookbook, 1, 0);
            tblMain.Controls.Add(gRecipes, 1, 6);
            tblMain.Controls.Add(lblCookbookNameCaption, 0, 1);
            tblMain.Controls.Add(lblUserCaption, 0, 2);
            tblMain.Controls.Add(lblIsActiveCaption, 0, 4);
            tblMain.Controls.Add(lblPriceCaption, 0, 3);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(tbl2, 1, 3);
            tblMain.Controls.Add(cbIsActive, 1, 4);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(btnSaveRecipe, 0, 6);
            tblMain.Controls.Add(lblDivider, 0, 5);
            tblMain.Controls.Add(btnSaveCookbook, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 10, 3, 10);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // btnDeleteCookbook
            // 
            btnDeleteCookbook.AutoSize = true;
            btnDeleteCookbook.Location = new Point(130, 3);
            btnDeleteCookbook.Name = "btnDeleteCookbook";
            btnDeleteCookbook.Size = new Size(94, 30);
            btnDeleteCookbook.TabIndex = 15;
            btnDeleteCookbook.Text = "Delete";
            btnDeleteCookbook.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipes, 2);
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(3, 248);
            gRecipes.Name = "gRecipes";
            gRecipes.RowHeadersWidth = 51;
            gRecipes.Size = new Size(794, 199);
            gRecipes.TabIndex = 13;
            // 
            // lblCookbookNameCaption
            // 
            lblCookbookNameCaption.AutoSize = true;
            lblCookbookNameCaption.Location = new Point(3, 36);
            lblCookbookNameCaption.Name = "lblCookbookNameCaption";
            lblCookbookNameCaption.Size = new Size(121, 20);
            lblCookbookNameCaption.TabIndex = 2;
            lblCookbookNameCaption.Text = "Cookbook Name";
            // 
            // lblUserCaption
            // 
            lblUserCaption.AutoSize = true;
            lblUserCaption.Location = new Point(3, 69);
            lblUserCaption.Name = "lblUserCaption";
            lblUserCaption.Size = new Size(38, 20);
            lblUserCaption.TabIndex = 3;
            lblUserCaption.Text = "User";
            // 
            // lblIsActiveCaption
            // 
            lblIsActiveCaption.AutoSize = true;
            lblIsActiveCaption.Location = new Point(3, 162);
            lblIsActiveCaption.Name = "lblIsActiveCaption";
            lblIsActiveCaption.Size = new Size(50, 20);
            lblIsActiveCaption.TabIndex = 5;
            lblIsActiveCaption.Text = "Active";
            // 
            // lblPriceCaption
            // 
            lblPriceCaption.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPriceCaption.AutoSize = true;
            lblPriceCaption.Location = new Point(3, 142);
            lblPriceCaption.Name = "lblPriceCaption";
            lblPriceCaption.Size = new Size(41, 20);
            lblPriceCaption.TabIndex = 4;
            lblPriceCaption.Text = "Price";
            // 
            // txtCookbookName
            // 
            txtCookbookName.Location = new Point(130, 39);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(262, 27);
            txtCookbookName.TabIndex = 7;
            // 
            // tbl2
            // 
            tbl2.AutoSize = true;
            tbl2.ColumnCount = 2;
            tbl2.ColumnStyles.Add(new ColumnStyle());
            tbl2.ColumnStyles.Add(new ColumnStyle());
            tbl2.Controls.Add(lblDateCreatedCaption, 1, 0);
            tbl2.Controls.Add(lblDateCreated, 1, 1);
            tbl2.Controls.Add(numCookbookPrice, 0, 1);
            tbl2.Location = new Point(130, 106);
            tbl2.Name = "tbl2";
            tbl2.RowCount = 2;
            tbl2.RowStyles.Add(new RowStyle());
            tbl2.RowStyles.Add(new RowStyle());
            tbl2.Size = new Size(259, 53);
            tbl2.TabIndex = 9;
            // 
            // lblDateCreatedCaption
            // 
            lblDateCreatedCaption.AutoSize = true;
            lblDateCreatedCaption.Location = new Point(159, 0);
            lblDateCreatedCaption.Name = "lblDateCreatedCaption";
            lblDateCreatedCaption.Size = new Size(97, 20);
            lblDateCreatedCaption.TabIndex = 6;
            lblDateCreatedCaption.Text = "Date Created";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.BorderStyle = BorderStyle.FixedSingle;
            lblDateCreated.Dock = DockStyle.Bottom;
            lblDateCreated.Location = new Point(159, 28);
            lblDateCreated.Margin = new Padding(3, 0, 3, 3);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(97, 22);
            lblDateCreated.TabIndex = 9;
            // 
            // numCookbookPrice
            // 
            numCookbookPrice.DecimalPlaces = 2;
            numCookbookPrice.Dock = DockStyle.Bottom;
            numCookbookPrice.Location = new Point(3, 23);
            numCookbookPrice.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numCookbookPrice.Name = "numCookbookPrice";
            numCookbookPrice.Size = new Size(150, 27);
            numCookbookPrice.TabIndex = 10;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Location = new Point(130, 165);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(18, 17);
            cbIsActive.TabIndex = 10;
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(130, 72);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(262, 28);
            lstUserName.TabIndex = 11;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Location = new Point(3, 213);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(94, 29);
            btnSaveRecipe.TabIndex = 12;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // lblDivider
            // 
            lblDivider.BackColor = Color.Transparent;
            lblDivider.BorderStyle = BorderStyle.Fixed3D;
            tblMain.SetColumnSpan(lblDivider, 2);
            lblDivider.Dock = DockStyle.Top;
            lblDivider.Location = new Point(3, 195);
            lblDivider.Margin = new Padding(3, 10, 3, 10);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(794, 1);
            lblDivider.TabIndex = 14;
            // 
            // btnSaveCookbook
            // 
            btnSaveCookbook.AutoSize = true;
            btnSaveCookbook.Location = new Point(3, 3);
            btnSaveCookbook.Name = "btnSaveCookbook";
            btnSaveCookbook.Size = new Size(94, 30);
            btnSaveCookbook.TabIndex = 0;
            btnSaveCookbook.Text = "Save";
            btnSaveCookbook.UseVisualStyleBackColor = true;
            btnSaveCookbook.Click += btnSaveCookbook_Click;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmCookbook";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).EndInit();
            tbl2.ResumeLayout(false);
            tbl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCookbookPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSaveCookbook;
        private Label lblCookbookNameCaption;
        private Label lblUserCaption;
        private Label lblPriceCaption;
        private Label lblIsActiveCaption;
        private TextBox txtCookbookName;
        private TableLayoutPanel tbl2;
        private Label lblDateCreatedCaption;
        private Label lblDateCreated;
        private CheckBox cbIsActive;
        private ComboBox lstUserName;
        private Button btnSaveRecipe;
        private DataGridView gRecipes;
        private Label lblDivider;
        private Button btnDeleteCookbook;
        private NumericUpDown numCookbookPrice;
    }
}