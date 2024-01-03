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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLeaveHistory));
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
            Header.Location = new Point(319, 14);
            Header.Name = "Header";
            Header.Size = new Size(257, 54);
            Header.TabIndex = 14;
            Header.Text = "Wage Wizard";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(327, 72);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(241, 37);
            Subheader.TabIndex = 15;
            Subheader.Text = "View Leave History";
            // 
            // leaveHistoryDGV
            // 
            leaveHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveHistoryDGV.Location = new Point(10, 123);
            leaveHistoryDGV.Name = "leaveHistoryDGV";
            leaveHistoryDGV.RowHeadersWidth = 51;
            leaveHistoryDGV.RowTemplate.Height = 25;
            leaveHistoryDGV.Size = new Size(873, 310);
            leaveHistoryDGV.TabIndex = 41;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(802, 438);
            ExitBtn.Margin = new Padding(3, 2, 3, 2);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(82, 53);
            ExitBtn.TabIndex = 42;
            ExitBtn.Text = "Exit";
            ExitBtn.UseMnemonic = false;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // EmployeeLeaveHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 500);
            Controls.Add(ExitBtn);
            Controls.Add(leaveHistoryDGV);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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