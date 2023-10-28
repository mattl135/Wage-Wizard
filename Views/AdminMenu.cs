using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wage_Wizard.Views
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void payApprovalBTN_Click(object sender, EventArgs e)
        {

        }

        private void payHistoryBTN_Click(object sender, EventArgs e)
        {

        }

        private void leaveApprovalBTN_Click(object sender, EventArgs e)
        {

        }

        private void leaveHistoryBTN_Click(object sender, EventArgs e)
        {

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

        }
    }
}
