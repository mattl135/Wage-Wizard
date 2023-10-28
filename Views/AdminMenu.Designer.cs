namespace Wage_Wizard.Views
{
    partial class AdminMenu
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
            WelcomeMsg = new Label();
            payApprovalBTN = new Button();
            payHistoryBTN = new Button();
            leaveHistoryBTN = new Button();
            leaveApprovalBTN = new Button();
            PICHistoryBTN = new Button();
            PICApprovalBTN = new Button();
            globalSettingsBTN = new Button();
            employeesBTN = new Button();
            LogoutBtn = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(256, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 0;
            Header.Text = "Wage Wizard";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(312, 93);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(214, 46);
            Subheader.TabIndex = 1;
            Subheader.Text = "Admin Menu";
            // 
            // WelcomeMsg
            // 
            WelcomeMsg.AutoSize = true;
            WelcomeMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeMsg.Location = new Point(286, 155);
            WelcomeMsg.Name = "WelcomeMsg";
            WelcomeMsg.Size = new Size(175, 35);
            WelcomeMsg.TabIndex = 2;
            WelcomeMsg.Text = "Welcome User";
            // 
            // payApprovalBTN
            // 
            payApprovalBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payApprovalBTN.Location = new Point(106, 247);
            payApprovalBTN.Margin = new Padding(3, 4, 3, 4);
            payApprovalBTN.Name = "payApprovalBTN";
            payApprovalBTN.Size = new Size(264, 71);
            payApprovalBTN.TabIndex = 3;
            payApprovalBTN.Text = "Pay Approval";
            payApprovalBTN.UseVisualStyleBackColor = true;
            payApprovalBTN.Click += payApprovalBTN_Click;
            // 
            // payHistoryBTN
            // 
            payHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payHistoryBTN.Location = new Point(475, 247);
            payHistoryBTN.Margin = new Padding(3, 4, 3, 4);
            payHistoryBTN.Name = "payHistoryBTN";
            payHistoryBTN.Size = new Size(264, 71);
            payHistoryBTN.TabIndex = 4;
            payHistoryBTN.Text = "Pay History";
            payHistoryBTN.UseVisualStyleBackColor = true;
            payHistoryBTN.Click += payHistoryBTN_Click;
            // 
            // leaveHistoryBTN
            // 
            leaveHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveHistoryBTN.Location = new Point(475, 351);
            leaveHistoryBTN.Margin = new Padding(3, 4, 3, 4);
            leaveHistoryBTN.Name = "leaveHistoryBTN";
            leaveHistoryBTN.Size = new Size(264, 71);
            leaveHistoryBTN.TabIndex = 6;
            leaveHistoryBTN.Text = "Leave History";
            leaveHistoryBTN.UseVisualStyleBackColor = true;
            leaveHistoryBTN.Click += leaveHistoryBTN_Click;
            // 
            // leaveApprovalBTN
            // 
            leaveApprovalBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveApprovalBTN.Location = new Point(106, 351);
            leaveApprovalBTN.Margin = new Padding(3, 4, 3, 4);
            leaveApprovalBTN.Name = "leaveApprovalBTN";
            leaveApprovalBTN.Size = new Size(264, 71);
            leaveApprovalBTN.TabIndex = 5;
            leaveApprovalBTN.Text = "Leave Approval";
            leaveApprovalBTN.UseVisualStyleBackColor = true;
            leaveApprovalBTN.Click += leaveApprovalBTN_Click;
            // 
            // PICHistoryBTN
            // 
            PICHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICHistoryBTN.Location = new Point(475, 452);
            PICHistoryBTN.Margin = new Padding(3, 4, 3, 4);
            PICHistoryBTN.Name = "PICHistoryBTN";
            PICHistoryBTN.Size = new Size(264, 71);
            PICHistoryBTN.TabIndex = 8;
            PICHistoryBTN.Text = "PIC History";
            PICHistoryBTN.UseVisualStyleBackColor = true;
            PICHistoryBTN.Click += PICHistoryBTN_Click;
            // 
            // PICApprovalBTN
            // 
            PICApprovalBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICApprovalBTN.Location = new Point(106, 452);
            PICApprovalBTN.Margin = new Padding(3, 4, 3, 4);
            PICApprovalBTN.Name = "PICApprovalBTN";
            PICApprovalBTN.Size = new Size(264, 71);
            PICApprovalBTN.TabIndex = 7;
            PICApprovalBTN.Text = "PIC Approval";
            PICApprovalBTN.UseVisualStyleBackColor = true;
            PICApprovalBTN.Click += PICApprovalBTN_Click;
            // 
            // globalSettingsBTN
            // 
            globalSettingsBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            globalSettingsBTN.Location = new Point(475, 555);
            globalSettingsBTN.Margin = new Padding(3, 4, 3, 4);
            globalSettingsBTN.Name = "globalSettingsBTN";
            globalSettingsBTN.Size = new Size(264, 71);
            globalSettingsBTN.TabIndex = 10;
            globalSettingsBTN.Text = "Global Settings";
            globalSettingsBTN.UseVisualStyleBackColor = true;
            globalSettingsBTN.Click += globalSettingsBTN_Click;
            // 
            // employeesBTN
            // 
            employeesBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            employeesBTN.Location = new Point(106, 555);
            employeesBTN.Margin = new Padding(3, 4, 3, 4);
            employeesBTN.Name = "employeesBTN";
            employeesBTN.Size = new Size(264, 71);
            employeesBTN.TabIndex = 9;
            employeesBTN.Text = "View/Edit Employees";
            employeesBTN.UseVisualStyleBackColor = true;
            employeesBTN.Click += employeesBTN_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(775, 624);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(94, 71);
            LogoutBtn.TabIndex = 11;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 707);
            Controls.Add(LogoutBtn);
            Controls.Add(globalSettingsBTN);
            Controls.Add(employeesBTN);
            Controls.Add(PICHistoryBTN);
            Controls.Add(PICApprovalBTN);
            Controls.Add(leaveHistoryBTN);
            Controls.Add(leaveApprovalBTN);
            Controls.Add(payHistoryBTN);
            Controls.Add(payApprovalBTN);
            Controls.Add(WelcomeMsg);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminMenu";
            Text = "Admin Menu";
            Load += AdminMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label Subheader;
        private Label WelcomeMsg;
        private Button payApprovalBTN;
        private Button payHistoryBTN;
        private Button leaveHistoryBTN;
        private Button leaveApprovalBTN;
        private Button PICHistoryBTN;
        private Button PICApprovalBTN;
        private Button globalSettingsBTN;
        private Button employeesBTN;
        private Button LogoutBtn;
    }
}