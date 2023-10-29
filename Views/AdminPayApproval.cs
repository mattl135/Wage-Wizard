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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


            //payRequests.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", 0, 0);

            /* foreach (DataGridViewRow row in payRequestsDGV.Rows)
            {
                string s;
                if (row.Cells[3].Value.ToString != null)
                {
                    s = row.Cells[3].Value.ToString();

                    if (!s.StartsWith("0", true, null))
                    {
                        CurrencyManager payRequestsTable = (CurrencyManager)BindingContext[payRequestsDGV.DataSource];
                        payRequestsTable.SuspendBinding();
                        row.Visible = false;
                        payRequestsTable.ResumeBinding();
                    }
                    else
                        row.Visible = true;
                }
            } */

            //int index = (from payRequestsDGV.Rows.Cast<DataGridViewRow>()


            /* var sortByPending = (payRequestsDGV.Rows.Cast<DataGridViewRow>()
                 .Where(r => r.Cells[3].Value != null)
                 .Select(r => new { Page = Convert.ToInt32(r.Cells[3].Value) == 0 })
                 .GroupBy(pageR => pageR)
                 .OrderByDescending(g => g.Count())
                 .Select(g => new {PAGE = g.Key.Page}) ).ToList(); */
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
                //UpdatePaymentRequest
                List<int> paymentRequests = Utilities.Utilities.getPayRequestIDs();
                PaymentRequest paymentRequest = Utilities.Utilities.getPayRequestWithID(Convert.ToInt32(r.Cells[0].Value));
                if (Utilities.Utilities.getPayRequestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Request.ApprovalStatus.Pending)
                {
                    paymentRequest.approvalStatus = Request.ApprovalStatus.Approved;
                    Utilities.Utilities.savePayRequestChangesToDB(paymentRequest);
                }
                else
                {
                    MessageBox.Show("You can only edit 'Pending' requests!");
                }
            }

            //reopens the screen to refresh/update the database on screen
            AdminPayApproval refresh = new AdminPayApproval();
            refresh.Show();
            this.Close();
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in payRequestsDGV.SelectedRows)
            {
                //UpdatePaymentRequest
                List<int> paymentRequests = Utilities.Utilities.getPayRequestIDs();
                PaymentRequest paymentRequest = Utilities.Utilities.getPayRequestWithID(Convert.ToInt32(r.Cells[0].Value));
                if (Utilities.Utilities.getPayRequestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Request.ApprovalStatus.Pending)
                {
                    paymentRequest.approvalStatus = Request.ApprovalStatus.Rejected;
                    Utilities.Utilities.savePayRequestChangesToDB(paymentRequest);
                }
                else
                {
                    MessageBox.Show("You can only edit 'Pending' requests!");
                }
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
