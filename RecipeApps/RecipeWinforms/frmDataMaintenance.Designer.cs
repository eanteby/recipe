namespace RecipeWinforms
{
    partial class frmDataMaintenance
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
            pnlButtons = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            tblData = new TableLayoutPanel();
            btnSave = new Button();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            pnlButtons.SuspendLayout();
            tblData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tblMain.Controls.Add(pnlButtons, 0, 0);
            tblMain.Controls.Add(tblData, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(optUsers);
            pnlButtons.Controls.Add(optCuisines);
            pnlButtons.Controls.Add(optIngredients);
            pnlButtons.Controls.Add(optMeasurements);
            pnlButtons.Controls.Add(optCourses);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.FlowDirection = FlowDirection.TopDown;
            pnlButtons.Location = new Point(15, 15);
            pnlButtons.Margin = new Padding(15, 15, 3, 3);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(182, 432);
            pnlButtons.TabIndex = 0;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Font = new Font("Segoe UI", 10.8F);
            optUsers.Location = new Point(3, 7);
            optUsers.Margin = new Padding(3, 7, 3, 3);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(76, 29);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.AutoSize = true;
            optCuisines.Font = new Font("Segoe UI", 10.8F);
            optCuisines.Location = new Point(3, 46);
            optCuisines.Margin = new Padding(3, 7, 3, 3);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(97, 29);
            optCuisines.TabIndex = 1;
            optCuisines.TabStop = true;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.AutoSize = true;
            optIngredients.Font = new Font("Segoe UI", 10.8F);
            optIngredients.Location = new Point(3, 85);
            optIngredients.Margin = new Padding(3, 7, 3, 3);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(122, 29);
            optIngredients.TabIndex = 2;
            optIngredients.TabStop = true;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.AutoSize = true;
            optMeasurements.Font = new Font("Segoe UI", 10.8F);
            optMeasurements.Location = new Point(3, 124);
            optMeasurements.Margin = new Padding(3, 7, 3, 3);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(149, 29);
            optMeasurements.TabIndex = 3;
            optMeasurements.TabStop = true;
            optMeasurements.Text = "Measurements";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.AutoSize = true;
            optCourses.Font = new Font("Segoe UI", 10.8F);
            optCourses.Location = new Point(3, 163);
            optCourses.Margin = new Padding(3, 7, 3, 3);
            optCourses.Name = "optCourses";
            optCourses.Size = new Size(96, 29);
            optCourses.TabIndex = 4;
            optCourses.TabStop = true;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // tblData
            // 
            tblData.ColumnCount = 1;
            tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblData.Controls.Add(btnSave, 0, 1);
            tblData.Controls.Add(gData, 0, 0);
            tblData.Dock = DockStyle.Fill;
            tblData.Location = new Point(203, 3);
            tblData.Name = "tblData";
            tblData.RowCount = 2;
            tblData.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblData.RowStyles.Add(new RowStyle());
            tblData.Size = new Size(594, 444);
            tblData.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(497, 411);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(3, 3);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.Size = new Size(588, 402);
            gData.TabIndex = 1;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDataMaintenance";
            Text = "Hearty Hearth - Data Maintenance";
            tblMain.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            tblData.ResumeLayout(false);
            tblData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private FlowLayoutPanel pnlButtons;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private TableLayoutPanel tblData;
        private Button btnSave;
        private DataGridView gData;
    }
}