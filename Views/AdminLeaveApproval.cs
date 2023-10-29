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
            dbContext = context;
            var leaveRequests = context.LeaveRequests;
            leaveRequests.Load();
            leaveRequestsDGV.DataSource = leaveRequests.Local.ToBindingList();
            leaveRequestsDGV.Refresh();
            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();

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
            foreach (DataGridViewRow r in leaveRequestsDGV.SelectedRows)
            {
                //UpdatePaymentRequest
                List<int> leaveRequests = Utilities.Utilities.getLeaveRequestsIDs();
                LeaveRequest leaveRequest = Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value));

                //Checks if the approval status is pending to prevent users from editing already actioned requests
                if (Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Request.ApprovalStatus.Pending)
                {
                    leaveRequest.approvalStatus = Request.ApprovalStatus.Approved;
                    Utilities.Utilities.saveLeaveRequestChangesToDB(leaveRequest);
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

        //Read the databse and determine the outcome of the request based on user input
        private void denyBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in leaveRequestsDGV.SelectedRows)
            {
                //UpdatePaymentRequest
                List<int> leaveRequests = Utilities.Utilities.getLeaveRequestsIDs();
                LeaveRequest leaveRequest = Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value));

                //Checks if the approval status is pending to prevent users from editing already actioned requests
                if (Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Request.ApprovalStatus.Pending)
                {
                    leaveRequest.approvalStatus = Request.ApprovalStatus.Rejected;
                    Utilities.Utilities.saveLeaveRequestChangesToDB(leaveRequest);
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
    }
}
