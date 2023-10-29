namespace Wage_Wizard.Views
{
    partial class EmployeePICHistory
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
            PICHistoryDGV.Location = new Point(24, 19);
            PICHistoryDGV.Name = "PICHistoryDGV";
            PICHistoryDGV.RowTemplate.Height = 25;
            PICHistoryDGV.Size = new Size(866, 378);
            PICHistoryDGV.TabIndex = 4;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(804, 415);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // EmployeePICHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 500);
            Controls.Add(exitBtn);
            Controls.Add(PICHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EmployeePICHistory";
            Text = "Employee Personal Information Change Request History";
            ((System.ComponentModel.ISupportInitialize)PICHistoryDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PICHistoryDGV;
        private Button exitBtn;
    }
}