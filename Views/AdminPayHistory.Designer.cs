namespace Wage_Wizard.Views
{
    partial class AdminPayHistory
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
            payHistoryDGV = new DataGridView();
            paymentRequestBindingSource = new BindingSource(components);
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)payHistoryDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // payHistoryDGV
            // 
            payHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payHistoryDGV.Location = new Point(24, 12);
            payHistoryDGV.Name = "payHistoryDGV";
            payHistoryDGV.RowTemplate.Height = 25;
            payHistoryDGV.Size = new Size(866, 378);
            payHistoryDGV.TabIndex = 3;
            // 
            // paymentRequestBindingSource
            // 
            paymentRequestBindingSource.DataSource = typeof(Models.PaymentRequest);
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(804, 408);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // AdminPayHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 500);
            Controls.Add(exitBtn);
            Controls.Add(payHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminPayHistory";
            Text = "Admin Pay History";
            ((System.ComponentModel.ISupportInitialize)payHistoryDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentRequestBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView payHistoryDGV;
        private Button exitBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn approvalStatusDataGridViewTextBoxColumn;
        private BindingSource paymentRequestBindingSource;
    }
}