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
            Subheader = new Label();
            Header = new Label();
            ((System.ComponentModel.ISupportInitialize)PICHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // PICHistoryDGV
            // 
            PICHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PICHistoryDGV.Location = new Point(12, 166);
            PICHistoryDGV.Margin = new Padding(3, 4, 3, 4);
            PICHistoryDGV.Name = "PICHistoryDGV";
            PICHistoryDGV.RowHeadersWidth = 51;
            PICHistoryDGV.RowTemplate.Height = 25;
            PICHistoryDGV.Size = new Size(1021, 381);
            PICHistoryDGV.TabIndex = 4;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(935, 573);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(98, 81);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(170, 99);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(779, 46);
            Subheader.TabIndex = 16;
            Subheader.Text = "View Personal Information Change Request History";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(375, 18);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 15;
            Header.Text = "Wage Wizard";
            // 
            // EmployeePICHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 667);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Controls.Add(exitBtn);
            Controls.Add(PICHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "EmployeePICHistory";
            Text = "Employee Personal Information Change Request History";
            ((System.ComponentModel.ISupportInitialize)PICHistoryDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PICHistoryDGV;
        private Button exitBtn;
        private Label Subheader;
        private Label Header;
    }
}