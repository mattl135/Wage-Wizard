namespace Wage_Wizard.Views
{
    partial class EmployeePayHistory
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
            Header = new Label();
            Subheader = new Label();
            ExitBtn = new Button();
            payHistoryDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)payHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(346, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 13;
            Header.Text = "Wage Wizard";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(376, 85);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(267, 46);
            Subheader.TabIndex = 14;
            Subheader.Text = "View Pay History";
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(916, 584);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(94, 71);
            ExitBtn.TabIndex = 39;
            ExitBtn.Text = "Exit";
            ExitBtn.UseMnemonic = false;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // payHistoryDGV
            // 
            payHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            payHistoryDGV.Location = new Point(12, 146);
            payHistoryDGV.Margin = new Padding(3, 4, 3, 4);
            payHistoryDGV.Name = "payHistoryDGV";
            payHistoryDGV.RowHeadersWidth = 51;
            payHistoryDGV.RowTemplate.Height = 25;
            payHistoryDGV.Size = new Size(998, 416);
            payHistoryDGV.TabIndex = 40;
            // 
            // EmployeePayHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 667);
            Controls.Add(payHistoryDGV);
            Controls.Add(ExitBtn);
            Controls.Add(Subheader);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeePayHistory";
            Text = "View Pay History";
            ((System.ComponentModel.ISupportInitialize)payHistoryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label Subheader;
        private Button ExitBtn;
        private DataGridView payHistoryDGV;
    }
}