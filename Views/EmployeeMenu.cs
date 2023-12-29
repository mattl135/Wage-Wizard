using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wage_Wizard.Models;

namespace Wage_Wizard.Views
{
    public partial class EmployeeMenu : Form
    {
        Employee currentUser = Utilities.Utilities.getEmployeeWithID(Utilities.Utilities.currentUserId);

        public EmployeeMenu()
        {
            InitializeComponent();
            WelcomeMsg.Text = "Welcome " + currentUser.GetPersonFullName();
        }

        private void payRequestBtn_Click(object sender, EventArgs e)
        {
            EmployeeRequestPay employeeRequestPay = new EmployeeRequestPay();
            employeeRequestPay.Show();
        }

        private void leaveRequestBTN_Click(object sender, EventArgs e)
        {
            EmployeeRequestLeave employeeRequestLeave = new EmployeeRequestLeave();
            employeeRequestLeave.Show();
        }

        private void PICRequestBTN_Click(object sender, EventArgs e)
        {
            EmployeePICRequest employeePICRequest = new EmployeePICRequest(Utilities.Utilities.currentUserId);
            employeePICRequest.Show();
        }
        private void payHistoryBTN_Click(object sender, EventArgs e)
        {
            EmployeePayHistory employeePayHistory = new EmployeePayHistory();
            employeePayHistory.Show();
        }

        private void leaveHistoryBTN_Click(object sender, EventArgs e)
        {
            EmployeeLeaveHistory employeeLeaveHistory = new EmployeeLeaveHistory();
            employeeLeaveHistory.Show();
        }

        private void PICHistoryBTN_Click(object sender, EventArgs e)
        {
            EmployeePICHistory employeePICHistory = new EmployeePICHistory();
            employeePICHistory.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                isProgramicClose = true;
                this.Close();
                Utilities.Utilities.currentUserId = 0;

                Login login = new Login();
                login.Show();
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
            } else {
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
