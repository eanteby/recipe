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
            tsIngredients = new TabControl();
            tabPage1 = new TabPage();
            tblIngredients = new TableLayoutPanel();
            gIngredients = new DataGridView();
            btnSaveIngredient = new Button();
            tabPage2 = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveStep = new Button();
            gSteps = new DataGridView();
            tblButtons = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            btnChangeStatus = new Button();
            txtRecipeName = new TextBox();
            lstUserName = new ComboBox();
            lstCuisineType = new ComboBox();
            lblRecipeStatus = new Label();
            tblStatus = new TableLayoutPanel();
            lblDateArchived = new Label();
            lblDatePublished = new Label();
            lblDateDrafted = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionDatePublished = new Label();
            lblCatptionDateDrafted = new Label();
            lblCaptionRecipeName = new Label();
            lblCaptionUserName = new Label();
            lblCaptionCuisine = new Label();
            lblCaptionNumCalories = new Label();
            lblCaptionCurrentStatus = new Label();
            lblCaptionStatusDates = new Label();
            tblMain = new TableLayoutPanel();
            numNumCalories = new NumericUpDown();
            tsIngredients.SuspendLayout();
            tabPage1.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tabPage2.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            tblButtons.SuspendLayout();
            tblStatus.SuspendLayout();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumCalories).BeginInit();
            SuspendLayout();
            // 
            // tsIngredients
            // 
            tblMain.SetColumnSpan(tsIngredients, 2);
            tsIngredients.Controls.Add(tabPage1);
            tsIngredients.Controls.Add(tabPage2);
            tsIngredients.Dock = DockStyle.Fill;
            tsIngredients.Location = new Point(3, 267);
            tsIngredients.Name = "tsIngredients";
            tsIngredients.SelectedIndex = 0;
            tsIngredients.Size = new Size(589, 353);
            tsIngredients.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblIngredients);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(581, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingredients";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.AutoScroll = true;
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Controls.Add(btnSaveIngredient, 0, 0);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.Size = new Size(575, 314);
            tblIngredients.TabIndex = 0;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 38);
            gIngredients.Name = "gIngredients";
            gIngredients.RowHeadersWidth = 51;
            gIngredients.Size = new Size(569, 273);
            gIngredients.TabIndex = 0;
            // 
            // btnSaveIngredient
            // 
            btnSaveIngredient.Location = new Point(3, 3);
            btnSaveIngredient.Name = "btnSaveIngredient";
            btnSaveIngredient.Size = new Size(94, 29);
            btnSaveIngredient.TabIndex = 1;
            btnSaveIngredient.Text = "Save";
            btnSaveIngredient.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblSteps);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(581, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Steps";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.AutoScroll = true;
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnSaveStep, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.Size = new Size(575, 314);
            tblSteps.TabIndex = 0;
            // 
            // btnSaveStep
            // 
            btnSaveStep.Location = new Point(3, 3);
            btnSaveStep.Name = "btnSaveStep";
            btnSaveStep.Size = new Size(94, 29);
            btnSaveStep.TabIndex = 0;
            btnSaveStep.Text = "Save";
            btnSaveStep.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 38);
            gSteps.Name = "gSteps";
            gSteps.RowHeadersWidth = 51;
            gSteps.Size = new Size(569, 273);
            gSteps.TabIndex = 1;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 4;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnChangeStatus, 3, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(589, 38);
            tblButtons.TabIndex = 35;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(93, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.WhiteSmoke;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.BackColor = Color.WhiteSmoke;
            btnChangeStatus.Location = new Point(473, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(113, 30);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(147, 47);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(443, 27);
            txtRecipeName.TabIndex = 1;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(147, 81);
            lstUserName.Margin = new Padding(3, 4, 3, 4);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(215, 28);
            lstUserName.TabIndex = 3;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(147, 117);
            lstCuisineType.Margin = new Padding(3, 4, 3, 4);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(215, 28);
            lstCuisineType.TabIndex = 5;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.BackColor = Color.LightGray;
            lblRecipeStatus.BorderStyle = BorderStyle.FixedSingle;
            lblRecipeStatus.Location = new Point(147, 187);
            lblRecipeStatus.Margin = new Padding(3, 5, 3, 5);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(215, 22);
            lblRecipeStatus.TabIndex = 9;
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 3;
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblStatus.Controls.Add(lblDateArchived, 2, 1);
            tblStatus.Controls.Add(lblDatePublished, 1, 1);
            tblStatus.Controls.Add(lblDateDrafted, 0, 1);
            tblStatus.Controls.Add(lblCaptionDateArchived, 2, 0);
            tblStatus.Controls.Add(lblCaptionDatePublished, 1, 0);
            tblStatus.Controls.Add(lblCatptionDateDrafted, 0, 0);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(147, 217);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 47.36842F));
            tblStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 52.63158F));
            tblStatus.Size = new Size(445, 44);
            tblStatus.TabIndex = 31;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AccessibleName = "lblDate";
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.LightGray;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(299, 20);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(143, 24);
            lblDateArchived.TabIndex = 5;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AccessibleName = "lblDate";
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.LightGray;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(151, 20);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(142, 24);
            lblDatePublished.TabIndex = 4;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AccessibleName = "lblDate";
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.LightGray;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(3, 20);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(142, 24);
            lblDateDrafted.TabIndex = 3;
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Dock = DockStyle.Fill;
            lblCaptionDateArchived.Font = new Font("Segoe UI", 7.8F);
            lblCaptionDateArchived.Location = new Point(299, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(143, 20);
            lblCaptionDateArchived.TabIndex = 2;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Dock = DockStyle.Fill;
            lblCaptionDatePublished.Font = new Font("Segoe UI", 7.8F);
            lblCaptionDatePublished.Location = new Point(151, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(142, 20);
            lblCaptionDatePublished.TabIndex = 1;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCatptionDateDrafted
            // 
            lblCatptionDateDrafted.AutoSize = true;
            lblCatptionDateDrafted.Dock = DockStyle.Fill;
            lblCatptionDateDrafted.Font = new Font("Segoe UI", 7.8F);
            lblCatptionDateDrafted.Location = new Point(3, 0);
            lblCatptionDateDrafted.Name = "lblCatptionDateDrafted";
            lblCatptionDateDrafted.Size = new Size(142, 20);
            lblCatptionDateDrafted.TabIndex = 0;
            lblCatptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(3, 50);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(98, 20);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            lblCaptionRecipeName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionUserName
            // 
            lblCaptionUserName.Anchor = AnchorStyles.Left;
            lblCaptionUserName.AutoSize = true;
            lblCaptionUserName.Location = new Point(3, 85);
            lblCaptionUserName.Name = "lblCaptionUserName";
            lblCaptionUserName.Size = new Size(82, 20);
            lblCaptionUserName.TabIndex = 2;
            lblCaptionUserName.Text = "User Name";
            lblCaptionUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionCuisine
            // 
            lblCaptionCuisine.Anchor = AnchorStyles.Left;
            lblCaptionCuisine.AutoSize = true;
            lblCaptionCuisine.Location = new Point(3, 121);
            lblCaptionCuisine.Name = "lblCaptionCuisine";
            lblCaptionCuisine.Size = new Size(56, 20);
            lblCaptionCuisine.TabIndex = 4;
            lblCaptionCuisine.Text = "Cuisine";
            lblCaptionCuisine.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionNumCalories
            // 
            lblCaptionNumCalories.Anchor = AnchorStyles.Left;
            lblCaptionNumCalories.AutoSize = true;
            lblCaptionNumCalories.Location = new Point(3, 155);
            lblCaptionNumCalories.Name = "lblCaptionNumCalories";
            lblCaptionNumCalories.Size = new Size(138, 20);
            lblCaptionNumCalories.TabIndex = 6;
            lblCaptionNumCalories.Text = "Number of Calories";
            lblCaptionNumCalories.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionCurrentStatus
            // 
            lblCaptionCurrentStatus.Anchor = AnchorStyles.Left;
            lblCaptionCurrentStatus.AutoSize = true;
            lblCaptionCurrentStatus.Location = new Point(3, 188);
            lblCaptionCurrentStatus.Margin = new Padding(3, 5, 3, 5);
            lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            lblCaptionCurrentStatus.Size = new Size(101, 20);
            lblCaptionCurrentStatus.TabIndex = 8;
            lblCaptionCurrentStatus.Text = "Current Status";
            lblCaptionCurrentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionStatusDates
            // 
            lblCaptionStatusDates.Anchor = AnchorStyles.Left;
            lblCaptionStatusDates.AutoSize = true;
            lblCaptionStatusDates.Location = new Point(3, 229);
            lblCaptionStatusDates.Name = "lblCaptionStatusDates";
            lblCaptionStatusDates.Size = new Size(91, 20);
            lblCaptionStatusDates.TabIndex = 10;
            lblCaptionStatusDates.Text = "Status Dates";
            lblCaptionStatusDates.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionStatusDates, 0, 7);
            tblMain.Controls.Add(lblCaptionCurrentStatus, 0, 5);
            tblMain.Controls.Add(lblCaptionNumCalories, 0, 4);
            tblMain.Controls.Add(lblCaptionCuisine, 0, 3);
            tblMain.Controls.Add(lblCaptionUserName, 0, 2);
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 1);
            tblMain.Controls.Add(tblStatus, 1, 7);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(lstCuisineType, 1, 3);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Controls.Add(tsIngredients, 0, 8);
            tblMain.Controls.Add(numNumCalories, 1, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 4, 3, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(595, 623);
            tblMain.TabIndex = 1;
            // 
            // numNumCalories
            // 
            numNumCalories.Location = new Point(147, 152);
            numNumCalories.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numNumCalories.Name = "numNumCalories";
            numNumCalories.Size = new Size(215, 27);
            numNumCalories.TabIndex = 36;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(595, 623);
            Controls.Add(tblMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRecipe";
            Text = "frmRecipe";
            Load += FrmRecipe_Shown;
            tsIngredients.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tabPage2.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNumCalories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tsIngredients;
        private TableLayoutPanel tblMain;
        private Label lblCaptionStatusDates;
        private Label lblCaptionCurrentStatus;
        private Label lblCaptionNumCalories;
        private Label lblCaptionCuisine;
        private Label lblCaptionUserName;
        private Label lblCaptionRecipeName;
        private TableLayoutPanel tblStatus;
        private Label lblDateArchived;
        private Label lblDatePublished;
        private Label lblDateDrafted;
        private Label lblCaptionDateArchived;
        private Label lblCaptionDatePublished;
        private Label lblCatptionDateDrafted;
        private Label lblRecipeStatus;
        private ComboBox lstCuisineType;
        private ComboBox lstUserName;
        private TextBox txtRecipeName;
        private TableLayoutPanel tblButtons;
        private Button btnDelete;
        private Button btnSave;
        private Button btnChangeStatus;
        private NumericUpDown numNumCalories;
        private TabPage tabPage1;
        private TableLayoutPanel tblIngredients;
        private DataGridView gIngredients;
        private Button btnSaveIngredient;
        private TabPage tabPage2;
        private TableLayoutPanel tblSteps;
        private Button btnSaveStep;
        private DataGridView gSteps;
    }
}