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
            components = new System.ComponentModel.Container();
            exitBtn = new Button();
            denyBtn = new Button();
            approveBtn = new Button();
            leaveRequestsDGV = new DataGridView();
            leaveRequestBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)leaveRequestsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leaveRequestBindingSource).BeginInit();
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
            exitBtn.Click += exitBtn_Click;
            // 
            // denyBtn
            // 
            denyBtn.Location = new Point(150, 421);
            denyBtn.Name = "denyBtn";
            denyBtn.Size = new Size(86, 61);
            denyBtn.TabIndex = 9;
            denyBtn.Text = "Reject";
            denyBtn.UseVisualStyleBackColor = true;
            denyBtn.Click += denyBtn_Click;
            // 
            // approveBtn
            // 
            approveBtn.Location = new Point(30, 421);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(86, 61);
            approveBtn.TabIndex = 8;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = true;
            approveBtn.Click += approveBtn_Click;
            // 
            // leaveRequestsDGV
            // 
            leaveRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveRequestsDGV.Location = new Point(12, 12);
            leaveRequestsDGV.Name = "leaveRequestsDGV";
            leaveRequestsDGV.RowTemplate.Height = 25;
            leaveRequestsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            leaveRequestsDGV.Size = new Size(871, 378);
            leaveRequestsDGV.TabIndex = 7;
            // 
            // leaveRequestBindingSource
            // 
            leaveRequestBindingSource.DataSource = typeof(Models.LeaveRequest);
            // 
            // AdminLeaveApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 500);
            Controls.Add(exitBtn);
            Controls.Add(denyBtn);
            Controls.Add(approveBtn);
            Controls.Add(leaveRequestsDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminLeaveApproval";
            Text = "AdminLeaveApproval";
            ((System.ComponentModel.ISupportInitialize)leaveRequestsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)leaveRequestBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitBtn;
        private Button denyBtn;
        private Button approveBtn;
        private DataGridView leaveRequestsDGV;
        private BindingSource leaveRequestBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn leaveDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn approvalStatusDataGridViewTextBoxColumn;
    }
}