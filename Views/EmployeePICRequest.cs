using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wage_Wizard.Data;
using Wage_Wizard.Models;

namespace Wage_Wizard.Views
{
    public partial class EmployeePICRequest : Form
    {
        private int employeeID;
        public EmployeePICRequest(int employeeID)
        {
            InitializeComponent();
            // Store the passed value for later use
            if (Utilities.Utilities.isEmployee(employeeID))
            {
                this.employeeID = employeeID;
            }
            else
            {
                Console.WriteLine($"The employee ID {employeeID} was not a valid employee.");
                MessageBox.Show($"An error occured when attempting to retrieve and populate the employee fields.", "An Error Occured",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                this.Close();
            }


            // Bind TextBoxes that should only accept numbers
            mobileTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            streetNumberField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            bsbTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            accountNumberTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            taxFileNumberTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);

            // Bind TextBoxes that should not accept numbers
            fNameTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            lNameTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            streetNameField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            suburbTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            cityTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            stateTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            countryTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);

            titleComboBox.DataSource = Enum.GetValues(typeof(Person.Title));
            List<string> currencyCodes = new List<string> { "AUD", "USD", "EUR", "GBP", "JPY", "CAD", "NZD", "INR" };
            currencyComboBox.DataSource = currencyCodes;
        }

        //Runs commands to create and display the database when the screen loads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                using WageWizardContext context = new WageWizardContext();
                var employees = context.Employees;
                Employee employee = Utilities.Utilities.getEmployeeWithID(employeeID);

                // Assign the values from the object to the form controls
                passwordTextBox.Text = employee.password;
                titleComboBox.SelectedItem = employee.title; // Since the ComboBox is populated with enum values, this should work
                fNameTextField.Text = employee.fName;
                lNameTextField.Text = employee.lName;
                emailTextField.Text = employee.emailAddress;
                dateOfBirthPicker.Value = DateTime.ParseExact(employee.dob, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                mobileTextField.Text = employee.mobileNumber.ToString();
                streetNumberField.Text = employee.streetNumber.ToString();
                streetNameField.Text = employee.streetName;
                suburbTextField.Text = employee.suburb;
                cityTextField.Text = employee.city;
                stateTextField.Text = employee.state;
                countryTextField.Text = employee.country;
                bsbTextField.Text = employee.bsb.ToString();
                accountNameField.Text = employee.accountName;
                accountNumberTextField.Text = employee.accountNumber.ToString();
                taxFileNumberTextField.Text = employee.taxFileNumber.ToString();
                currencyComboBox.SelectedItem = employee.paymentCurrencyCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve employee information");
                Console.WriteLine($"{ex.Message}\n{ex.ToString()}");
                MessageBox.Show($"An error occured when attempting to retrieve and populate the employee fields.\n{ex.Message}", "An Error Occured",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                this.Close();
            }
        }

        // This method will allow only numbers to be input
        private void validateNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // This method will disallow any numbers from being input
        private void validateNoNumbersAllowed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to disregard these changes?",
                "Confirm disregard changes?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Do Nothing
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to submit these changes as a Personal Information Change Request?",
                "Confirm submission of Personal Information Change Request?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                // Read values from text boxes, combo boxes, etc.
                string updatedPassword = passwordTextBox.Text;
                PersonChangeRequest.Title updatedTitle = (PersonChangeRequest.Title)Enum.Parse(typeof(PersonChangeRequest.Title), titleComboBox.SelectedItem.ToString());
                string updatedFName = fNameTextField.Text;
                string updatedLName = lNameTextField.Text;
                string updatedEmailAddress = emailTextField.Text;
                string updatedDOB = dateOfBirthPicker.Value.ToString("yyyy-MM-dd");
                int updatedMobileNumber = int.Parse(mobileTextField.Text);
                int updatedStreetNumber = int.Parse(streetNumberField.Text);
                string updatedStreetName = streetNameField.Text;
                string updatedSuburb = suburbTextField.Text;
                string updatedCity = cityTextField.Text;
                string updatedState = stateTextField.Text;
                string updatedCountry = countryTextField.Text;
                int updatedBSB = int.Parse(bsbTextField.Text);
                string updatedAccountName = accountNameField.Text;
                int updatedAccountNumber = int.Parse(accountNumberTextField.Text);
                int updatedTaxFileNumber = int.Parse(taxFileNumberTextField.Text);
                string updatedPaymentCurrencyCode = currencyComboBox.Text;

                // Create PersonChangeRequest instance
                PersonChangeRequest request = new PersonChangeRequest(
                    this.employeeID,
                    updatedPassword,
                    updatedTitle,
                    updatedFName,
                    updatedLName,
                    updatedEmailAddress,
                    updatedDOB,
                    updatedMobileNumber,
                    updatedStreetNumber,
                    updatedStreetName,
                    updatedSuburb,
                    updatedCity,
                    updatedState,
                    updatedCountry,
                    updatedBSB,
                    updatedAccountName,
                    updatedAccountNumber,
                    updatedTaxFileNumber,
                    updatedPaymentCurrencyCode);

                try
                {
                    Utilities.Utilities.addPersonChangeRequestsToDB(request);
                    Thread.Sleep(1000);
                    MessageBox.Show($"The personal information change request was succesfully created.\nThe ID of the request is: {request.id}", "Request submitted successfully",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to save employee information");
                    Console.WriteLine($"{ex.Message}\n{ex.ToString()}");
                    MessageBox.Show($"An error occured when attempting to retrieve and populate the employee fields.\n{ex.Message}", "An Error Occured",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                }
                finally
                {
                    this.Close();
                }
            }
            else
            {
                //Do Nothing
            }
        }
    }
}
