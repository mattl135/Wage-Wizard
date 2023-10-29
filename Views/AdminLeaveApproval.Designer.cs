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
            Subheader = new Label();
            Header = new Label();
            ((System.ComponentModel.ISupportInitialize)leaveRequestsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leaveRequestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(911, 561);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(98, 81);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // denyBtn
            // 
            denyBtn.Location = new Point(171, 561);
            denyBtn.Margin = new Padding(3, 4, 3, 4);
            denyBtn.Name = "denyBtn";
            denyBtn.Size = new Size(98, 81);
            denyBtn.TabIndex = 9;
            denyBtn.Text = "Reject";
            denyBtn.UseVisualStyleBackColor = true;
            denyBtn.Click += denyBtn_Click;
            // 
            // approveBtn
            // 
            approveBtn.Location = new Point(34, 561);
            approveBtn.Margin = new Padding(3, 4, 3, 4);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(98, 81);
            approveBtn.TabIndex = 8;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = true;
            approveBtn.Click += approveBtn_Click;
            // 
            // leaveRequestsDGV
            // 
            leaveRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveRequestsDGV.Location = new Point(14, 146);
            leaveRequestsDGV.Margin = new Padding(3, 4, 3, 4);
            leaveRequestsDGV.MultiSelect = false;
            leaveRequestsDGV.Name = "leaveRequestsDGV";
            leaveRequestsDGV.RowHeadersWidth = 51;
            leaveRequestsDGV.RowTemplate.Height = 25;
            leaveRequestsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            leaveRequestsDGV.Size = new Size(995, 391);
            leaveRequestsDGV.TabIndex = 7;
            // 
            // leaveRequestBindingSource
            // 
            leaveRequestBindingSource.DataSource = typeof(Models.LeaveRequest);
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(378, 76);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(249, 46);
            Subheader.TabIndex = 17;
            Subheader.Text = "Leave Approval";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(339, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 16;
            Header.Text = "Wage Wizard";
            // 
            // AdminLeaveApproval
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 667);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Controls.Add(exitBtn);
            Controls.Add(denyBtn);
            Controls.Add(approveBtn);
            Controls.Add(leaveRequestsDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AdminLeaveApproval";
            Text = "Leave Approval";
            ((System.ComponentModel.ISupportInitialize)leaveRequestsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)leaveRequestBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label Subheader;
        private Label Header;
    }
}