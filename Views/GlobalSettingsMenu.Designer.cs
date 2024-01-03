namespace Wage_Wizard.Views
{
    partial class GlobalSettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalSettingsMenu));
            globalTaxRateNumericField = new NumericUpDown();
            GlobalLeaveRateDescriptionLabel = new Label();
            GlobalSuperRateDescriptionLabel = new Label();
            GlobalTaxRateDescriptionLabel = new Label();
            GlobalLeaveRateLabel = new Label();
            GlobalSuperAnnuationLabel = new Label();
            GlobalTaxRateLabel = new Label();
            exitBtn = new Button();
            Header = new Label();
            globalSuperRateNumericField = new NumericUpDown();
            globalLeaveRateNumericField = new NumericUpDown();
            Subheader = new Label();
            ResetDefaultValuesBtn = new Button();
            percentageSymbol1 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)globalTaxRateNumericField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)globalSuperRateNumericField).BeginInit();
            ((System.ComponentModel.ISupportInitialize)globalLeaveRateNumericField).BeginInit();
            SuspendLayout();
            // 
            // globalTaxRateNumericField
            // 
            globalTaxRateNumericField.Location = new Point(223, 147);
            globalTaxRateNumericField.Name = "globalTaxRateNumericField";
            globalTaxRateNumericField.Size = new Size(120, 23);
            globalTaxRateNumericField.TabIndex = 36;
            globalTaxRateNumericField.TextAlign = HorizontalAlignment.Center;
            globalTaxRateNumericField.UpDownAlign = LeftRightAlignment.Left;
            // 
            // GlobalLeaveRateDescriptionLabel
            // 
            GlobalLeaveRateDescriptionLabel.AutoSize = true;
            GlobalLeaveRateDescriptionLabel.Location = new Point(135, 298);
            GlobalLeaveRateDescriptionLabel.Name = "GlobalLeaveRateDescriptionLabel";
            GlobalLeaveRateDescriptionLabel.Size = new Size(297, 15);
            GlobalLeaveRateDescriptionLabel.TabIndex = 35;
            GlobalLeaveRateDescriptionLabel.Text = "The percentage of salary allocated for employee leaves.";
            // 
            // GlobalSuperRateDescriptionLabel
            // 
            GlobalSuperRateDescriptionLabel.AutoSize = true;
            GlobalSuperRateDescriptionLabel.Location = new Point(112, 209);
            GlobalSuperRateDescriptionLabel.Name = "GlobalSuperRateDescriptionLabel";
            GlobalSuperRateDescriptionLabel.Size = new Size(382, 15);
            GlobalSuperRateDescriptionLabel.TabIndex = 34;
            GlobalSuperRateDescriptionLabel.Text = "The percentage of salary contributed to an employee's retirement fund.";
            // 
            // GlobalTaxRateDescriptionLabel
            // 
            GlobalTaxRateDescriptionLabel.AutoSize = true;
            GlobalTaxRateDescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalTaxRateDescriptionLabel.Location = new Point(163, 129);
            GlobalTaxRateDescriptionLabel.Name = "GlobalTaxRateDescriptionLabel";
            GlobalTaxRateDescriptionLabel.Size = new Size(239, 15);
            GlobalTaxRateDescriptionLabel.TabIndex = 33;
            GlobalTaxRateDescriptionLabel.Text = "The percentage of salary deducted for taxes.";
            // 
            // GlobalLeaveRateLabel
            // 
            GlobalLeaveRateLabel.AutoSize = true;
            GlobalLeaveRateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GlobalLeaveRateLabel.Location = new Point(209, 278);
            GlobalLeaveRateLabel.Name = "GlobalLeaveRateLabel";
            GlobalLeaveRateLabel.Size = new Size(134, 20);
            GlobalLeaveRateLabel.TabIndex = 32;
            GlobalLeaveRateLabel.Text = "Global Leave Rate";
            // 
            // GlobalSuperAnnuationLabel
            // 
            GlobalSuperAnnuationLabel.AutoSize = true;
            GlobalSuperAnnuationLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GlobalSuperAnnuationLabel.Location = new Point(192, 189);
            GlobalSuperAnnuationLabel.Name = "GlobalSuperAnnuationLabel";
            GlobalSuperAnnuationLabel.Size = new Size(176, 20);
            GlobalSuperAnnuationLabel.TabIndex = 31;
            GlobalSuperAnnuationLabel.Text = "Global Super Annuation";
            // 
            // GlobalTaxRateLabel
            // 
            GlobalTaxRateLabel.AutoSize = true;
            GlobalTaxRateLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            GlobalTaxRateLabel.Location = new Point(221, 109);
            GlobalTaxRateLabel.Name = "GlobalTaxRateLabel";
            GlobalTaxRateLabel.Size = new Size(118, 20);
            GlobalTaxRateLabel.TabIndex = 30;
            GlobalTaxRateLabel.Text = "Global Tax Rate";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(316, 391);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(178, 44);
            exitBtn.TabIndex = 29;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(156, 9);
            Header.Name = "Header";
            Header.Size = new Size(257, 54);
            Header.TabIndex = 28;
            Header.Text = "Wage Wizard";
            // 
            // globalSuperRateNumericField
            // 
            globalSuperRateNumericField.Location = new Point(223, 227);
            globalSuperRateNumericField.Name = "globalSuperRateNumericField";
            globalSuperRateNumericField.Size = new Size(120, 23);
            globalSuperRateNumericField.TabIndex = 37;
            globalSuperRateNumericField.TextAlign = HorizontalAlignment.Center;
            globalSuperRateNumericField.UpDownAlign = LeftRightAlignment.Left;
            // 
            // globalLeaveRateNumericField
            // 
            globalLeaveRateNumericField.Location = new Point(221, 316);
            globalLeaveRateNumericField.Name = "globalLeaveRateNumericField";
            globalLeaveRateNumericField.Size = new Size(120, 23);
            globalLeaveRateNumericField.TabIndex = 38;
            globalLeaveRateNumericField.TextAlign = HorizontalAlignment.Center;
            globalLeaveRateNumericField.UpDownAlign = LeftRightAlignment.Left;
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(193, 63);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(175, 32);
            Subheader.TabIndex = 39;
            Subheader.Text = "Global Settings";
            // 
            // ResetDefaultValuesBtn
            // 
            ResetDefaultValuesBtn.Location = new Point(112, 391);
            ResetDefaultValuesBtn.Name = "ResetDefaultValuesBtn";
            ResetDefaultValuesBtn.Size = new Size(178, 44);
            ResetDefaultValuesBtn.TabIndex = 40;
            ResetDefaultValuesBtn.Text = "Reset To Default Values";
            ResetDefaultValuesBtn.UseVisualStyleBackColor = true;
            ResetDefaultValuesBtn.Click += ResetDefaultValuesBtn_Click;
            // 
            // percentageSymbol1
            // 
            percentageSymbol1.AutoSize = true;
            percentageSymbol1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            percentageSymbol1.Location = new Point(349, 228);
            percentageSymbol1.Name = "percentageSymbol1";
            percentageSymbol1.Size = new Size(21, 20);
            percentageSymbol1.TabIndex = 41;
            percentageSymbol1.Text = "%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(349, 147);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 42;
            label1.Text = "%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(348, 317);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 43;
            label2.Text = "%";
            // 
            // GlobalSettingsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(percentageSymbol1);
            Controls.Add(ResetDefaultValuesBtn);
            Controls.Add(Subheader);
            Controls.Add(globalLeaveRateNumericField);
            Controls.Add(globalSuperRateNumericField);
            Controls.Add(globalTaxRateNumericField);
            Controls.Add(GlobalLeaveRateDescriptionLabel);
            Controls.Add(GlobalSuperRateDescriptionLabel);
            Controls.Add(GlobalTaxRateDescriptionLabel);
            Controls.Add(GlobalLeaveRateLabel);
            Controls.Add(GlobalSuperAnnuationLabel);
            Controls.Add(GlobalTaxRateLabel);
            Controls.Add(exitBtn);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GlobalSettingsMenu";
            Text = "Global Settings";
            Load += GlobalSettings_Load;
            ((System.ComponentModel.ISupportInitialize)globalTaxRateNumericField).EndInit();
            ((System.ComponentModel.ISupportInitialize)globalSuperRateNumericField).EndInit();
            ((System.ComponentModel.ISupportInitialize)globalLeaveRateNumericField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown globalTaxRateNumericField;
        private Label GlobalLeaveRateDescriptionLabel;
        private Label GlobalSuperRateDescriptionLabel;
        private Label GlobalTaxRateDescriptionLabel;
        private Label GlobalLeaveRateLabel;
        private Label GlobalSuperAnnuationLabel;
        private Label GlobalTaxRateLabel;
        private Button exitBtn;
        private Label Header;
        private NumericUpDown globalSuperRateNumericField;
        private NumericUpDown globalLeaveRateNumericField;
        private Label Subheader;
        private Button button1;
        private Button ResetDefaultValuesBtn;
        private Label percentageSymbol1;
        private Label label1;
        private Label label2;
    }
}