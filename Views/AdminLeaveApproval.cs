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




        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in leaveRequestsDGV.SelectedRows)
            {
                //UpdatePaymentRequest
                List<int> leaveRequests = Utilities.Utilities.getLeaveRequestsIDs();
                LeaveRequest leaveRequest = Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[2].Value));
                leaveRequest.approvalStatus = Request.ApprovalStatus.Approved;
                Utilities.Utilities.saveLeaveRequestChangesToDB(leaveRequest);
            }

            //reopens the screen to refresh/update the database on screen
            AdminLeaveApproval refresh = new AdminLeaveApproval();
            refresh.Show();
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in leaveRequestsDGV.SelectedRows)
            {
                //UpdatePaymentRequest
                List<int> leaveRequests = Utilities.Utilities.getLeaveRequestsIDs();
                LeaveRequest leaveRequest = Utilities.Utilities.getLeaveRequestWithID(Convert.ToInt32(r.Cells[2].Value));
                leaveRequest.approvalStatus = Request.ApprovalStatus.Rejected;
                Utilities.Utilities.saveLeaveRequestChangesToDB(leaveRequest);
            }

            //reopens the screen to refresh/update the database on screen
            AdminLeaveApproval refresh = new AdminLeaveApproval();
            refresh.Show();
            this.Close();
        }
    }
}
