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
                                    employee.accountName,
                                    employee.bsb,
                                    employee.accountNumber,
                                    employee.paymentCurrencyCode,
                                    employee.hourlyRate,
                                    request.approvalStatus
                                }).ToList();
            leaveHistoryDGV.DataSource = filteredData;

            leaveHistoryDGV.Columns["id"].HeaderText = "Leave Request ID";
            leaveHistoryDGV.Columns["hours"].HeaderText = "Leave Amount Requested";
            leaveHistoryDGV.Columns["accumulatedLeave"].HeaderText = "Accumulated Leave Available";
            leaveHistoryDGV.Columns["leaveDescription"].HeaderText = "Leave Description";
            leaveHistoryDGV.Columns["accountName"].HeaderText = "Account Name";
            leaveHistoryDGV.Columns["bsb"].HeaderText = "Account BSB";
            leaveHistoryDGV.Columns["accountNumber"].HeaderText = "Account Number";
            leaveHistoryDGV.Columns["paymentCurrencyCode"].HeaderText = "Payment Currency";
            leaveHistoryDGV.Columns["hourlyRate"].HeaderText = "Hourly Rate";
            leaveHistoryDGV.Columns["approvalStatus"].HeaderText = "Approval Status";

            //Add Calculated Column called Total Pay
            DataGridViewColumn totalPayColumn = new DataGridViewTextBoxColumn();
            totalPayColumn.Name = "TotalPay";
            totalPayColumn.HeaderText = "Total Pay From Annual Leave";
            leaveHistoryDGV.Columns.Add(totalPayColumn);

            //Add Calculated Column called Tax Paid
            DataGridViewColumn taxPaidColumn = new DataGridViewTextBoxColumn();
            taxPaidColumn.Name = "TaxPaid";
            taxPaidColumn.HeaderText = "Tax Paid from Annual Leave";
            leaveHistoryDGV.Columns.Add(taxPaidColumn);

            //Add Calculated Column called Super Paid
            DataGridViewColumn superPaidColumn = new DataGridViewTextBoxColumn();
            superPaidColumn.Name = "SuperPaid";
            superPaidColumn.HeaderText = "Super Paid from Annual Leave";
            leaveHistoryDGV.Columns.Add(superPaidColumn);

            //Change Approve Column to be the last
            int lastIndex = leaveHistoryDGV.Columns.Count - 1;
            leaveHistoryDGV.Columns["accountName"].DisplayIndex = lastIndex;

            //Change Approve Column to be the last
            leaveHistoryDGV.Columns["bsb"].DisplayIndex = lastIndex;

            //Change Approve Column to be the last
            leaveHistoryDGV.Columns["accountNumber"].DisplayIndex = lastIndex;

            //Change Approve Column to be the last
            leaveHistoryDGV.Columns["paymentCurrencyCode"].DisplayIndex = lastIndex;

            //Change Approve Column to be the last
            leaveHistoryDGV.Columns["approvalStatus"].DisplayIndex = lastIndex;

            //Event Handler for calculations
            leaveHistoryDGV.CellFormatting += new DataGridViewCellFormattingEventHandler(payLeaveCellFormatting);

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

        private void payLeaveCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //Calculate the TotalPay, TaxPaid and SuperPaid columns
            //This must be grouped together, as TaxPaid and SuperPaid rely on TotalPay calculation
            if (leaveHistoryDGV.Columns[e.ColumnIndex].Name == "TotalPay")
            {
                // Get values from the current row, or from global
                double hours = Convert.ToDouble(leaveHistoryDGV.Rows[e.RowIndex].Cells["hours"].Value);
                double hourlyRate = Convert.ToDouble(leaveHistoryDGV.Rows[e.RowIndex].Cells["hourlyRate"].Value);
                double taxRate = Utilities.Utilities.getGlobalTaxRate();
                double superRate = Utilities.Utilities.getGlobalSuperAnnuationRate();
                double leaveRate = Utilities.Utilities.getGlobalLeaveRate();

                // Perform the calculation
                double totalPay = hours * hourlyRate;
                double taxPaid = totalPay * taxRate;
                double superPaid = totalPay * superRate;

                // Assign the calculated value to the cell
                e.Value = String.Format("{0:C2}", totalPay);
                e.FormattingApplied = true;

                leaveHistoryDGV.Rows[e.RowIndex].Cells["TaxPaid"].Value = String.Format("{0:C2}", taxPaid);
                leaveHistoryDGV.Rows[e.RowIndex].Cells["SuperPaid"].Value = String.Format("{0:C2}", superPaid);

            }
        }
    }
}
