namespace Wage_Wizard.Views
{
    partial class AdminLeaveHistory
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
            leaveHistoryDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)leaveHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(756, 421);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // leaveHistoryDGV
            // 
            leaveHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveHistoryDGV.Location = new Point(11, 18);
            leaveHistoryDGV.Name = "leaveHistoryDGV";
            leaveHistoryDGV.RowTemplate.Height = 25;
            leaveHistoryDGV.Size = new Size(852, 378);
            leaveHistoryDGV.TabIndex = 11;
            // 
            // AdminLeaveHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 500);
            Controls.Add(exitBtn);
            Controls.Add(leaveHistoryDGV);
            Name = "AdminLeaveHistory";
            Text = "AdminLeaveHistory";
            ((System.ComponentModel.ISupportInitialize)leaveHistoryDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitBtn;
        private DataGridView leaveHistoryDGV;
    }
}