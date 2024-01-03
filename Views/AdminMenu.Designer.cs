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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
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
            Header.Location = new Point(257, 7);
            Header.Name = "Header";
            Header.Size = new Size(257, 54);
            Header.TabIndex = 0;
            Header.Text = "Wage Wizard";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(306, 70);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(170, 37);
            Subheader.TabIndex = 1;
            Subheader.Text = "Admin Menu";
            // 
            // WelcomeMsg
            // 
            WelcomeMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeMsg.Location = new Point(0, 116);
            WelcomeMsg.Name = "WelcomeMsg";
            WelcomeMsg.Size = new Size(771, 45);
            WelcomeMsg.TabIndex = 2;
            WelcomeMsg.Text = "Welcome User";
            WelcomeMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // payApprovalBTN
            // 
            payApprovalBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payApprovalBTN.Location = new Point(108, 185);
            payApprovalBTN.Name = "payApprovalBTN";
            payApprovalBTN.Size = new Size(231, 53);
            payApprovalBTN.TabIndex = 3;
            payApprovalBTN.Text = "Pay Approval";
            payApprovalBTN.UseVisualStyleBackColor = true;
            payApprovalBTN.Click += payApprovalBTN_Click;
            // 
            // payHistoryBTN
            // 
            payHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payHistoryBTN.Location = new Point(431, 185);
            payHistoryBTN.Name = "payHistoryBTN";
            payHistoryBTN.Size = new Size(231, 53);
            payHistoryBTN.TabIndex = 4;
            payHistoryBTN.Text = "Pay History";
            payHistoryBTN.UseVisualStyleBackColor = true;
            payHistoryBTN.Click += payHistoryBTN_Click;
            // 
            // leaveHistoryBTN
            // 
            leaveHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveHistoryBTN.Location = new Point(431, 262);
            leaveHistoryBTN.Name = "leaveHistoryBTN";
            leaveHistoryBTN.Size = new Size(231, 53);
            leaveHistoryBTN.TabIndex = 6;
            leaveHistoryBTN.Text = "Leave History";
            leaveHistoryBTN.UseVisualStyleBackColor = true;
            leaveHistoryBTN.Click += leaveHistoryBTN_Click;
            // 
            // leaveApprovalBTN
            // 
            leaveApprovalBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveApprovalBTN.Location = new Point(108, 262);
            leaveApprovalBTN.Name = "leaveApprovalBTN";
            leaveApprovalBTN.Size = new Size(231, 53);
            leaveApprovalBTN.TabIndex = 5;
            leaveApprovalBTN.Text = "Leave Approval";
            leaveApprovalBTN.UseVisualStyleBackColor = true;
            leaveApprovalBTN.Click += leaveApprovalBTN_Click;
            // 
            // PICHistoryBTN
            // 
            PICHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICHistoryBTN.Location = new Point(431, 339);
            PICHistoryBTN.Name = "PICHistoryBTN";
            PICHistoryBTN.Size = new Size(231, 53);
            PICHistoryBTN.TabIndex = 8;
            PICHistoryBTN.Text = "PIC History";
            PICHistoryBTN.UseVisualStyleBackColor = true;
            PICHistoryBTN.Click += PICHistoryBTN_Click;
            // 
            // PICApprovalBTN
            // 
            PICApprovalBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICApprovalBTN.Location = new Point(108, 339);
            PICApprovalBTN.Name = "PICApprovalBTN";
            PICApprovalBTN.Size = new Size(231, 53);
            PICApprovalBTN.TabIndex = 7;
            PICApprovalBTN.Text = "PIC Approval";
            PICApprovalBTN.UseVisualStyleBackColor = true;
            PICApprovalBTN.Click += PICApprovalBTN_Click;
            // 
            // globalSettingsBTN
            // 
            globalSettingsBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            globalSettingsBTN.Location = new Point(431, 416);
            globalSettingsBTN.Name = "globalSettingsBTN";
            globalSettingsBTN.Size = new Size(231, 53);
            globalSettingsBTN.TabIndex = 10;
            globalSettingsBTN.Text = "Global Settings";
            globalSettingsBTN.UseVisualStyleBackColor = true;
            globalSettingsBTN.Click += globalSettingsBTN_Click;
            // 
            // employeesBTN
            // 
            employeesBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            employeesBTN.Location = new Point(108, 416);
            employeesBTN.Name = "employeesBTN";
            employeesBTN.Size = new Size(231, 53);
            employeesBTN.TabIndex = 9;
            employeesBTN.Text = "View/Edit Employee";
            employeesBTN.UseVisualStyleBackColor = true;
            employeesBTN.Click += employeesBTN_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(678, 468);
            LogoutBtn.Margin = new Padding(3, 2, 3, 2);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(82, 53);
            LogoutBtn.TabIndex = 11;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 530);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminMenu";
            Text = "Admin Menu";
            FormClosing += formClosing;
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