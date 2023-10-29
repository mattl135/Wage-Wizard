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
            ((System.ComponentModel.ISupportInitialize)payRequestsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(800, 421);
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
            // payRequestsDGV
            // 
            payRequestsDGV.AllowUserToDeleteRows = false;
            payRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payRequestsDGV.Location = new Point(20, 18);
            payRequestsDGV.Name = "payRequestsDGV";
            payRequestsDGV.RowTemplate.Height = 25;
            payRequestsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payRequestsDGV.Size = new Size(866, 378);
            payRequestsDGV.TabIndex = 7;
            payRequestsDGV.CellClick += payRequestsDGV_CellClick;
            // 
            // paymentRequestBindingSource
            // 
            paymentRequestBindingSource.DataSource = typeof(Models.PaymentRequest);
            // 
            // AdminPayApproval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 500);
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
            ResumeLayout(false);
        }

        #endregion
        private Button exitBtn;
        private Button denyBtn;
        private Button approveBtn;
        private DataGridView payRequestsDGV;
        private BindingSource paymentRequestBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn approvalStatusDataGridViewTextBoxColumn;
        private BindingSource paymentRequestBindingSource1;
        private DataGridViewTextBoxColumn fName;
    }
}