using Microsoft.IdentityModel.Tokens;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Windows.Forms;
using Wage_Wizard.Data;
using Wage_Wizard.Models;
using Wage_Wizard.Views;

namespace Wage_Wizard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            logo.Image = Image.FromFile("Resources\\Wage_Wizard-1.png");
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = ColorTranslator.FromHtml("#fffce6");

        }

        private void LoginForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;  // This will remove focus from the TextBox
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
                e.Handled = true;  // Indicate that the key event has been handled
            }
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login Button Pressed");
            string userIDInputString = userIDTextField.Text;
            string passwordInput = passwordTextField.Text;
            Console.WriteLine($"UserID: {userIDInputString}\nPassword: {passwordInput}");

            try
            {
                bool validLogin = false;
                int userIDInput = 0;
                if (userIDInputString.IsNullOrEmpty() || passwordInput.IsNullOrEmpty())
                {
                    Console.WriteLine("Either the username or the password was blank.");
                    MessageBox.Show("The UserID or Password text field was blank.\nPlease double check the credentials and try again.",
                        "Incorrect Username or Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

                }

                else if (!Int32.TryParse(userIDInputString, out userIDInput))
                {
                    Console.WriteLine("The UserID was not a valid number.");
                    MessageBox.Show("The UserID was not a valid number. \nPlease double check the credentials and try again.",
                        "Incorrect Username or Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
                else
                {
                    if (Utilities.Utilities.isValidCredentials(userIDInput, passwordInput))
                    {
                        //set the current user ID, for global use
                        Utilities.Utilities.currentUserId = userIDInput;

                        this.Hide();
                        //DisplayDBTable displayDBTable = new DisplayDBTable();
                        //displayDBTable.ShowDialog();

                        if (Utilities.Utilities.isAdministrator(userIDInput))
                        {
                            AdminMenu adminMenu = new AdminMenu();
                            adminMenu.Show();
                        }
                        else if (Utilities.Utilities.isEmployee(userIDInput))
                        {
                            EmployeeMenu employeeMenu = new EmployeeMenu();
                            employeeMenu.Show();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Login");
                        MessageBox.Show("Either the UserID or Password entered was incorrect.\nPlease double check the credentials and try again.",
                            "Incorrect Username or Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An error occured when attempting to login\n" + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            finally
            {
                userIDTextField.Clear();
                passwordTextField.Clear();
                this.ActiveControl = null;
            }
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                isProgramicClose = true;
                Application.Exit();
            }
            else
            {
                // User clicked 'No', do nothing
            }
        }

        //Handles Application Closing
        private bool isProgramicClose = false;
        private bool isClosingHandled = false;
        private void formClosing(Object sender, FormClosingEventArgs e)
        {

            if (isClosingHandled || isProgramicClose)
            {
                return; // Already handled, do nothing
            }
            else
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult dialogResult = MessageBox.Show(
                        "Are you sure you want to exit?",
                        "Exit Application",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,  // This sets the icon to a question mark
                        MessageBoxDefaultButton.Button2);

                    if (dialogResult == DialogResult.Yes)
                    {
                        isProgramicClose = true;
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        e.Cancel = true; //Stop form from Closing
                    }
                }
            }
        }
    }
}