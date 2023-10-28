namespace Wage_Wizard.Views
{
    partial class EditEmployee
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
            dataGridViewEmployees = new DataGridView();
            bsbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hourlyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxFileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentCurrencyCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            streetNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            streetNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suburbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            Subtitle = new Label();
            Title = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { bsbDataGridViewTextBoxColumn, accountNameDataGridViewTextBoxColumn, accountNumberDataGridViewTextBoxColumn, hourlyRateDataGridViewTextBoxColumn, taxFileNumberDataGridViewTextBoxColumn, paymentCurrencyCodeDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, fNameDataGridViewTextBoxColumn, lNameDataGridViewTextBoxColumn, emailAddressDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, mobileNumberDataGridViewTextBoxColumn, streetNumberDataGridViewTextBoxColumn, streetNameDataGridViewTextBoxColumn, suburbDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn });
            dataGridViewEmployees.DataSource = employeeBindingSource;
            dataGridViewEmployees.Location = new Point(12, 168);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.Size = new Size(857, 390);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // bsbDataGridViewTextBoxColumn
            // 
            bsbDataGridViewTextBoxColumn.DataPropertyName = "bsb";
            bsbDataGridViewTextBoxColumn.HeaderText = "bsb";
            bsbDataGridViewTextBoxColumn.MinimumWidth = 6;
            bsbDataGridViewTextBoxColumn.Name = "bsbDataGridViewTextBoxColumn";
            bsbDataGridViewTextBoxColumn.ReadOnly = true;
            bsbDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "accountName";
            accountNameDataGridViewTextBoxColumn.HeaderText = "accountName";
            accountNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            accountNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            accountNumberDataGridViewTextBoxColumn.DataPropertyName = "accountNumber";
            accountNumberDataGridViewTextBoxColumn.HeaderText = "accountNumber";
            accountNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            accountNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "hourlyRate";
            hourlyRateDataGridViewTextBoxColumn.HeaderText = "hourlyRate";
            hourlyRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            hourlyRateDataGridViewTextBoxColumn.ReadOnly = true;
            hourlyRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // taxFileNumberDataGridViewTextBoxColumn
            // 
            taxFileNumberDataGridViewTextBoxColumn.DataPropertyName = "taxFileNumber";
            taxFileNumberDataGridViewTextBoxColumn.HeaderText = "taxFileNumber";
            taxFileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            taxFileNumberDataGridViewTextBoxColumn.Name = "taxFileNumberDataGridViewTextBoxColumn";
            taxFileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            taxFileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentCurrencyCodeDataGridViewTextBoxColumn
            // 
            paymentCurrencyCodeDataGridViewTextBoxColumn.DataPropertyName = "paymentCurrencyCode";
            paymentCurrencyCodeDataGridViewTextBoxColumn.HeaderText = "paymentCurrencyCode";
            paymentCurrencyCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentCurrencyCodeDataGridViewTextBoxColumn.Name = "paymentCurrencyCodeDataGridViewTextBoxColumn";
            paymentCurrencyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            paymentCurrencyCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            titleDataGridViewTextBoxColumn.HeaderText = "title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            fNameDataGridViewTextBoxColumn.ReadOnly = true;
            fNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            lNameDataGridViewTextBoxColumn.ReadOnly = true;
            lNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            emailAddressDataGridViewTextBoxColumn.HeaderText = "emailAddress";
            emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            dobDataGridViewTextBoxColumn.HeaderText = "dob";
            dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.ReadOnly = true;
            dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "mobileNumber";
            mobileNumberDataGridViewTextBoxColumn.HeaderText = "mobileNumber";
            mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            mobileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            streetNumberDataGridViewTextBoxColumn.DataPropertyName = "streetNumber";
            streetNumberDataGridViewTextBoxColumn.HeaderText = "streetNumber";
            streetNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
            streetNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            streetNameDataGridViewTextBoxColumn.DataPropertyName = "streetName";
            streetNameDataGridViewTextBoxColumn.HeaderText = "streetName";
            streetNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            streetNameDataGridViewTextBoxColumn.ReadOnly = true;
            streetNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            suburbDataGridViewTextBoxColumn.DataPropertyName = "suburb";
            suburbDataGridViewTextBoxColumn.HeaderText = "suburb";
            suburbDataGridViewTextBoxColumn.MinimumWidth = 6;
            suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            suburbDataGridViewTextBoxColumn.ReadOnly = true;
            suburbDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            cityDataGridViewTextBoxColumn.HeaderText = "city";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            stateDataGridViewTextBoxColumn.HeaderText = "state";
            stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            countryDataGridViewTextBoxColumn.HeaderText = "country";
            countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Subtitle.Location = new Point(273, 95);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new Size(335, 46);
            Subtitle.TabIndex = 2;
            Subtitle.Text = "View / Edit Employee";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(273, 18);
            Title.Name = "Title";
            Title.Size = new Size(321, 67);
            Title.TabIndex = 3;
            Title.Text = "Wage Wizard";
            // 
            // button1
            // 
            button1.Location = new Point(394, 610);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 707);
            Controls.Add(button1);
            Controls.Add(Title);
            Controls.Add(Subtitle);
            Controls.Add(dataGridViewEmployees);
            Name = "EditEmployee";
            Text = "View/Edit Employees";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmployees;
        private DataGridViewTextBoxColumn bsbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxFileNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentCurrencyCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suburbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private BindingSource employeeBindingSource;
        private Label Subtitle;
        private Label Title;
        private Button button1;
    }
}