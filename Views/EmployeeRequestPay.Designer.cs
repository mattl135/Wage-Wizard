﻿namespace Wage_Wizard.Views
{
    partial class EmployeeRequestPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeRequestPay));
            Subheader = new Label();
            Header = new Label();
            ExitBtn = new Button();
            MonLabel = new Label();
            TueLabel = new Label();
            WedLabel = new Label();
            ThuLabel = new Label();
            FriLabel = new Label();
            HoursLabel = new Label();
            TotalHoursLabel = new Label();
            TotalHoursDisplay = new Label();
            RequestPayBtn = new Button();
            MonHours = new NumericUpDown();
            TueHours = new NumericUpDown();
            WedHours = new NumericUpDown();
            ThuHours = new NumericUpDown();
            FriHours = new NumericUpDown();
            PayRateLabel = new Label();
            PayRateDisplay = new Label();
            TotalPayLabel = new Label();
            TotalPayDisplay = new Label();
            SuperLabel = new Label();
            TotalSuperDisplay = new Label();
            TotalTaxLabel = new Label();
            TotalTaxDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)MonHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TueHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WedHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThuHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FriHours).BeginInit();
            SuspendLayout();
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(276, 68);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(220, 37);
            Subheader.TabIndex = 12;
            Subheader.Text = "Request Payment";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(257, 7);
            Header.Name = "Header";
            Header.Size = new Size(257, 54);
            Header.TabIndex = 11;
            Header.Text = "Wage Wizard";
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(678, 468);
            ExitBtn.Margin = new Padding(3, 2, 3, 2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(82, 53);
            ExitBtn.TabIndex = 21;
            ExitBtn.Text = "Exit";
            ExitBtn.UseMnemonic = false;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // MonLabel
            // 
            MonLabel.AutoSize = true;
            MonLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MonLabel.Location = new Point(112, 180);
            MonLabel.Name = "MonLabel";
            MonLabel.Size = new Size(85, 25);
            MonLabel.TabIndex = 22;
            MonLabel.Text = "Monday:";
            // 
            // TueLabel
            // 
            TueLabel.AutoSize = true;
            TueLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TueLabel.Location = new Point(112, 221);
            TueLabel.Name = "TueLabel";
            TueLabel.Size = new Size(85, 25);
            TueLabel.TabIndex = 23;
            TueLabel.Text = "Tuesday:";
            // 
            // WedLabel
            // 
            WedLabel.AutoSize = true;
            WedLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            WedLabel.Location = new Point(84, 262);
            WedLabel.Name = "WedLabel";
            WedLabel.Size = new Size(113, 25);
            WedLabel.TabIndex = 24;
            WedLabel.Text = "Wednesday:";
            // 
            // ThuLabel
            // 
            ThuLabel.AutoSize = true;
            ThuLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ThuLabel.Location = new Point(104, 303);
            ThuLabel.Name = "ThuLabel";
            ThuLabel.Size = new Size(93, 25);
            ThuLabel.TabIndex = 25;
            ThuLabel.Text = "Thursday:";
            // 
            // FriLabel
            // 
            FriLabel.AutoSize = true;
            FriLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FriLabel.Location = new Point(130, 344);
            FriLabel.Name = "FriLabel";
            FriLabel.Size = new Size(67, 25);
            FriLabel.TabIndex = 26;
            FriLabel.Text = "Friday;";
            // 
            // HoursLabel
            // 
            HoursLabel.AutoSize = true;
            HoursLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            HoursLabel.Location = new Point(235, 144);
            HoursLabel.Name = "HoursLabel";
            HoursLabel.Size = new Size(62, 25);
            HoursLabel.TabIndex = 33;
            HoursLabel.Text = "Hours";
            // 
            // TotalHoursLabel
            // 
            TotalHoursLabel.AutoSize = true;
            TotalHoursLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalHoursLabel.Location = new Point(452, 180);
            TotalHoursLabel.Name = "TotalHoursLabel";
            TotalHoursLabel.Size = new Size(111, 25);
            TotalHoursLabel.TabIndex = 34;
            TotalHoursLabel.Text = "Total Hours:";
            // 
            // TotalHoursDisplay
            // 
            TotalHoursDisplay.AutoSize = true;
            TotalHoursDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalHoursDisplay.Location = new Point(587, 180);
            TotalHoursDisplay.Name = "TotalHoursDisplay";
            TotalHoursDisplay.Size = new Size(22, 25);
            TotalHoursDisplay.TabIndex = 35;
            TotalHoursDisplay.Text = "0";
            TotalHoursDisplay.UseMnemonic = false;
            // 
            // RequestPayBtn
            // 
            RequestPayBtn.Location = new Point(520, 468);
            RequestPayBtn.Margin = new Padding(3, 2, 3, 2);
            RequestPayBtn.Name = "RequestPayBtn";
            RequestPayBtn.Size = new Size(119, 53);
            RequestPayBtn.TabIndex = 36;
            RequestPayBtn.Text = "Request Pay";
            RequestPayBtn.UseMnemonic = false;
            RequestPayBtn.UseVisualStyleBackColor = true;
            RequestPayBtn.Click += RequestPayBtn_Click;
            // 
            // MonHours
            // 
            MonHours.DecimalPlaces = 1;
            MonHours.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MonHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            MonHours.Location = new Point(219, 176);
            MonHours.Margin = new Padding(3, 2, 3, 2);
            MonHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            MonHours.Name = "MonHours";
            MonHours.Size = new Size(94, 32);
            MonHours.TabIndex = 38;
            MonHours.ValueChanged += MonHours_ValueChanged;
            // 
            // TueHours
            // 
            TueHours.DecimalPlaces = 1;
            TueHours.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TueHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            TueHours.Location = new Point(219, 217);
            TueHours.Margin = new Padding(3, 2, 3, 2);
            TueHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            TueHours.Name = "TueHours";
            TueHours.Size = new Size(94, 32);
            TueHours.TabIndex = 39;
            TueHours.ValueChanged += TueHours_ValueChanged;
            // 
            // WedHours
            // 
            WedHours.DecimalPlaces = 1;
            WedHours.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            WedHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            WedHours.Location = new Point(219, 258);
            WedHours.Margin = new Padding(3, 2, 3, 2);
            WedHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            WedHours.Name = "WedHours";
            WedHours.Size = new Size(94, 32);
            WedHours.TabIndex = 40;
            WedHours.ValueChanged += WedHours_ValueChanged;
            // 
            // ThuHours
            // 
            ThuHours.DecimalPlaces = 1;
            ThuHours.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ThuHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            ThuHours.Location = new Point(219, 299);
            ThuHours.Margin = new Padding(3, 2, 3, 2);
            ThuHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            ThuHours.Name = "ThuHours";
            ThuHours.Size = new Size(94, 32);
            ThuHours.TabIndex = 41;
            ThuHours.ValueChanged += ThuHours_ValueChanged;
            // 
            // FriHours
            // 
            FriHours.DecimalPlaces = 1;
            FriHours.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FriHours.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            FriHours.Location = new Point(219, 340);
            FriHours.Margin = new Padding(3, 2, 3, 2);
            FriHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            FriHours.Name = "FriHours";
            FriHours.Size = new Size(94, 32);
            FriHours.TabIndex = 42;
            FriHours.ValueChanged += FriHours_ValueChanged;
            // 
            // PayRateLabel
            // 
            PayRateLabel.AutoSize = true;
            PayRateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PayRateLabel.Location = new Point(411, 221);
            PayRateLabel.Name = "PayRateLabel";
            PayRateLabel.Size = new Size(148, 25);
            PayRateLabel.TabIndex = 43;
            PayRateLabel.Text = "Hourly Pay Rate:";
            // 
            // PayRateDisplay
            // 
            PayRateDisplay.AutoSize = true;
            PayRateDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PayRateDisplay.Location = new Point(587, 221);
            PayRateDisplay.Name = "PayRateDisplay";
            PayRateDisplay.Size = new Size(32, 25);
            PayRateDisplay.TabIndex = 44;
            PayRateDisplay.Text = "$0";
            // 
            // TotalPayLabel
            // 
            TotalPayLabel.AutoSize = true;
            TotalPayLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPayLabel.Location = new Point(476, 262);
            TotalPayLabel.Name = "TotalPayLabel";
            TotalPayLabel.Size = new Size(90, 25);
            TotalPayLabel.TabIndex = 45;
            TotalPayLabel.Text = "Total Pay:";
            // 
            // TotalPayDisplay
            // 
            TotalPayDisplay.AutoSize = true;
            TotalPayDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPayDisplay.Location = new Point(587, 262);
            TotalPayDisplay.Name = "TotalPayDisplay";
            TotalPayDisplay.Size = new Size(32, 25);
            TotalPayDisplay.TabIndex = 46;
            TotalPayDisplay.Text = "$0";
            // 
            // SuperLabel
            // 
            SuperLabel.AutoSize = true;
            SuperLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SuperLabel.Location = new Point(453, 303);
            SuperLabel.Name = "SuperLabel";
            SuperLabel.Size = new Size(110, 25);
            SuperLabel.TabIndex = 47;
            SuperLabel.Text = "Total Super:";
            // 
            // TotalSuperDisplay
            // 
            TotalSuperDisplay.AutoSize = true;
            TotalSuperDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalSuperDisplay.Location = new Point(587, 303);
            TotalSuperDisplay.Name = "TotalSuperDisplay";
            TotalSuperDisplay.Size = new Size(32, 25);
            TotalSuperDisplay.TabIndex = 48;
            TotalSuperDisplay.Text = "$0";
            // 
            // TotalTaxLabel
            // 
            TotalTaxLabel.AutoSize = true;
            TotalTaxLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalTaxLabel.Location = new Point(479, 344);
            TotalTaxLabel.Name = "TotalTaxLabel";
            TotalTaxLabel.Size = new Size(88, 25);
            TotalTaxLabel.TabIndex = 49;
            TotalTaxLabel.Text = "Total Tax:";
            // 
            // TotalTaxDisplay
            // 
            TotalTaxDisplay.AutoSize = true;
            TotalTaxDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalTaxDisplay.Location = new Point(587, 344);
            TotalTaxDisplay.Name = "TotalTaxDisplay";
            TotalTaxDisplay.Size = new Size(32, 25);
            TotalTaxDisplay.TabIndex = 50;
            TotalTaxDisplay.Text = "$0";
            // 
            // EmployeeRequestPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 530);
            Controls.Add(TotalTaxDisplay);
            Controls.Add(TotalTaxLabel);
            Controls.Add(TotalSuperDisplay);
            Controls.Add(SuperLabel);
            Controls.Add(TotalPayDisplay);
            Controls.Add(TotalPayLabel);
            Controls.Add(PayRateDisplay);
            Controls.Add(PayRateLabel);
            Controls.Add(FriHours);
            Controls.Add(ThuHours);
            Controls.Add(WedHours);
            Controls.Add(TueHours);
            Controls.Add(MonHours);
            Controls.Add(RequestPayBtn);
            Controls.Add(TotalHoursDisplay);
            Controls.Add(TotalHoursLabel);
            Controls.Add(HoursLabel);
            Controls.Add(FriLabel);
            Controls.Add(ThuLabel);
            Controls.Add(WedLabel);
            Controls.Add(TueLabel);
            Controls.Add(MonLabel);
            Controls.Add(ExitBtn);
            Controls.Add(Subheader);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EmployeeRequestPay";
            Text = "Request Payment";
            ((System.ComponentModel.ISupportInitialize)MonHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)TueHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)WedHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThuHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)FriHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Subheader;
        private Label Header;
        private Button ExitBtn;
        private Label MonLabel;
        private Label TueLabel;
        private Label WedLabel;
        private Label ThuLabel;
        private Label FriLabel;
        private Label HoursLabel;
        private Label TotalHoursLabel;
        private Label TotalHoursDisplay;
        private Button RequestPayBtn;
        private NumericUpDown MonHours;
        private NumericUpDown TueHours;
        private NumericUpDown WedHours;
        private NumericUpDown ThuHours;
        private NumericUpDown FriHours;
        private Label PayRateLabel;
        private Label PayRateDisplay;
        private Label TotalPayLabel;
        private Label TotalPayDisplay;
        private Label SuperLabel;
        private Label TotalSuperDisplay;
        private Label TotalTaxLabel;
        private Label TotalTaxDisplay;
    }
}