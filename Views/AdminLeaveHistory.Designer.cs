namespace Wage_Wizard.Views
{
    partial class AdminLeaveHistory
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
            components = new System.ComponentModel.Container();
            exitBtn = new Button();
            leaveHistoryDGV = new DataGridView();
            leaveRequestBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)leaveHistoryDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leaveRequestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(756, 421);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(86, 61);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // leaveHistoryDGV
            // 
            leaveHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveHistoryDGV.Location = new Point(12, 18);
            leaveHistoryDGV.Name = "leaveHistoryDGV";
            leaveHistoryDGV.RowTemplate.Height = 25;
            leaveHistoryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            leaveHistoryDGV.Size = new Size(871, 378);
            leaveHistoryDGV.TabIndex = 11;
            // 
            // leaveRequestBindingSource
            // 
            leaveRequestBindingSource.DataSource = typeof(Models.LeaveRequest);
            // 
            // AdminLeaveHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 500);
            Controls.Add(exitBtn);
            Controls.Add(leaveHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminLeaveHistory";
            Text = "AdminLeaveHistory";
            ((System.ComponentModel.ISupportInitialize)leaveHistoryDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)leaveRequestBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitBtn;
        private DataGridView leaveHistoryDGV;
        private BindingSource leaveRequestBindingSource;
    }
}