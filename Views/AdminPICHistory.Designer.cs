namespace Wage_Wizard.Views
{
    partial class AdminPICHistory
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
            PICHistoryDGV = new DataGridView();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PICHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // PICHistoryDGV
            // 
            PICHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PICHistoryDGV.Location = new Point(12, 12);
            PICHistoryDGV.Name = "PICHistoryDGV";
            PICHistoryDGV.RowTemplate.Height = 25;
            PICHistoryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PICHistoryDGV.Size = new Size(871, 378);
            PICHistoryDGV.TabIndex = 9;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(779, 413);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 12;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // AdminPICHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 500);
            Controls.Add(exitBtn);
            Controls.Add(PICHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminPICHistory";
            Text = "Admin PIC History";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)PICHistoryDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PICHistoryDGV;
        private Button exitBtn;
    }
}