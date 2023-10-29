namespace Wage_Wizard.Views
{
    partial class DisplayDBTable
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
            Administrators = new Label();
            Employees = new Label();
            dataGridViewAdmins = new DataGridView();
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
            administratorBindingSource = new BindingSource(components);
            dataGridViewEmployees = new DataGridView();
            bsbDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hourlyRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxFileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentCurrencyCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            emailAddressDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            mobileNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            streetNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            streetNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            suburbDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administratorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Administrators
            // 
            Administrators.AutoSize = true;
            Administrators.Location = new Point(22, 20);
            Administrators.Name = "Administrators";
            Administrators.Size = new Size(85, 15);
            Administrators.TabIndex = 0;
            Administrators.Text = "Administrators";
            // 
            // Employees
            // 
            Employees.AutoSize = true;
            Employees.Location = new Point(407, 20);
            Employees.Name = "Employees";
            Employees.Size = new Size(64, 15);
            Employees.TabIndex = 1;
            Employees.Text = "Employees";
            // 
            // dataGridViewAdmins
            // 
            dataGridViewAdmins.AutoGenerateColumns = false;
            dataGridViewAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdmins.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, fNameDataGridViewTextBoxColumn, lNameDataGridViewTextBoxColumn, emailAddressDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, mobileNumberDataGridViewTextBoxColumn, streetNumberDataGridViewTextBoxColumn, streetNameDataGridViewTextBoxColumn, suburbDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn });
            dataGridViewAdmins.DataSource = administratorBindingSource;
            dataGridViewAdmins.Location = new Point(12, 38);
            dataGridViewAdmins.Name = "dataGridViewAdmins";
            dataGridViewAdmins.RowTemplate.Height = 25;
            dataGridViewAdmins.Size = new Size(379, 400);
            dataGridViewAdmins.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            titleDataGridViewTextBoxColumn.HeaderText = "title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            emailAddressDataGridViewTextBoxColumn.HeaderText = "emailAddress";
            emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            dobDataGridViewTextBoxColumn.HeaderText = "dob";
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "mobileNumber";
            mobileNumberDataGridViewTextBoxColumn.HeaderText = "mobileNumber";
            mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetNumberDataGridViewTextBoxColumn
            // 
            streetNumberDataGridViewTextBoxColumn.DataPropertyName = "streetNumber";
            streetNumberDataGridViewTextBoxColumn.HeaderText = "streetNumber";
            streetNumberDataGridViewTextBoxColumn.Name = "streetNumberDataGridViewTextBoxColumn";
            streetNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            streetNameDataGridViewTextBoxColumn.DataPropertyName = "streetName";
            streetNameDataGridViewTextBoxColumn.HeaderText = "streetName";
            streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            streetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suburbDataGridViewTextBoxColumn
            // 
            suburbDataGridViewTextBoxColumn.DataPropertyName = "suburb";
            suburbDataGridViewTextBoxColumn.HeaderText = "suburb";
            suburbDataGridViewTextBoxColumn.Name = "suburbDataGridViewTextBoxColumn";
            suburbDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            cityDataGridViewTextBoxColumn.HeaderText = "city";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            stateDataGridViewTextBoxColumn.HeaderText = "state";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            countryDataGridViewTextBoxColumn.HeaderText = "country";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // administratorBindingSource
            // 
            administratorBindingSource.DataSource = typeof(Models.Administrator);
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { bsbDataGridViewTextBoxColumn, accountNameDataGridViewTextBoxColumn, accountNumberDataGridViewTextBoxColumn, hourlyRateDataGridViewTextBoxColumn, taxFileNumberDataGridViewTextBoxColumn, paymentCurrencyCodeDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn1, passwordDataGridViewTextBoxColumn1, titleDataGridViewTextBoxColumn1, fNameDataGridViewTextBoxColumn1, lNameDataGridViewTextBoxColumn1, emailAddressDataGridViewTextBoxColumn1, dobDataGridViewTextBoxColumn1, mobileNumberDataGridViewTextBoxColumn1, streetNumberDataGridViewTextBoxColumn1, streetNameDataGridViewTextBoxColumn1, suburbDataGridViewTextBoxColumn1, cityDataGridViewTextBoxColumn1, stateDataGridViewTextBoxColumn1, countryDataGridViewTextBoxColumn1 });
            dataGridViewEmployees.DataSource = employeeBindingSource;
            dataGridViewEmployees.Location = new Point(407, 38);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowTemplate.Height = 25;
            dataGridViewEmployees.Size = new Size(381, 400);
            dataGridViewEmployees.TabIndex = 3;
            // 
            // bsbDataGridViewTextBoxColumn
            // 
            bsbDataGridViewTextBoxColumn.DataPropertyName = "bsb";
            bsbDataGridViewTextBoxColumn.HeaderText = "bsb";
            bsbDataGridViewTextBoxColumn.Name = "bsbDataGridViewTextBoxColumn";
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            accountNameDataGridViewTextBoxColumn.DataPropertyName = "accountName";
            accountNameDataGridViewTextBoxColumn.HeaderText = "accountName";
            accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            accountNumberDataGridViewTextBoxColumn.DataPropertyName = "accountNumber";
            accountNumberDataGridViewTextBoxColumn.HeaderText = "accountNumber";
            accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "hourlyRate";
            hourlyRateDataGridViewTextBoxColumn.HeaderText = "hourlyRate";
            hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            // 
            // taxFileNumberDataGridViewTextBoxColumn
            // 
            taxFileNumberDataGridViewTextBoxColumn.DataPropertyName = "taxFileNumber";
            taxFileNumberDataGridViewTextBoxColumn.HeaderText = "taxFileNumber";
            taxFileNumberDataGridViewTextBoxColumn.Name = "taxFileNumberDataGridViewTextBoxColumn";
            // 
            // paymentCurrencyCodeDataGridViewTextBoxColumn
            // 
            paymentCurrencyCodeDataGridViewTextBoxColumn.DataPropertyName = "paymentCurrencyCode";
            paymentCurrencyCodeDataGridViewTextBoxColumn.HeaderText = "paymentCurrencyCode";
            paymentCurrencyCodeDataGridViewTextBoxColumn.Name = "paymentCurrencyCodeDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            idDataGridViewTextBoxColumn1.HeaderText = "id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            passwordDataGridViewTextBoxColumn1.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn1.HeaderText = "password";
            passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            passwordDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            titleDataGridViewTextBoxColumn1.HeaderText = "title";
            titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fNameDataGridViewTextBoxColumn1
            // 
            fNameDataGridViewTextBoxColumn1.DataPropertyName = "fName";
            fNameDataGridViewTextBoxColumn1.HeaderText = "fName";
            fNameDataGridViewTextBoxColumn1.Name = "fNameDataGridViewTextBoxColumn1";
            fNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn1
            // 
            lNameDataGridViewTextBoxColumn1.DataPropertyName = "lName";
            lNameDataGridViewTextBoxColumn1.HeaderText = "lName";
            lNameDataGridViewTextBoxColumn1.Name = "lNameDataGridViewTextBoxColumn1";
            lNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn1
            // 
            emailAddressDataGridViewTextBoxColumn1.DataPropertyName = "emailAddress";
            emailAddressDataGridViewTextBoxColumn1.HeaderText = "emailAddress";
            emailAddressDataGridViewTextBoxColumn1.Name = "emailAddressDataGridViewTextBoxColumn1";
            emailAddressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn1
            // 
            dobDataGridViewTextBoxColumn1.DataPropertyName = "dob";
            dobDataGridViewTextBoxColumn1.HeaderText = "dob";
            dobDataGridViewTextBoxColumn1.Name = "dobDataGridViewTextBoxColumn1";
            dobDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mobileNumberDataGridViewTextBoxColumn1
            // 
            mobileNumberDataGridViewTextBoxColumn1.DataPropertyName = "mobileNumber";
            mobileNumberDataGridViewTextBoxColumn1.HeaderText = "mobileNumber";
            mobileNumberDataGridViewTextBoxColumn1.Name = "mobileNumberDataGridViewTextBoxColumn1";
            mobileNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // streetNumberDataGridViewTextBoxColumn1
            // 
            streetNumberDataGridViewTextBoxColumn1.DataPropertyName = "streetNumber";
            streetNumberDataGridViewTextBoxColumn1.HeaderText = "streetNumber";
            streetNumberDataGridViewTextBoxColumn1.Name = "streetNumberDataGridViewTextBoxColumn1";
            streetNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // streetNameDataGridViewTextBoxColumn1
            // 
            streetNameDataGridViewTextBoxColumn1.DataPropertyName = "streetName";
            streetNameDataGridViewTextBoxColumn1.HeaderText = "streetName";
            streetNameDataGridViewTextBoxColumn1.Name = "streetNameDataGridViewTextBoxColumn1";
            streetNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // suburbDataGridViewTextBoxColumn1
            // 
            suburbDataGridViewTextBoxColumn1.DataPropertyName = "suburb";
            suburbDataGridViewTextBoxColumn1.HeaderText = "suburb";
            suburbDataGridViewTextBoxColumn1.Name = "suburbDataGridViewTextBoxColumn1";
            suburbDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            cityDataGridViewTextBoxColumn1.DataPropertyName = "city";
            cityDataGridViewTextBoxColumn1.HeaderText = "city";
            cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            cityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn1
            // 
            stateDataGridViewTextBoxColumn1.DataPropertyName = "state";
            stateDataGridViewTextBoxColumn1.HeaderText = "state";
            stateDataGridViewTextBoxColumn1.Name = "stateDataGridViewTextBoxColumn1";
            stateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn1
            // 
            countryDataGridViewTextBoxColumn1.DataPropertyName = "country";
            countryDataGridViewTextBoxColumn1.HeaderText = "country";
            countryDataGridViewTextBoxColumn1.Name = "countryDataGridViewTextBoxColumn1";
            countryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // DisplayDBTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(dataGridViewAdmins);
            Controls.Add(Employees);
            Controls.Add(Administrators);
            Cursor = Cursors.IBeam;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DisplayDBTable";
            Text = "Display DB Table";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdmins).EndInit();
            ((System.ComponentModel.ISupportInitialize)administratorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Administrators;
        private Label Employees;
        private DataGridView dataGridViewAdmins;
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
        private BindingSource administratorBindingSource;
        private DataGridView dataGridViewEmployees;
        private DataGridViewTextBoxColumn bsbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxFileNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentCurrencyCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn streetNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn streetNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn suburbDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn1;
        private BindingSource employeeBindingSource;
    }
}