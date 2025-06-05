namespace RecipeWinforms
{
    partial class frmChangeRecipeStatus
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
            lblRecipeName = new Label();
            tblDates = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDraftedCaption = new Label();
            lblDateDrafted = new Label();
            lblPublishedCaption = new Label();
            lblDatePublished = new Label();
            lblArchivedCaption = new Label();
            lblDateArchived = new Label();
            tblButtons = new TableLayoutPanel();
            btnDateDrafted = new Button();
            btnDatePublished = new Button();
            btnDateArchived = new Button();
            tblStatDesc = new TableLayoutPanel();
            lblRecipeStatus = new Label();
            lblCurrentStatusCaption = new Label();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            tblButtons.SuspendLayout();
            tblStatDesc.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(tblDates, 0, 2);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Controls.Add(tblStatDesc, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(570, 322);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Top;
            lblRecipeName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 15);
            lblRecipeName.Margin = new Padding(3, 15, 3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(564, 45);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 5;
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblDates.Controls.Add(lblStatusDates, 0, 1);
            tblDates.Controls.Add(lblDraftedCaption, 1, 0);
            tblDates.Controls.Add(lblDateDrafted, 1, 1);
            tblDates.Controls.Add(lblPublishedCaption, 2, 0);
            tblDates.Controls.Add(lblDatePublished, 2, 1);
            tblDates.Controls.Add(lblArchivedCaption, 3, 0);
            tblDates.Controls.Add(lblDateArchived, 3, 1);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(3, 147);
            tblDates.Margin = new Padding(3, 3, 3, 20);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.Size = new Size(564, 73);
            tblDates.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(47, 36);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(91, 20);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDraftedCaption
            // 
            lblDraftedCaption.Anchor = AnchorStyles.Top;
            lblDraftedCaption.AutoSize = true;
            lblDraftedCaption.Location = new Point(167, 0);
            lblDraftedCaption.Name = "lblDraftedCaption";
            lblDraftedCaption.Size = new Size(60, 20);
            lblDraftedCaption.TabIndex = 1;
            lblDraftedCaption.Text = "Drafted";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.Anchor = AnchorStyles.Top;
            lblDateDrafted.BackColor = Color.LightGray;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Location = new Point(152, 36);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(89, 25);
            lblDateDrafted.TabIndex = 2;
            // 
            // lblPublishedCaption
            // 
            lblPublishedCaption.Anchor = AnchorStyles.Top;
            lblPublishedCaption.AutoSize = true;
            lblPublishedCaption.Location = new Point(272, 0);
            lblPublishedCaption.Name = "lblPublishedCaption";
            lblPublishedCaption.Size = new Size(73, 20);
            lblPublishedCaption.TabIndex = 3;
            lblPublishedCaption.Text = "Published";
            // 
            // lblDatePublished
            // 
            lblDatePublished.Anchor = AnchorStyles.Top;
            lblDatePublished.BackColor = Color.LightGray;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Location = new Point(264, 36);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(89, 25);
            lblDatePublished.TabIndex = 4;
            // 
            // lblArchivedCaption
            // 
            lblArchivedCaption.Anchor = AnchorStyles.Top;
            lblArchivedCaption.AutoSize = true;
            lblArchivedCaption.Location = new Point(387, 0);
            lblArchivedCaption.Name = "lblArchivedCaption";
            lblArchivedCaption.Size = new Size(67, 20);
            lblArchivedCaption.TabIndex = 5;
            lblArchivedCaption.Text = "Archived";
            // 
            // lblDateArchived
            // 
            lblDateArchived.Anchor = AnchorStyles.Top;
            lblDateArchived.BackColor = Color.LightGray;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Location = new Point(376, 36);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(89, 25);
            lblDateArchived.TabIndex = 6;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.Controls.Add(btnDateDrafted, 0, 0);
            tblButtons.Controls.Add(btnDatePublished, 1, 0);
            tblButtons.Controls.Add(btnDateArchived, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 243);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(564, 76);
            tblButtons.TabIndex = 3;
            // 
            // btnDateDrafted
            // 
            btnDateDrafted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDateDrafted.Location = new Point(91, 15);
            btnDateDrafted.Margin = new Padding(3, 15, 3, 3);
            btnDateDrafted.Name = "btnDateDrafted";
            btnDateDrafted.Size = new Size(94, 29);
            btnDateDrafted.TabIndex = 0;
            btnDateDrafted.Text = "Draft";
            btnDateDrafted.UseVisualStyleBackColor = true;
            // 
            // btnDatePublished
            // 
            btnDatePublished.Anchor = AnchorStyles.Top;
            btnDatePublished.Location = new Point(235, 15);
            btnDatePublished.Margin = new Padding(3, 15, 3, 3);
            btnDatePublished.Name = "btnDatePublished";
            btnDatePublished.Size = new Size(94, 29);
            btnDatePublished.TabIndex = 1;
            btnDatePublished.Text = "Publish";
            btnDatePublished.UseVisualStyleBackColor = true;
            // 
            // btnDateArchived
            // 
            btnDateArchived.Location = new Point(379, 15);
            btnDateArchived.Margin = new Padding(3, 15, 3, 3);
            btnDateArchived.Name = "btnDateArchived";
            btnDateArchived.Size = new Size(94, 29);
            btnDateArchived.TabIndex = 2;
            btnDateArchived.Text = "Archive";
            btnDateArchived.UseVisualStyleBackColor = true;
            // 
            // tblStatDesc
            // 
            tblStatDesc.ColumnCount = 2;
            tblStatDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatDesc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblStatDesc.Controls.Add(lblRecipeStatus, 1, 0);
            tblStatDesc.Controls.Add(lblCurrentStatusCaption, 0, 0);
            tblStatDesc.Dock = DockStyle.Fill;
            tblStatDesc.Location = new Point(3, 67);
            tblStatDesc.Name = "tblStatDesc";
            tblStatDesc.RowCount = 1;
            tblStatDesc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatDesc.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStatDesc.Size = new Size(564, 74);
            tblStatDesc.TabIndex = 4;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.Anchor = AnchorStyles.Left;
            lblRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeStatus.Location = new Point(285, 22);
            lblRecipeStatus.Margin = new Padding(3, 20, 3, 20);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(238, 29);
            lblRecipeStatus.TabIndex = 2;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCurrentStatusCaption
            // 
            lblCurrentStatusCaption.Anchor = AnchorStyles.Right;
            lblCurrentStatusCaption.AutoSize = true;
            lblCurrentStatusCaption.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStatusCaption.Location = new Point(156, 25);
            lblCurrentStatusCaption.Name = "lblCurrentStatusCaption";
            lblCurrentStatusCaption.Size = new Size(123, 23);
            lblCurrentStatusCaption.TabIndex = 3;
            lblCurrentStatusCaption.Text = "Current Status:";
            lblCurrentStatusCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmChangeRecipeStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(570, 322);
            Controls.Add(tblMain);
            Name = "frmChangeRecipeStatus";
            Text = "Recipe- Change Status";
            tblMain.ResumeLayout(false);
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblStatDesc.ResumeLayout(false);
            tblStatDesc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblDates;
        private Label lblStatusDates;
        private Label lblDraftedCaption;
        private Label lblDateDrafted;
        private Label lblPublishedCaption;
        private Label lblDatePublished;
        private Label lblArchivedCaption;
        private Label lblDateArchived;
        private TableLayoutPanel tblButtons;
        private Button btnDateDrafted;
        private Button btnDatePublished;
        private Button btnDateArchived;
        private TableLayoutPanel tblStatDesc;
        private Label lblRecipeStatus;
        private Label lblCurrentStatusCaption;
    }
}