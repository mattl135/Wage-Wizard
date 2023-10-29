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

namespace Wage_Wizard.Views
{
    public partial class AdminLeaveHistory : Form
    {
        private object? dbContext;

        public AdminLeaveHistory()
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
            leaveHistoryDGV.DataSource = filteredData;

            leaveHistoryDGV.Columns["id"].HeaderText = "Leave Request ID";
            leaveHistoryDGV.Columns["employeeID"].HeaderText = "Employee ID";
            leaveHistoryDGV.Columns["fName"].HeaderText = "First Name";
            leaveHistoryDGV.Columns["lName"].HeaderText = "Last Name";
            leaveHistoryDGV.Columns["hours"].HeaderText = "Leave Ammount Requested";
            leaveHistoryDGV.Columns["accumulatedLeave"].HeaderText = "Accumulated Leave Available";
            leaveHistoryDGV.Columns["leaveDescription"].HeaderText = "Leave Description";
            leaveHistoryDGV.Columns["approvalStatus"].HeaderText = "Approval Status";

            //Refresh to load data
            leaveHistoryDGV.Refresh();

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
    }
}
