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
            dbContext = context;
            var leaveRequests = context.LeaveRequests;
            leaveRequests.Load();
            leaveHistoryDGV.DataSource = leaveRequests.Local.ToBindingList();
            leaveHistoryDGV.Refresh();
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

        private void leaveHistoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
