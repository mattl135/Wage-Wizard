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
            exitBtn.Location = new Point(911, 573);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(98, 81);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // leaveHistoryDGV
            // 
            leaveHistoryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaveHistoryDGV.Location = new Point(14, 24);
            leaveHistoryDGV.Margin = new Padding(3, 4, 3, 4);
            leaveHistoryDGV.MultiSelect = false;
            leaveHistoryDGV.Name = "leaveHistoryDGV";
            leaveHistoryDGV.RowHeadersWidth = 51;
            leaveHistoryDGV.RowTemplate.Height = 25;
            leaveHistoryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            leaveHistoryDGV.Size = new Size(995, 529);
            leaveHistoryDGV.TabIndex = 11;
            // 
            // leaveRequestBindingSource
            // 
            leaveRequestBindingSource.DataSource = typeof(Models.LeaveRequest);
            // 
            // AdminLeaveHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 667);
            Controls.Add(exitBtn);
            Controls.Add(leaveHistoryDGV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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