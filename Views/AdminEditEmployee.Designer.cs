namespace Wage_Wizard.Views
{
    partial class AdminEditEmployee
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hourlyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxFileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentCurrencyCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            EditEmployeeBtn = new Button();
            exitBtn = new Button();
            Subheader = new Label();
            Header = new Label();
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
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, bsbDataGridViewTextBoxColumn, accountNameDataGridViewTextBoxColumn, accountNumberDataGridViewTextBoxColumn, hourlyRateDataGridViewTextBoxColumn, taxFileNumberDataGridViewTextBoxColumn, paymentCurrencyCodeDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, fNameDataGridViewTextBoxColumn, lNameDataGridViewTextBoxColumn, emailAddressDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, mobileNumberDataGridViewTextBoxColumn, streetNumberDataGridViewTextBoxColumn, streetNameDataGridViewTextBoxColumn, suburbDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn });
            dataGridViewEmployees.DataSource = employeeBindingSource;
            dataGridViewEmployees.Location = new Point(13, 156);
            dataGridViewEmployees.MultiSelect = false;
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(975, 392);
            dataGridViewEmployees.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsbDataGridViewTextBoxColumn
            // 
            bsbDataGridViewTextBoxColumn.DataPropertyName = "bsb";
            bsbDataGridViewTextBoxColumn.HeaderText = "Employee BSB";
            bsbDataGridViewTextBoxColumn.MinimumWidth = 6;
            bsbDataGridViewTextBoxColumn.Name = "bsbDataGridViewTextBoxColumn";
            bsbDataGridViewTextBoxColumn.ReadOnly = true;
            bsbDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "accountName";
            accountNameDataGridViewTextBoxColumn.HeaderText = "Employee Account Name";
            accountNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            accountNameDataGridViewTextBoxColumn.ReadOnly = true;
            accountNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            accountNumberDataGridViewTextBoxColumn.DataPropertyName = "accountNumber";
            accountNumberDataGridViewTextBoxColumn.HeaderText = "Employee Account Number";
            accountNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            accountNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "hourlyRate";
            hourlyRateDataGridViewTextBoxColumn.HeaderText = "Employee Hourly Rate";
            hourlyRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            hourlyRateDataGridViewTextBoxColumn.ReadOnly = true;
            hourlyRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // taxFileNumberDataGridViewTextBoxColumn
            // 
            taxFileNumberDataGridViewTextBoxColumn.DataPropertyName = "taxFileNumber";
            taxFileNumberDataGridViewTextBoxColumn.HeaderText = "Employee Tax File Number";
            taxFileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            taxFileNumberDataGridViewTextBoxColumn.Name = "taxFileNumberDataGridViewTextBoxColumn";
            taxFileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            taxFileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentCurrencyCodeDataGridViewTextBoxColumn
            // 
            paymentCurrencyCodeDataGridViewTextBoxColumn.DataPropertyName = "paymentCurrencyCode";
            paymentCurrencyCodeDataGridViewTextBoxColumn.HeaderText = "Employee Payment Currency";
            paymentCurrencyCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            paymentCurrencyCodeDataGridViewTextBoxColumn.Name = "paymentCurrencyCodeDataGridViewTextBoxColumn";
            paymentCurrencyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            paymentCurrencyCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Employee Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            fNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            fNameDataGridViewTextBoxColumn.ReadOnly = true;
            fNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            lNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            lNameDataGridViewTextBoxColumn.ReadOnly = true;
            lNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            emailAddressDataGridViewTextBoxColumn.HeaderText = "Employee Email Address";
            emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Employee Date of Birth";
            dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.ReadOnly = true;
            dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "mobileNumber";
            mobileNumberDataGridViewTextBoxColumn.HeaderText = "Employee Mobile Number";
            mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            mobileNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            streetNumberDataGridViewTextBoxColumn.DataPropertyName = "streetNumber";
            streetNumberDataGridViewTextBoxColumn.HeaderText = "Employee Street Number";
            streetNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
            streetNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            streetNameDataGridViewTextBoxColumn.DataPropertyName = "streetName";
            streetNameDataGridViewTextBoxColumn.HeaderText = "Employee Street Name";
            streetNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            streetNameDataGridViewTextBoxColumn.ReadOnly = true;
            streetNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            suburbDataGridViewTextBoxColumn.DataPropertyName = "suburb";
            suburbDataGridViewTextBoxColumn.HeaderText = "Employee Suburb";
            suburbDataGridViewTextBoxColumn.MinimumWidth = 6;
            suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            suburbDataGridViewTextBoxColumn.ReadOnly = true;
            suburbDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            cityDataGridViewTextBoxColumn.HeaderText = "Employee City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            stateDataGridViewTextBoxColumn.HeaderText = "Employee State";
            stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            countryDataGridViewTextBoxColumn.HeaderText = "Employee Country";
            countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // EditEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 667);
            Controls.Add(Subheader);
            Controls.Add(Header);
            Controls.Add(exitBtn);
            Controls.Add(EditEmployeeBtn);
            Controls.Add(dataGridViewEmployees);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private Button EditEmployeeBtn;
        private Button exitBtn;
        private Label Subheader;
        private Label Header;
    }
}