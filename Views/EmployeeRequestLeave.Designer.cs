namespace Wage_Wizard.Views
{
    partial class EmployeeRequestLeave
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
            Header = new Label();
            Subheader = new Label();
            RequestLeaveBtn = new Button();
            ExitBtn = new Button();
            LeaveHours = new NumericUpDown();
            HoursLabel = new Label();
            LeaveDesLabel = new Label();
            LeaveDesTextBox = new TextBox();
            AvailHoursLabel = new Label();
            AvailHoursDisplay = new Label();
            ((System.ComponentModel.ISupportInitialize)LeaveHours).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(282, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 12;
            Header.Text = "Wage Wizard";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(318, 87);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(234, 46);
            Subheader.TabIndex = 13;
            Subheader.Text = "Request Leave";
            // 
            // RequestLeaveBtn
            // 
            RequestLeaveBtn.Location = new Point(590, 609);
            RequestLeaveBtn.Name = "RequestLeaveBtn";
            RequestLeaveBtn.Size = new Size(136, 71);
            RequestLeaveBtn.TabIndex = 37;
            RequestLeaveBtn.Text = "Request Leave";
            RequestLeaveBtn.UseMnemonic = false;
            RequestLeaveBtn.UseVisualStyleBackColor = true;
            RequestLeaveBtn.Click += RequestLeaveBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(757, 609);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(94, 71);
            ExitBtn.TabIndex = 38;
            ExitBtn.Text = "Exit";
            ExitBtn.UseMnemonic = false;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // LeaveHours
            // 
            LeaveHours.DecimalPlaces = 2;
            LeaveHours.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LeaveHours.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            LeaveHours.Location = new Point(143, 294);
            LeaveHours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LeaveHours.Name = "LeaveHours";
            LeaveHours.Size = new Size(107, 39);
            LeaveHours.TabIndex = 41;
            LeaveHours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            LeaveHours.ValueChanged += LeaveHours_ValueChanged;
            // 
            // HoursLabel
            // 
            HoursLabel.AutoSize = true;
            HoursLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            HoursLabel.Location = new Point(47, 294);
            HoursLabel.Name = "HoursLabel";
            HoursLabel.Size = new Size(77, 32);
            HoursLabel.TabIndex = 40;
            HoursLabel.Text = "Hours";
            // 
            // LeaveDesLabel
            // 
            LeaveDesLabel.AutoSize = true;
            LeaveDesLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LeaveDesLabel.Location = new Point(47, 377);
            LeaveDesLabel.Name = "LeaveDesLabel";
            LeaveDesLabel.Size = new Size(203, 32);
            LeaveDesLabel.TabIndex = 42;
            LeaveDesLabel.Text = "Leave Description";
            // 
            // LeaveDesTextBox
            // 
            LeaveDesTextBox.AcceptsReturn = true;
            LeaveDesTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LeaveDesTextBox.Location = new Point(47, 412);
            LeaveDesTextBox.Multiline = true;
            LeaveDesTextBox.Name = "LeaveDesTextBox";
            LeaveDesTextBox.Size = new Size(753, 141);
            LeaveDesTextBox.TabIndex = 43;
            // 
            // AvailHoursLabel
            // 
            AvailHoursLabel.AutoSize = true;
            AvailHoursLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AvailHoursLabel.Location = new Point(47, 224);
            AvailHoursLabel.Name = "AvailHoursLabel";
            AvailHoursLabel.Size = new Size(180, 32);
            AvailHoursLabel.TabIndex = 44;
            AvailHoursLabel.Text = "Available Hours";
            // 
            // AvailHoursDisplay
            // 
            AvailHoursDisplay.AutoSize = true;
            AvailHoursDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AvailHoursDisplay.Location = new Point(244, 224);
            AvailHoursDisplay.Name = "AvailHoursDisplay";
            AvailHoursDisplay.Size = new Size(27, 32);
            AvailHoursDisplay.TabIndex = 45;
            AvailHoursDisplay.Text = "0";
            // 
            // EmployeeRequestLeave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 707);
            Controls.Add(AvailHoursDisplay);
            Controls.Add(AvailHoursLabel);
            Controls.Add(LeaveDesTextBox);
            Controls.Add(LeaveDesLabel);
            Controls.Add(LeaveHours);
            Controls.Add(HoursLabel);
            Controls.Add(ExitBtn);
            Controls.Add(RequestLeaveBtn);
            Controls.Add(Subheader);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeeRequestLeave";
            Text = "Request Leave";
            ((System.ComponentModel.ISupportInitialize)LeaveHours).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label Subheader;
        private Button RequestLeaveBtn;
        private Button ExitBtn;
        private NumericUpDown LeaveHours;
        private Label HoursLabel;
        private Label LeaveDesLabel;
        private TextBox LeaveDesTextBox;
        private Label AvailHoursLabel;
        private Label AvailHoursDisplay;
    }
}