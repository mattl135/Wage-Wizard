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
            var payRequests = context.PaymentRequests;
            var employees = context.Employees;
            var persons = context.Persons;
            /*var filteredData = (from request in payRequests
                                where request.approvalStatus == Request.ApprovalStatus.Pending
                                select request).ToList();*/

            var filteredData = (from request in payRequests
                                join employee in employees on request.employeeID equals employee.id
                                join person in persons on employee.id equals person.id
                                where request.approvalStatus == Request.ApprovalStatus.Pending
                                select new
                                {
                                    request.id,
                                    request.employeeID,
                                    request.hours,
                                    person.fName,
                                    person.lName,
                                    employee.hourlyRate,
                                    request.approvalStatus
                                }).ToList();

            payRequestsDGV.DataSource = filteredData;
            payRequestsDGV.Refresh();

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
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to approve these payment requests?",
                "Confirm Payment Request Approval?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
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
            else
            {
                // User clicked 'No', do nothing
            }
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to deny these payment requests?",
                "Confirm Payment Request Rejection?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
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
            else
            {
                // User clicked 'No', do nothing
            }
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
