using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wage_Wizard.Models;

namespace Wage_Wizard.Views
{
    public partial class EmployeeRequestLeave : Form
    {
        Employee currentUser = Utilities.Utilities.getEmployeeWithID(Utilities.Utilities.currentUserId);
        decimal leaveHours;

        public EmployeeRequestLeave()
        {
            InitializeComponent();
            AvailHoursDisplay.Text = Convert.ToString(currentUser.accumulatedLeave);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeaveHours_ValueChanged(object sender, EventArgs e)
        {
            leaveHours = LeaveHours.Value;
        }

        private void RequestLeaveBtn_Click(object sender, EventArgs e)
        {
            //Leave description is mandatory
            if (LeaveDesTextBox.Text.Length == 0)
            {
                MessageBox.Show("A leave description is mandatory.", "Request Leave - Failure");
            }
            else
            {
                //check the user has enough leave for the request


                //add the request to the DB



                //ADD REQUEST ID
                MessageBox.Show("Request submitted. The request ID is ", "Request Leave - Success");
                this.Close();
            }
        }
    }
}
