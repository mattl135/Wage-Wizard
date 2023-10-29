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
using Wage_Wizard.Utilities;

namespace Wage_Wizard.Views
{
    public partial class AdminPayApproval : Form
    {
        private object? dbContext;

        public AdminPayApproval()
        {
            InitializeComponent();
        }

        //Initialises and creates the screen when it loads. Allocated the correct values to connect to the database
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using WageWizardContext context = new WageWizardContext();
            dbContext = context;
            var payRequests = context.PaymentRequests;
            payRequests.Load();
            payRequestsDGV.DataSource = payRequests.Local.ToBindingList();
            payRequestsDGV.Refresh();
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

        private void approveBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in payRequestsDGV.SelectedRows)
            {
                /* PaymentRequest paymentRequest = new PaymentRequest(employees[0], 15.53);
                r.Cells[3].Value = 1; //use the column name instead of column index
                Utilities.Utilities.savePayRequestChangesToDB(paymentRequest); */

                //UpdatePaymentRequest
                List<int> paymentRequests = Utilities.Utilities.getPayRequestIDs();
                PaymentRequest paymentRequest = Utilities.Utilities.getPayRequestWithID(paymentRequests[Convert.ToInt32(r.Cells[1].Value) - 1]);
                paymentRequest.approvalStatus = Request.ApprovalStatus.Approved;
                Utilities.Utilities.savePayRequestChangesToDB(paymentRequest);
            }

            //reopens the screen to refresh/update the database on screen
            AdminPayApproval refresh = new AdminPayApproval();
            refresh.Show();
            this.Close();
        }

        private void payRequestsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* int index = e.RowIndex;
            int cell = 0;
            DataGridViewRow selectedRow = payRequestsDGV.Rows[index];
            cell = selectedRow.Cells[3] 
            */
            //return cell;
        }
    }
}
