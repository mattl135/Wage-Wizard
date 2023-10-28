using Microsoft.IdentityModel.Tokens;
using System.Collections.Immutable;
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
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    var persons = context.Persons;
                    if (context.Persons.Any(person => person.id == userIDInput))
                    {
                        Console.WriteLine("User ID is valid");
                        if (context.Persons.Any(person => person.password == passwordInput))
                        {
                            Console.WriteLine("Password is valid");
                            validLogin = true;
                            var user = persons.SingleOrDefault(p => p.id == userIDInput);
                            if (user != null)
                            {
                                Console.WriteLine($"Current user: {user.GetPersonFullName()}, Role: {user.GetType()}");
                                MessageBox.Show($"Welcome {user.GetPersonFullName()}.\nYou are logged in as a {user.GetType()}",
                                                    "Login Successful",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                throw new Exception("The UserId and Password valid but the object could not be retrieved");
                            }
                        }
                    }

                    if (!validLogin)
                    {
                        Console.WriteLine("Invalid Login");
                        MessageBox.Show("Either the UserID or Password entered was incorrect.\nPlease double check the credentials and try again.",
                            "Incorrect Username or Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                            );
                    } else
                    {
                        this.Hide();
                        //DisplayDBTable displayDBTable = new DisplayDBTable();
                        //displayDBTable.ShowDialog();
                        AdminMenu adminMenu = new AdminMenu();
                        adminMenu.Show();
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
    }
}