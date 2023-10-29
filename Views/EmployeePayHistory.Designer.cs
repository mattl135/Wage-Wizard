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
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Header.Location = new Point(282, 9);
            Header.Name = "Header";
            Header.Size = new Size(321, 67);
            Header.TabIndex = 13;
            Header.Text = "Wage Wizard";
            // 
            // Subheader
            // 
            Subheader.AutoSize = true;
            Subheader.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subheader.Location = new Point(318, 87);
            Subheader.Name = "Subheader";
            Subheader.Size = new Size(267, 46);
            Subheader.TabIndex = 14;
            Subheader.Text = "View Pay History";
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(757, 609);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(94, 71);
            ExitBtn.TabIndex = 39;
            ExitBtn.Text = "Exit";
            ExitBtn.UseMnemonic = false;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // EmployeePayHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 707);
            Controls.Add(ExitBtn);
            Controls.Add(Subheader);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeePayHistory";
            Text = "View Pay History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label Subheader;
        private Button ExitBtn;
    }
}