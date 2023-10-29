namespace Wage_Wizard.Views
{
    partial class AdminPICRequest
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
            PICRequestsDGV = new DataGridView();
            approveBtn = new Button();
            rejectBtn = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PICRequestsDGV).BeginInit();
            SuspendLayout();
            // 
            // PICRequestsDGV
            // 
            PICRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PICRequestsDGV.Location = new Point(12, 12);
            PICRequestsDGV.Name = "PICRequestsDGV";
            PICRequestsDGV.RowTemplate.Height = 25;
            PICRequestsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PICRequestsDGV.Size = new Size(871, 378);
            PICRequestsDGV.TabIndex = 8;
            // 
            // approveBtn
            // 
            approveBtn.Location = new Point(35, 415);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(86, 61);
            approveBtn.TabIndex = 9;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = true;
            approveBtn.Click += approveBtn_Click;
            // 
            // rejectBtn
            // 
            rejectBtn.Location = new Point(182, 415);
            rejectBtn.Name = "rejectBtn";
            rejectBtn.Size = new Size(86, 61);
            rejectBtn.TabIndex = 10;
            rejectBtn.Text = "Reject";
            rejectBtn.UseVisualStyleBackColor = true;
            rejectBtn.Click += denyBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(784, 415);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 11;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // AdminPICRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 500);
            Controls.Add(exitBtn);
            Controls.Add(rejectBtn);
            Controls.Add(approveBtn);
            Controls.Add(PICRequestsDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminPICRequest";
            Text = "Personal Information Change Request";
            ((System.ComponentModel.ISupportInitialize)PICRequestsDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView PICRequestsDGV;
        private Button approveBtn;
        private Button rejectBtn;
        private Button exitBtn;
    }
}