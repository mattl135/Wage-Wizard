using Wage_Wizard.Models;

namespace Wage_Wizard.Views
{
    partial class EmployeeMenu
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
            PICHistoryBTN = new Button();
            PICRequestBTN = new Button();
            leaveHistoryBTN = new Button();
            leaveRequestBTN = new Button();
            payHistoryBTN = new Button();
            payRequestBtn = new Button();
            WelcomeMsg = new Label();
            Subheader = new Label();
            Header = new Label();
            LogoutBtn = new Button();
            SuspendLayout();
            // 
            // PICHistoryBTN
            // 
            PICHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICHistoryBTN.Location = new Point(483, 457);
            PICHistoryBTN.Margin = new Padding(3, 4, 3, 4);
            PICHistoryBTN.Name = "PICHistoryBTN";
            PICHistoryBTN.Size = new Size(264, 71);
            PICHistoryBTN.TabIndex = 19;
            PICHistoryBTN.Text = "View Personal Change Requests";
            PICHistoryBTN.UseVisualStyleBackColor = true;
            PICHistoryBTN.Click += PICHistoryBTN_Click;
            // 
            // PICRequestBTN
            // 
            PICRequestBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICRequestBTN.Location = new Point(114, 457);
            PICRequestBTN.Margin = new Padding(3, 4, 3, 4);
            PICRequestBTN.Name = "PICRequestBTN";
            PICRequestBTN.Size = new Size(264, 71);
            PICRequestBTN.TabIndex = 18;
            PICRequestBTN.Text = "Request Personal Information Change";
            PICRequestBTN.UseVisualStyleBackColor = true;
            PICRequestBTN.Click += PICRequestBTN_Click;
            // 
            // leaveHistoryBTN
            // 
            leaveHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveHistoryBTN.Location = new Point(483, 356);
            leaveHistoryBTN.Margin = new Padding(3, 4, 3, 4);
            leaveHistoryBTN.Name = "leaveHistoryBTN";
            leaveHistoryBTN.Size = new Size(264, 71);
            leaveHistoryBTN.TabIndex = 17;
            leaveHistoryBTN.Text = "View Leave History";
            leaveHistoryBTN.UseVisualStyleBackColor = true;
            leaveHistoryBTN.Click += leaveHistoryBTN_Click;
            // 
            // leaveRequestBTN
            // 
            leaveRequestBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveRequestBTN.Location = new Point(114, 356);
            leaveRequestBTN.Margin = new Padding(3, 4, 3, 4);
            leaveRequestBTN.Name = "leaveRequestBTN";
            leaveRequestBTN.Size = new Size(264, 71);
            leaveRequestBTN.TabIndex = 16;
            leaveRequestBTN.Text = "Request Leave";
            leaveRequestBTN.UseVisualStyleBackColor = true;
            leaveRequestBTN.Click += leaveRequestBTN_Click;
            // 
            // payHistoryBTN
            // 
            payHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payHistoryBTN.Location = new Point(483, 252);
            payHistoryBTN.Margin = new Padding(3, 4, 3, 4);
            payHistoryBTN.Name = "payHistoryBTN";
            payHistoryBTN.Size = new Size(264, 71);
            payHistoryBTN.TabIndex = 15;
            payHistoryBTN.Text = "View Pay History";
            payHistoryBTN.UseVisualStyleBackColor = true;
            payHistoryBTN.Click += payHistoryBTN_Click;
            // 
            // payRequestBtn
            // 
            payRequestBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payRequestBtn.Location = new Point(114, 252);
            payRequestBtn.Margin = new Padding(3, 4, 3, 4);
            payRequestBtn.Name = "payRequestBtn";
            payRequestBtn.Size = new Size(264, 71);
            payRequestBtn.TabIndex = 14;
            payRequestBtn.Text = "Request Payment";
            payRequestBtn.UseVisualStyleBackColor = true;
            payRequestBtn.Click += payRequestBtn_Click;
            // 
            // WelcomeMsg
            // 
            WelcomeMsg.AutoSize = true;
            WelcomeMsg.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeMsg.Location = new Point(287, 166);
            WelcomeMsg.Name = "WelcomeMsg";
            WelcomeMsg.Size = new Size(175, 35);
            WelcomeMsg.TabIndex = 13;
            WelcomeMsg.Text = "Welcome User";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(287, 91);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(262, 46);
            Subheader.TabIndex = 12;
            Subheader.Text = "Employee Menu";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(258, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 11;
            Header.Text = "Wage Wizard";
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(757, 609);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(94, 71);
            LogoutBtn.TabIndex = 20;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseMnemonic = false;
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 707);
            Controls.Add(LogoutBtn);
            Controls.Add(PICHistoryBTN);
            Controls.Add(PICRequestBTN);
            Controls.Add(leaveHistoryBTN);
            Controls.Add(leaveRequestBTN);
            Controls.Add(payHistoryBTN);
            Controls.Add(payRequestBtn);
            Controls.Add(WelcomeMsg);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeMenu";
            Text = "Employee Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PICHistoryBTN;
        private Button PICRequestBTN;
        private Button leaveHistoryBTN;
        private Button leaveRequestBTN;
        private Button payHistoryBTN;
        private Button payRequestBtn;
        private Label WelcomeMsg;
        private Label Subheader;
        private Label Header;
        private Button LogoutBtn;
    }
}