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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // PICHistoryBTN
            // 
            PICHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICHistoryBTN.Location = new Point(423, 343);
            PICHistoryBTN.Name = "PICHistoryBTN";
            PICHistoryBTN.Size = new Size(231, 53);
            PICHistoryBTN.TabIndex = 19;
            PICHistoryBTN.Text = "View Personal Change Requests";
            PICHistoryBTN.UseVisualStyleBackColor = true;
            // 
            // PICRequestBTN
            // 
            PICRequestBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PICRequestBTN.Location = new Point(100, 343);
            PICRequestBTN.Name = "PICRequestBTN";
            PICRequestBTN.Size = new Size(231, 53);
            PICRequestBTN.TabIndex = 18;
            PICRequestBTN.Text = "Request Personal Information Change";
            PICRequestBTN.UseVisualStyleBackColor = true;
            // 
            // leaveHistoryBTN
            // 
            leaveHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveHistoryBTN.Location = new Point(423, 267);
            leaveHistoryBTN.Name = "leaveHistoryBTN";
            leaveHistoryBTN.Size = new Size(231, 53);
            leaveHistoryBTN.TabIndex = 17;
            leaveHistoryBTN.Text = "View Leave History";
            leaveHistoryBTN.UseVisualStyleBackColor = true;
            // 
            // leaveRequestBTN
            // 
            leaveRequestBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            leaveRequestBTN.Location = new Point(100, 267);
            leaveRequestBTN.Name = "leaveRequestBTN";
            leaveRequestBTN.Size = new Size(231, 53);
            leaveRequestBTN.TabIndex = 16;
            leaveRequestBTN.Text = "Request Leave";
            leaveRequestBTN.UseVisualStyleBackColor = true;
            // 
            // payHistoryBTN
            // 
            payHistoryBTN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payHistoryBTN.Location = new Point(423, 189);
            payHistoryBTN.Name = "payHistoryBTN";
            payHistoryBTN.Size = new Size(231, 53);
            payHistoryBTN.TabIndex = 15;
            payHistoryBTN.Text = "View Pay History";
            payHistoryBTN.UseVisualStyleBackColor = true;
            // 
            // payRequestBtn
            // 
            payRequestBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payRequestBtn.Location = new Point(100, 189);
            payRequestBtn.Name = "payRequestBtn";
            payRequestBtn.Size = new Size(231, 53);
            payRequestBtn.TabIndex = 14;
            payRequestBtn.Text = "RequestPayment";
            payRequestBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(279, 120);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 13;
            label3.Text = "Welcome User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 63);
            label2.Name = "label2";
            label2.Size = new Size(209, 37);
            label2.TabIndex = 12;
            label2.Text = "Employee Menu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 54);
            label1.TabIndex = 11;
            label1.Text = "Wage Wizard";
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 530);
            Controls.Add(PICHistoryBTN);
            Controls.Add(PICRequestBTN);
            Controls.Add(leaveHistoryBTN);
            Controls.Add(leaveRequestBTN);
            Controls.Add(payHistoryBTN);
            Controls.Add(payRequestBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeMenu";
            Text = "EmployeeMenu";
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
        private Label label3;
        private Label label2;
        private Label label1;
    }
}