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
            paymentRequestBindingSource1 = new BindingSource(components);
            paymentRequestBindingSource = new BindingSource(components);
            Subtitle = new Label();
            ((System.ComponentModel.ISupportInitialize)payRequestsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(912, 579);
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
            denyBtn.Location = new Point(156, 579);
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
            approveBtn.Location = new Point(24, 579);
            approveBtn.Margin = new Padding(3, 4, 3, 4);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(98, 81);
            approveBtn.TabIndex = 8;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = true;
            approveBtn.Click += approveBtn_Click;
            // 
            // payRequestsDGV
            // 
            payRequestsDGV.AllowUserToDeleteRows = false;
            payRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payRequestsDGV.Location = new Point(24, 67);
            payRequestsDGV.Margin = new Padding(3, 4, 3, 4);
            payRequestsDGV.MultiSelect = false;
            payRequestsDGV.Name = "payRequestsDGV";
            payRequestsDGV.RowHeadersWidth = 51;
            payRequestsDGV.RowTemplate.Height = 25;
            payRequestsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payRequestsDGV.Size = new Size(986, 489);
            payRequestsDGV.TabIndex = 7;
            payRequestsDGV.CellClick += payRequestsDGV_CellClick;
            // 
            // paymentRequestBindingSource1
            // 
            paymentRequestBindingSource1.DataSource = typeof(Models.PaymentRequest);
            // 
            // paymentRequestBindingSource
            // 
            paymentRequestBindingSource.DataSource = typeof(Models.PaymentRequest);
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subtitle.Location = new Point(292, 9);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new Size(423, 46);
            Subtitle.TabIndex = 12;
            Subtitle.Text = "Pending Payment Requests";
            // 
            // AdminPayApproval
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 667);
            Controls.Add(Subtitle);
            Controls.Add(exitBtn);
            Controls.Add(denyBtn);
            Controls.Add(approveBtn);
            Controls.Add(payRequestsDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AdminPayApproval";
            Text = "AdminPayApproval";
            ((System.ComponentModel.ISupportInitialize)payRequestsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).EndInit();
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