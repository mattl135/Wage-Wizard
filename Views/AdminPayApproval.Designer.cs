namespace Wage_Wizard.Views
{
    partial class AdminPayApproval
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
            payRequestsDGV = new DataGridView();
            hoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            approvalStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentRequestBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)payRequestsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).BeginInit();
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
            approveBtn.Click += approveBtn_Click;
            // 
            // payRequestsDGV
            // 
            payRequestsDGV.AllowUserToDeleteRows = false;
            payRequestsDGV.AutoGenerateColumns = false;
            payRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payRequestsDGV.Columns.AddRange(new DataGridViewColumn[] { hoursDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, employeeIDDataGridViewTextBoxColumn, approvalStatusDataGridViewTextBoxColumn });
            payRequestsDGV.DataSource = paymentRequestBindingSource;
            payRequestsDGV.Location = new Point(11, 18);
            payRequestsDGV.Name = "payRequestsDGV";
            payRequestsDGV.RowTemplate.Height = 25;
            payRequestsDGV.Size = new Size(852, 378);
            payRequestsDGV.TabIndex = 7;
            payRequestsDGV.CellClick += payRequestsDGV_CellClick;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            hoursDataGridViewTextBoxColumn.HeaderText = "hours";
            hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvalStatusDataGridViewTextBoxColumn
            // 
            approvalStatusDataGridViewTextBoxColumn.DataPropertyName = "approvalStatus";
            approvalStatusDataGridViewTextBoxColumn.HeaderText = "approvalStatus";
            approvalStatusDataGridViewTextBoxColumn.Name = "approvalStatusDataGridViewTextBoxColumn";
            approvalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentRequestBindingSource
            // 
            paymentRequestBindingSource.DataSource = typeof(Models.PaymentRequest);
            // 
            // AdminPayApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 500);
            Controls.Add(exitBtn);
            Controls.Add(denyBtn);
            Controls.Add(approveBtn);
            Controls.Add(payRequestsDGV);
            Name = "AdminPayApproval";
            Text = "AdminPayApproval";
            ((System.ComponentModel.ISupportInitialize)payRequestsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button exitBtn;
        private Button denyBtn;
        private Button approveBtn;
        private DataGridView payRequestsDGV;
        private BindingSource paymentRequestBindingSource;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn approvalStatusDataGridViewTextBoxColumn;
    }
}