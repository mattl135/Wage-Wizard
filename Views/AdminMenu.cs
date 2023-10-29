using Microsoft.Identity.Client.Utils.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wage_Wizard.Data;
using Wage_Wizard.Models;

namespace Wage_Wizard.Views
{
    public partial class AdminMenu : Form
    {
        //get the administrator object

        public AdminMenu()
        {
            InitializeComponent();
            Administrator currentUser = Utilities.Utilities.getAdministratorWithID(Utilities.Utilities.currentUserId);
            WelcomeMsg.Text = "Welcome " + currentUser.GetPersonFullName();
        }

        private void payApprovalBTN_Click(object sender, EventArgs e)
        {
            AdminPayApproval adminPayApproval = new AdminPayApproval();
            adminPayApproval.Show();
        }

        private void payHistoryBTN_Click(object sender, EventArgs e)
        {
            AdminPayHistory adminPayHistory = new AdminPayHistory();
            adminPayHistory.Show();
        }

        private void leaveApprovalBTN_Click(object sender, EventArgs e)
        {
            AdminLeaveApproval adminLeaveApproval = new AdminLeaveApproval();
            adminLeaveApproval.Show();
        }

        private void leaveHistoryBTN_Click(object sender, EventArgs e)
        {
            AdminLeaveHistory adminLeaveHistory = new AdminLeaveHistory();
            adminLeaveHistory.Show();
        }

        private void PICApprovalBTN_Click(object sender, EventArgs e)
        {

        }

        private void PICHistoryBTN_Click(object sender, EventArgs e)
        {

        }

        private void employeesBTN_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployee = new EditEmployee();
            editEmployee.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void globalSettingsBTN_Click(object sender, EventArgs e)
        {
            GlobalSettingsMenu globalSettingsMenu = new GlobalSettingsMenu();
            globalSettingsMenu.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Utilities.Utilities.currentUserId = 0;

            Login login = new Login();
            login.Show();
        }
    }
}
