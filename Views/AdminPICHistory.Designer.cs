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
            Subheader = new Label();
            Header = new Label();
            ((System.ComponentModel.ISupportInitialize)PICHistoryDGV).BeginInit();
            SuspendLayout();
            // 
            // PICHistoryDGV
            // 
            PICHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PICHistoryDGV.Location = new Point(12, 159);
            PICHistoryDGV.Margin = new Padding(3, 4, 3, 4);
            PICHistoryDGV.Name = "PICHistoryDGV";
            PICHistoryDGV.RowHeadersWidth = 51;
            PICHistoryDGV.RowTemplate.Height = 25;
            PICHistoryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PICHistoryDGV.Size = new Size(995, 381);
            PICHistoryDGV.TabIndex = 9;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(909, 573);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(98, 81);
            exitBtn.TabIndex = 12;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(236, 90);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(569, 46);
            Subheader.TabIndex = 16;
            Subheader.Text = "Personal Information Change History";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(349, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 15;
            Header.Text = "Wage Wizard";
            Header.Click += Header_Click;
            // 
            // AdminPICHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 667);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Controls.Add(exitBtn);
            Controls.Add(PICHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminPICHistory";
            Text = "Admin PIC History";
            TopMost = true;
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