namespace RecipeWinforms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            lblCaptionRecipeName = new Label();
            lblCaptionUserName = new Label();
            lblCaptionCuisine = new Label();
            lblCaptionNumCalories = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionStatus = new Label();
            lblCaptionRecipePic = new Label();
            tblMain = new TableLayoutPanel();
            txtDateArchived = new TextBox();
            txtDatePublished = new TextBox();
            txtDateDrafted = new TextBox();
            txtRecipeName = new TextBox();
            txtNumCalories = new TextBox();
            lstUserName = new ComboBox();
            lstCuisineType = new ComboBox();
            txtRecipeStatus = new TextBox();
            txtRecipePic = new TextBox();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(98, 20);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.Location = new Point(3, 52);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(82, 20);
            lblCaptionUserName.TabIndex = 1;
            lblCaptionUserName.Text = "User Name";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(3, 104);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(56, 20);
            lblCaptionCuisine.TabIndex = 2;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCaptionNumCalories
            // 
            lblCaptionNumCalories.AutoSize = true;
            lblCaptionNumCalories.Location = new Point(3, 156);
            lblCaptionNumCalories.Name = "lblCaptionNumCalories";
            lblCaptionNumCalories.Size = new Size(138, 20);
            lblCaptionNumCalories.TabIndex = 3;
            lblCaptionNumCalories.Text = "Number of Calories";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(3, 260);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(109, 20);
            lblCaptionDatePublished.TabIndex = 4;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(3, 208);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(96, 20);
            lblCaptionDateDrafted.TabIndex = 5;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(3, 312);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(103, 20);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionStatus
            // 
            lblCaptionStatus.AutoSize = true;
            lblCaptionStatus.Location = new Point(3, 364);
            lblCaptionStatus.Name = "lblCaptionStatus";
            lblCaptionStatus.Size = new Size(98, 20);
            lblCaptionStatus.TabIndex = 7;
            lblCaptionStatus.Text = "Recipe Status";
            // 
            // lblCaptionRecipePic
            // 
            lblCaptionRecipePic.AutoSize = true;
            lblCaptionRecipePic.Location = new Point(3, 416);
            lblCaptionRecipePic.Name = "lblCaptionRecipePic";
            lblCaptionRecipePic.Size = new Size(103, 20);
            lblCaptionRecipePic.TabIndex = 8;
            lblCaptionRecipePic.Text = "Recipe Picture";
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateDrafted, 1, 4);
            tblMain.Controls.Add(lblCaptionRecipePic, 0, 8);
            tblMain.Controls.Add(lblCaptionStatus, 0, 7);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 6);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 2);
            tblMain.Controls.Add(lblCaptionUserName, 0, 1);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 5);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 4);
            tblMain.Controls.Add(lblCaptionNumCalories, 0, 3);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtNumCalories, 1, 3);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lstCuisineType, 1, 2);
            tblMain.Controls.Add(txtRecipeStatus, 1, 7);
            tblMain.Controls.Add(txtRecipePic, 1, 8);
            tblMain.Dock = DockStyle.Bottom;
            tblMain.Location = new Point(0, 32);
            tblMain.Margin = new Padding(3, 4, 3, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tblMain.Size = new Size(434, 468);
            tblMain.TabIndex = 1;
            // 
            // txtDateArchived
            // 
            txtDateArchived.AccessibleName = "";
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(147, 316);
            txtDateArchived.Margin = new Padding(3, 4, 3, 4);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(284, 27);
            txtDateArchived.TabIndex = 29;
            // 
            // txtDatePublished
            // 
            txtDatePublished.AccessibleName = "";
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(147, 264);
            txtDatePublished.Margin = new Padding(3, 4, 3, 4);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(284, 27);
            txtDatePublished.TabIndex = 28;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.AccessibleName = "";
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(147, 212);
            txtDateDrafted.Margin = new Padding(3, 4, 3, 4);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(284, 27);
            txtDateDrafted.TabIndex = 27;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(147, 4);
            txtRecipeName.Margin = new Padding(3, 4, 3, 4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(284, 27);
            txtRecipeName.TabIndex = 9;
            // 
            // txtNumCalories
            // 
            txtNumCalories.Dock = DockStyle.Fill;
            txtNumCalories.Location = new Point(147, 160);
            txtNumCalories.Margin = new Padding(3, 4, 3, 4);
            txtNumCalories.Name = "txtNumCalories";
            txtNumCalories.Size = new Size(284, 27);
            txtNumCalories.TabIndex = 12;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(147, 56);
            lstUserName.Margin = new Padding(3, 4, 3, 4);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(138, 28);
            lstUserName.TabIndex = 23;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(147, 108);
            lstCuisineType.Margin = new Padding(3, 4, 3, 4);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(138, 28);
            lstCuisineType.TabIndex = 24;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(147, 368);
            txtRecipeStatus.Margin = new Padding(3, 4, 3, 4);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(284, 27);
            txtRecipeStatus.TabIndex = 25;
            // 
            // txtRecipePic
            // 
            txtRecipePic.Dock = DockStyle.Fill;
            txtRecipePic.Location = new Point(147, 420);
            txtRecipePic.Margin = new Padding(3, 4, 3, 4);
            txtRecipePic.Name = "txtRecipePic";
            txtRecipePic.ReadOnly = true;
            txtRecipePic.Size = new Size(284, 27);
            txtRecipePic.TabIndex = 26;
            // 
            // tsMain
            // 
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(434, 27);
            tsMain.TabIndex = 2;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(44, 24);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(57, 24);
            btnDelete.Text = "Delete";
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 500);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCaptionRecipeName;
        private Label lblCaptionUserName;
        private Label lblCaptionCuisine;
        private Label lblCaptionNumCalories;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDateArchived;
        private Label lblCaptionStatus;
        private Label lblCaptionRecipePic;
        private TableLayoutPanel tblMain;
        private TextBox txtRecipeName;
        private TextBox txtNumCalories;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipePic;
        private TextBox txtDateArchived;
        private TextBox txtDatePublished;
        private TextBox txtDateDrafted;
    }
}