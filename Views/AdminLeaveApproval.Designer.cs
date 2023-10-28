namespace Wage_Wizard.Views
{
    partial class AdminLeaveApproval
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
            exitBtn = new Button();
            denyBtn = new Button();
            approveBtn = new Button();
            leaveRequestsDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)leaveRequestsDGV).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(756, 421);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // denyBtn
            // 
            denyBtn.Location = new Point(150, 421);
            denyBtn.Name = "denyBtn";
            denyBtn.Size = new Size(86, 61);
            denyBtn.TabIndex = 9;
            denyBtn.Text = "Deny";
            denyBtn.UseVisualStyleBackColor = true;
            // 
            // approveBtn
            // 
            approveBtn.Location = new Point(30, 421);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(86, 61);
            approveBtn.TabIndex = 8;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = true;
            // 
            // leaveRequestsDGV
            // 
            leaveRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveRequestsDGV.Location = new Point(11, 18);
            leaveRequestsDGV.Name = "leaveRequestsDGV";
            leaveRequestsDGV.RowTemplate.Height = 25;
            leaveRequestsDGV.Size = new Size(852, 378);
            leaveRequestsDGV.TabIndex = 7;
            // 
            // AdminLeaveApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 500);
            Controls.Add(exitBtn);
            Controls.Add(denyBtn);
            Controls.Add(approveBtn);
            Controls.Add(leaveRequestsDGV);
            Name = "AdminLeaveApproval";
            Text = "AdminLeaveApproval";
            ((System.ComponentModel.ISupportInitialize)leaveRequestsDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitBtn;
        private Button denyBtn;
        private Button approveBtn;
        private DataGridView leaveRequestsDGV;
    }
}