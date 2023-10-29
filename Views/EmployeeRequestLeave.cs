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
        //default is 1, as that is the minimum
        decimal requestedLeaveHours = 1;

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
            requestedLeaveHours = LeaveHours.Value;
        }

        private void RequestLeaveBtn_Click(object sender, EventArgs e)
        {
            //check the user has enough leave for the request
            if ((double)requestedLeaveHours > currentUser.accumulatedLeave)
            {
                MessageBox.Show("The requested amount of leave is greater than the available amount.", "Request Leave - Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Leave description is mandatory
                if (LeaveDesTextBox.Text.Length == 0)
                {
                    MessageBox.Show("A leave description is mandatory.", "Request Leave - Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //add the request to the DB
                    LeaveRequest leaveRequest = new LeaveRequest(currentUser.id, (double)requestedLeaveHours, LeaveDesTextBox.Text);
                    Utilities.Utilities.addLeaveRequestToDB(leaveRequest);
                    MessageBox.Show("Request submitted. The request ID is " + leaveRequest.id, "Request Leave - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
