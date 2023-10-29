using Microsoft.EntityFrameworkCore;
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
    public partial class AdminLeaveApproval : Form
    {
        private object? dbContext;

        public AdminLeaveApproval()
        {
            InitializeComponent();
        }

        //Runs commands to create and display the database when the screen loads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using WageWizardContext context = new WageWizardContext();
            var leaveRequests = context.LeaveRequests;
            var employees = context.Employees;
            var persons = context.Persons;


            var filteredData = (from request in leaveRequests
                                join employee in employees on request.employeeID equals employee.id
                                join person in persons on employee.id equals person.id
                                where request.approvalStatus == Request.ApprovalStatus.Pending
                                select new
                                {
                                    request.id,
                                    request.employeeID,
                                    person.fName,
                                    person.lName,
                                    request.hours,
                                    employee.accumulatedLeave,
                                    request.leaveDescription,
                                    request.approvalStatus
                                }).ToList();
            leaveRequestsDGV.DataSource = filteredData;

            leaveRequestsDGV.Columns["id"].HeaderText = "Leave Request ID";
            leaveRequestsDGV.Columns["employeeID"].HeaderText = "Employee ID";
            leaveRequestsDGV.Columns["fName"].HeaderText = "First Name";
            leaveRequestsDGV.Columns["lName"].HeaderText = "Last Name";
            leaveRequestsDGV.Columns["hours"].HeaderText = "Leave Ammount Requested";
            leaveRequestsDGV.Columns["accumulatedLeave"].HeaderText = "Accumulated Leave Available";
            leaveRequestsDGV.Columns["leaveDescription"].HeaderText = "Leave Description";
            leaveRequestsDGV.Columns["approvalStatus"].HeaderText = "Approval Status";

            //Refresh to load data
            leaveRequestsDGV.Refresh();

            //Forces the screen to open the window in the topleft of the screen
            int x = Screen.PrimaryScreen.WorkingArea.Top;
            int y = Screen.PrimaryScreen.WorkingArea.Left;
            this.Location = new Point(x, y);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dbContext = null;
        }

        //Exit button to close menu
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Read the databse and determine the outcome of the request based on user input
        private void approveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to Approve these Leave Requests?",
                "Confirm Leave Request Approval?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in leaveRequestsDGV.SelectedRows)
                {
                    LeaveRequest leaveRequest = Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value));

                    //Checks if the approval status is pending to prevent users from editing already actioned requests
                    if (Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Request.ApprovalStatus.Pending)
                    {
                        //ADD CHECK TO MAKE SURE LEAVE WILL BE GREATER THAN 0 after approving
                        Employee employee = Utilities.Utilities.getEmployeeWithID(leaveRequest.employeeID);
                        if (leaveRequest.hours <= employee.accumulatedLeave)
                        {
                            leaveRequest.approvalStatus = Request.ApprovalStatus.Approved;
                            employee.accumulatedLeave = employee.accumulatedLeave - leaveRequest.hours;
                            Utilities.Utilities.saveLeaveRequestChangesToDB(leaveRequest);
                            Utilities.Utilities.saveEmployeeChangesToDB(employee);
                        }
                        else
                        {
                            MessageBox.Show("The employee does not have enough accumulated leave available.", "Unable to complete leave request", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can only edit 'Pending' requests!");
                    }
                }

                //reopens the screen to refresh/update the database on screen
                AdminLeaveApproval refresh = new AdminLeaveApproval();
                refresh.Show();
                this.Close();
            }
            else
            {
                // User clicked 'No', do nothing
            }
        }

        //Read the databse and determine the outcome of the request based on user input
        private void denyBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to Reject these Leave Requests?",
                "Confirm Leave Request Rejection?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in leaveRequestsDGV.SelectedRows)
                {
                    LeaveRequest leaveRequest = Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value));

                    //Checks if the approval status is pending to prevent users from editing already actioned requests
                    if (Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Request.ApprovalStatus.Pending)
                    {
                        leaveRequest.approvalStatus = Request.ApprovalStatus.Rejected;
                        Utilities.Utilities.saveLeaveRequestChangesToDB(leaveRequest);
                    }
                    else
                    {
                        MessageBox.Show("You can only edit 'Pending' Requests!");
                    }

                    //reopens the screen to refresh/update the database on screen
                    AdminLeaveApproval refresh = new AdminLeaveApproval();
                    refresh.Show();
                    this.Close();
                }
            }
            else
            {
                // User clicked 'No', do nothing
            }
        }
    }
}
