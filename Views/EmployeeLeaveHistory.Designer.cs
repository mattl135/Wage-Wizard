namespace Wage_Wizard.Views
{
    partial class EmployeeLeaveHistory
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
            leaveHistoryDGV = new DataGridView();
            ExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)leaveHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(282, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 14;
            Header.Text = "Wage Wizard";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(307, 85);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(301, 46);
            Subheader.TabIndex = 15;
            Subheader.Text = "View Leave History";
            // 
            // leaveHistoryDGV
            // 
            leaveHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveHistoryDGV.Location = new Point(12, 146);
            leaveHistoryDGV.Margin = new Padding(3, 4, 3, 4);
            leaveHistoryDGV.Name = "leaveHistoryDGV";
            leaveHistoryDGV.RowHeadersWidth = 51;
            leaveHistoryDGV.RowTemplate.Height = 25;
            leaveHistoryDGV.Size = new Size(857, 456);
            leaveHistoryDGV.TabIndex = 41;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(775, 624);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(94, 71);
            ExitBtn.TabIndex = 42;
            ExitBtn.Text = "Exit";
            ExitBtn.UseMnemonic = false;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // EmployeeLeaveHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 707);
            Controls.Add(ExitBtn);
            Controls.Add(leaveHistoryDGV);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Name = "EmployeeLeaveHistory";
            Text = "View Leave History";
            ((System.ComponentModel.ISupportInitialize)leaveHistoryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label Subheader;
        private DataGridView leaveHistoryDGV;
        private Button ExitBtn;
    }
}