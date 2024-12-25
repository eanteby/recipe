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
            txtUserName = new TextBox();
            txtCuisine = new TextBox();
            txtNumCalories = new TextBox();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeStatus = new TextBox();
            txtRecipePic = new TextBox();
            tblMain.SuspendLayout();
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
            tblMain.Controls.Add(txtUserName, 1, 1);
            tblMain.Controls.Add(txtCuisine, 1, 2);
            tblMain.Controls.Add(txtNumCalories, 1, 3);
            tblMain.Controls.Add(txtDateDrafted, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 5);
            tblMain.Controls.Add(txtDateArchived, 1, 6);
            tblMain.Controls.Add(txtRecipeStatus, 1, 7);
            tblMain.Controls.Add(txtRecipePic, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
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
            tblMain.Size = new Size(360, 351);
            tblMain.TabIndex = 1;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(119, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(238, 23);
            txtRecipeName.TabIndex = 9;
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Location = new Point(119, 41);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(238, 23);
            txtUserName.TabIndex = 10;
            // 
            // txtCuisine
            // 
            txtCuisine.Dock = DockStyle.Fill;
            txtCuisine.Location = new Point(119, 79);
            txtCuisine.Name = "txtCuisine";
            txtCuisine.Size = new Size(238, 23);
            txtCuisine.TabIndex = 11;
            // 
            // txtNumCalories
            // 
            txtNumCalories.Dock = DockStyle.Fill;
            txtNumCalories.Location = new Point(119, 117);
            txtNumCalories.Name = "txtNumCalories";
            txtNumCalories.Size = new Size(238, 23);
            txtNumCalories.TabIndex = 12;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Location = new Point(119, 155);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(238, 23);
            txtDateDrafted.TabIndex = 13;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(119, 193);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(238, 23);
            txtDatePublished.TabIndex = 14;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(119, 231);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(238, 23);
            txtDateArchived.TabIndex = 15;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(119, 269);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(238, 23);
            txtRecipeStatus.TabIndex = 16;
            // 
            // txtRecipePic
            // 
            txtRecipePic.Dock = DockStyle.Fill;
            txtRecipePic.Location = new Point(119, 307);
            txtRecipePic.Name = "txtRecipePic";
            txtRecipePic.Size = new Size(238, 23);
            txtRecipePic.TabIndex = 17;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 351);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "frmRecipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txtDateDrafted;
        private TextBox txtNumCalories;
        private TextBox txtCuisine;
        private TextBox txtUserName;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeStatus;
        private TextBox txtRecipePic;
    }
}