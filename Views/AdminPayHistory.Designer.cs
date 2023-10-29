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
            payHistoryDGV = new DataGridView();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)payHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // payHistoryDGV
            // 
            payHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payHistoryDGV.Location = new Point(10, 12);
            payHistoryDGV.Name = "payHistoryDGV";
            payHistoryDGV.RowTemplate.Height = 25;
            payHistoryDGV.Size = new Size(852, 378);
            payHistoryDGV.TabIndex = 3;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(755, 415);
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
            ClientSize = new Size(874, 500);
            Controls.Add(exitBtn);
            Controls.Add(payHistoryDGV);
            Name = "AdminPayHistory";
            Text = "AdminPayHistory";
            ((System.ComponentModel.ISupportInitialize)payHistoryDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView payHistoryDGV;
        private Button exitBtn;
    }
}