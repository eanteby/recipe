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
            txtRecipeName = new TextBox();
            txtNumCalories = new TextBox();
            dtpDateDrafted = new DateTimePicker();
            dtpDatePublished = new DateTimePicker();
            dtpDateArchived = new DateTimePicker();
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
            lblCaptionRecipeName.Size = new Size(77, 15);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.Location = new Point(3, 38);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(65, 15);
            lblCaptionUserName.TabIndex = 1;
            lblCaptionUserName.Text = "User Name";
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(3, 76);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(46, 15);
            lblCaptionCuisine.TabIndex = 2;
            lblCaptionCuisine.Text = "Cuisine";
            // 
            // lblCaptionNumCalories
            // 
            lblCaptionNumCalories.AutoSize = true;
            lblCaptionNumCalories.Location = new Point(3, 114);
            lblCaptionNumCalories.Name = "lblCaptionNumCalories";
            lblCaptionNumCalories.Size = new Size(110, 15);
            lblCaptionNumCalories.TabIndex = 3;
            lblCaptionNumCalories.Text = "Number of Calories";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(3, 190);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(86, 15);
            lblCaptionDatePublished.TabIndex = 4;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(3, 152);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(73, 15);
            lblCaptionDateDrafted.TabIndex = 5;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(3, 228);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(81, 15);
            lblCaptionDateArchived.TabIndex = 6;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionStatus
            // 
            lblCaptionStatus.AutoSize = true;
            lblCaptionStatus.Location = new Point(3, 266);
            lblCaptionStatus.Name = "lblCaptionStatus";
            lblCaptionStatus.Size = new Size(77, 15);
            lblCaptionStatus.TabIndex = 7;
            lblCaptionStatus.Text = "Recipe Status";
            // 
            // lblCaptionRecipePic
            // 
            lblCaptionRecipePic.AutoSize = true;
            lblCaptionRecipePic.Location = new Point(3, 304);
            lblCaptionRecipePic.Name = "lblCaptionRecipePic";
            lblCaptionRecipePic.Size = new Size(82, 15);
            lblCaptionRecipePic.TabIndex = 8;
            lblCaptionRecipePic.Text = "Recipe Picture";
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
            tblMain.Controls.Add(dtpDateDrafted, 1, 4);
            tblMain.Controls.Add(dtpDatePublished, 1, 5);
            tblMain.Controls.Add(dtpDateArchived, 1, 6);
            tblMain.Controls.Add(lstUserName, 1, 1);
            tblMain.Controls.Add(lstCuisineType, 1, 2);
            tblMain.Controls.Add(txtRecipeStatus, 1, 7);
            tblMain.Controls.Add(txtRecipePic, 1, 8);
            tblMain.Dock = DockStyle.Bottom;
            tblMain.Location = new Point(0, 24);
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
            tblMain.Size = new Size(380, 351);
            tblMain.TabIndex = 1;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(119, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(258, 23);
            txtRecipeName.TabIndex = 9;
            // 
            // txtNumCalories
            // 
            txtNumCalories.Dock = DockStyle.Fill;
            txtNumCalories.Location = new Point(119, 117);
            txtNumCalories.Name = "txtNumCalories";
            txtNumCalories.Size = new Size(258, 23);
            txtNumCalories.TabIndex = 12;
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(119, 155);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(200, 23);
            dtpDateDrafted.TabIndex = 18;
            // 
            // dtpDatePublished
            // 
            dtpDatePublished.Format = DateTimePickerFormat.Short;
            dtpDatePublished.Location = new Point(119, 193);
            dtpDatePublished.Name = "dtpDatePublished";
            dtpDatePublished.Size = new Size(200, 23);
            dtpDatePublished.TabIndex = 19;
            // 
            // dtpDateArchived
            // 
            dtpDateArchived.Format = DateTimePickerFormat.Short;
            dtpDateArchived.Location = new Point(119, 231);
            dtpDateArchived.Name = "dtpDateArchived";
            dtpDateArchived.Size = new Size(200, 23);
            dtpDateArchived.TabIndex = 20;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(119, 41);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(121, 23);
            lstUserName.TabIndex = 23;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(119, 79);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(121, 23);
            lstCuisineType.TabIndex = 24;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(119, 269);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(258, 23);
            txtRecipeStatus.TabIndex = 25;
            // 
            // txtRecipePic
            // 
            txtRecipePic.Dock = DockStyle.Fill;
            txtRecipePic.Location = new Point(119, 307);
            txtRecipePic.Name = "txtRecipePic";
            txtRecipePic.ReadOnly = true;
            txtRecipePic.Size = new Size(258, 23);
            txtRecipePic.TabIndex = 26;
            // 
            // tsMain
            // 
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(380, 25);
            tsMain.TabIndex = 2;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(35, 22);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(44, 22);
            btnDelete.Text = "Delete";
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 375);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
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
        private DateTimePicker dtpDateDrafted;
        private DateTimePicker dtpDatePublished;
        private DateTimePicker dtpDateArchived;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipePic;
    }
}