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
            paymentRequestBindingSource = new BindingSource(components);
            Subtitle = new Label();
            paymentRequestBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            approvalStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)payRequestsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(382, 434);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // denyBtn
            // 
            denyBtn.Location = new Point(151, 434);
            denyBtn.Name = "denyBtn";
            denyBtn.Size = new Size(86, 61);
            denyBtn.TabIndex = 9;
            denyBtn.Text = "Reject";
            denyBtn.UseVisualStyleBackColor = true;
            denyBtn.Click += denyBtn_Click;
            // 
            // approveBtn
            // 
            approveBtn.Location = new Point(31, 434);
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
            payRequestsDGV.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, employeeIDDataGridViewTextBoxColumn, hoursDataGridViewTextBoxColumn, approvalStatusDataGridViewTextBoxColumn });
            payRequestsDGV.DataSource = paymentRequestBindingSource1;
            payRequestsDGV.Location = new Point(21, 50);
            payRequestsDGV.Name = "payRequestsDGV";
            payRequestsDGV.RowTemplate.Height = 25;
            payRequestsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payRequestsDGV.Size = new Size(447, 378);
            payRequestsDGV.TabIndex = 7;
            payRequestsDGV.CellClick += payRequestsDGV_CellClick;
            // 
            // paymentRequestBindingSource
            // 
            paymentRequestBindingSource.DataSource = typeof(Models.PaymentRequest);
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subtitle.Location = new Point(81, 9);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new Size(335, 37);
            Subtitle.TabIndex = 12;
            Subtitle.Text = "Pending Payment Requests";
            // 
            // paymentRequestBindingSource1
            // 
            paymentRequestBindingSource1.DataSource = typeof(Models.PaymentRequest);
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
            // hoursDataGridViewTextBoxColumn
            // 
            hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            hoursDataGridViewTextBoxColumn.HeaderText = "hours";
            hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvalStatusDataGridViewTextBoxColumn
            // 
            approvalStatusDataGridViewTextBoxColumn.DataPropertyName = "approvalStatus";
            approvalStatusDataGridViewTextBoxColumn.HeaderText = "approvalStatus";
            approvalStatusDataGridViewTextBoxColumn.Name = "approvalStatusDataGridViewTextBoxColumn";
            // 
            // AdminPayApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 500);
            Controls.Add(Subtitle);
            Controls.Add(exitBtn);
            Controls.Add(denyBtn);
            Controls.Add(approveBtn);
            Controls.Add(payRequestsDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminPayApproval";
            Text = "AdminPayApproval";
            ((System.ComponentModel.ISupportInitialize)payRequestsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitBtn;
        private Button denyBtn;
        private Button approveBtn;
        private DataGridView payRequestsDGV;
        private BindingSource paymentRequestBindingSource;
        private BindingSource paymentRequestBindingSource1;
        private DataGridViewTextBoxColumn fName;
        private Label Subtitle;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn approvalStatusDataGridViewTextBoxColumn;
    }
}