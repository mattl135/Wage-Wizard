using Microsoft.IdentityModel.Tokens;
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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();

            // Bind TextBoxes that should only accept numbers
            mobileTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            streetNumberField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            bsbTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            accountNumberTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            taxFileNumberTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);
            hourlyRateTextField.KeyPress += new KeyPressEventHandler(this.validateNumbersOnly_KeyPress);

            // Bind TextBoxes that should not accept numbers
            fNameTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            lNameTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            streetNameField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            suburbTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            cityTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            stateTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            countryTextField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);
            accountNameField.KeyPress += new KeyPressEventHandler(this.validateNoNumbersAllowed_KeyPress);

            titleComboBox.DataSource = Enum.GetValues(typeof(Person.Title));
            List<string> currencyCodes = new List<string> { "AUD", "USD", "EUR", "GBP", "JPY", "CAD", "NZD", "INR" };
            currencyComboBox.DataSource = currencyCodes;
        }

        //Runs commands to create and display the database when the screen loads
        protected override void OnLoad(EventArgs e)
        {
            //No actions required
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
            if (areFieldsEmpty())
            {
                Console.WriteLine("One or more fields are empty");
                MessageBox.Show($"One or more fields was empty. Please ensure that all fields are populated.", "One or more fields are empty",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to create a new employee with these values?",
                "Confirm creating a new emploee with these values?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    // Read values from text boxes, combo boxes, etc.
                    string updatedPassword = passwordTextBox.Text;
                    Person.Title updatedTitle = (Person.Title)Enum.Parse(typeof(Person.Title), titleComboBox.SelectedItem.ToString());
                    string updatedFName = fNameTextField.Text;
                    string updatedLName = lNameTextField.Text;
                    string updatedEmailAddress = emailTextField.Text;
                    string updatedDOB = dateOfBirthPicker.Value.ToString("yyyy-MM-dd");
                    int updatedMobileNumber = Convert.ToInt32(mobileTextField.Text);
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
                    double updatedHourlyRate = double.Parse(hourlyRateTextField.Text);

                    // Create PersonChangeRequest instance
                    Employee employee = new Employee(
                        updatedBSB,
                        updatedAccountName,
                        updatedAccountNumber,
                        updatedHourlyRate,
                        updatedTaxFileNumber,
                        updatedPaymentCurrencyCode,
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
                        updatedCountry
                        );

                    try
                    {
                        Utilities.Utilities.addEmployeeToDB(employee);
                        Thread.Sleep(1000);
                        MessageBox.Show($"The new employee was succesfully created.\nThe ID of the new employee is: {employee.id}", "Employee created successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unable to save employee information");
                        Console.WriteLine($"{ex.Message}\n{ex.ToString()}");
                        MessageBox.Show($"An error occured when attempting to save the new employee fields.\n{ex.Message}", "An Error Occured",
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

        private bool areFieldsEmpty()
        {
            // Read values from text boxes, combo boxes, etc.
            if (string.IsNullOrEmpty(passwordTextBox.Text)) return true;
            if (string.IsNullOrEmpty(passwordTextBox.Text)) return true;
            if (string.IsNullOrEmpty(titleComboBox.SelectedItem?.ToString())) return true;
            if (string.IsNullOrEmpty(fNameTextField.Text)) return true;
            if (string.IsNullOrEmpty(lNameTextField.Text)) return true;
            if (string.IsNullOrEmpty(emailTextField.Text)) return true;
            if (string.IsNullOrEmpty(dateOfBirthPicker.Value.ToString("yyyy-MM-dd"))) return true;
            if (string.IsNullOrEmpty(mobileTextField.Text)) return true;
            if (string.IsNullOrEmpty(streetNumberField.Text)) return true;
            if (string.IsNullOrEmpty(bsbTextField.Text)) return true;
            if (string.IsNullOrEmpty(accountNameField.Text)) return true;
            if (string.IsNullOrEmpty(accountNumberTextField.Text)) return true;
            if (string.IsNullOrEmpty(taxFileNumberTextField.Text)) return true;
            if (string.IsNullOrEmpty(hourlyRateTextField.Text)) return true;
            if (string.IsNullOrEmpty(streetNameField.Text)) return true;
            if (string.IsNullOrEmpty(suburbTextField.Text)) return true;
            if (string.IsNullOrEmpty(cityTextField.Text)) return true;
            if (string.IsNullOrEmpty(stateTextField.Text)) return true;
            if (string.IsNullOrEmpty(countryTextField.Text)) return true;
            if (string.IsNullOrEmpty(currencyComboBox.Text)) return true;
            return false; // Returns false if all fields are filled
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
