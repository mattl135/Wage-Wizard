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
    public partial class EmployeeLeaveHistory : Form
    {
        private object? dbContext;

        public EmployeeLeaveHistory()
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
                                where request.employeeID == Utilities.Utilities.currentUserId
                                select new
                                {
                                    request.id,
                                    request.hours,
                                    employee.accumulatedLeave,
                                    request.leaveDescription,
                                    request.approvalStatus
                                }).ToList();
            leaveHistoryDGV.DataSource = filteredData;

            leaveHistoryDGV.Columns["id"].HeaderText = "Leave Request ID";
            leaveHistoryDGV.Columns["hours"].HeaderText = "Leave Amount Requested";
            leaveHistoryDGV.Columns["accumulatedLeave"].HeaderText = "Accumulated Leave Available";
            leaveHistoryDGV.Columns["leaveDescription"].HeaderText = "Leave Description";
            leaveHistoryDGV.Columns["approvalStatus"].HeaderText = "Approval Status";

            //Refresh to load data
            leaveHistoryDGV.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dbContext = null;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
