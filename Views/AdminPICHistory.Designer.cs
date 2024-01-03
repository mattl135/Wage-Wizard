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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPICHistory));
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
            PICHistoryDGV.Location = new Point(10, 119);
            PICHistoryDGV.Name = "PICHistoryDGV";
            PICHistoryDGV.RowHeadersWidth = 51;
            PICHistoryDGV.RowTemplate.Height = 25;
            PICHistoryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PICHistoryDGV.Size = new Size(871, 286);
            PICHistoryDGV.TabIndex = 9;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(795, 430);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 12;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(206, 68);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(452, 37);
            Subheader.TabIndex = 16;
            Subheader.Text = "Personal Information Change History";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(305, 7);
            Header.Name = "Header";
            Header.Size = new Size(257, 54);
            Header.TabIndex = 15;
            Header.Text = "Wage Wizard";
            Header.Click += Header_Click;
            // 
            // AdminPICHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 500);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Controls.Add(exitBtn);
            Controls.Add(PICHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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