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
    public partial class AdminPayHistory : Form
    {
        private object? dbContext;

        public AdminPayHistory()
        {
            InitializeComponent();
        }

        //Runs commands to create and display the database when the screen loads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using WageWizardContext context = new WageWizardContext();

            var payRequests = context.PaymentRequests;
            var employees = context.Employees;
            var persons = context.Persons;

            var filteredData = (from request in payRequests
                                join employee in employees on request.employeeID equals employee.id
                                join person in persons on employee.id equals person.id
                                select new
                                {
                                    request.id,
                                    request.employeeID,
                                    person.fName,
                                    person.lName,
                                    request.hours,
                                    employee.hourlyRate,
                                    request.approvalStatus
                                }).ToList();

            payHistoryDGV.DataSource = filteredData;
            payHistoryDGV.DataSource = filteredData;
            payHistoryDGV.Columns["id"].HeaderText = "Pay Request ID";
            payHistoryDGV.Columns["employeeID"].HeaderText = "Employee ID";
            payHistoryDGV.Columns["fName"].HeaderText = "First Name";
            payHistoryDGV.Columns["lName"].HeaderText = "Last Name";
            payHistoryDGV.Columns["hours"].HeaderText = "Hourly Rate";
            payHistoryDGV.Columns["hourlyRate"].HeaderText = "Hourly Rate";
            payHistoryDGV.Columns["approvalStatus"].HeaderText = "Approval Status";

            //Add Calculated Column called Total Pay
            DataGridViewColumn totalPayColumn = new DataGridViewTextBoxColumn();
            totalPayColumn.Name = "TotalPay";
            totalPayColumn.HeaderText = "Total Pay";
            payHistoryDGV.Columns.Add(totalPayColumn);

            //Add Calculated Column called Tax Paid
            DataGridViewColumn taxPaidColumn = new DataGridViewTextBoxColumn();
            taxPaidColumn.Name = "TaxPaid";
            taxPaidColumn.HeaderText = "Tax Paid";
            payHistoryDGV.Columns.Add(taxPaidColumn);

            //Add Calculated Column called Super Paid
            DataGridViewColumn superPaidColumn = new DataGridViewTextBoxColumn();
            superPaidColumn.Name = "SuperPaid";
            superPaidColumn.HeaderText = "Super Paid";
            payHistoryDGV.Columns.Add(superPaidColumn);

            //Change Approve Column to be the last
            int lastIndex = payHistoryDGV.Columns.Count - 1;
            payHistoryDGV.Columns["approvalStatus"].DisplayIndex = lastIndex;

            //Event Handler for calculations
            payHistoryDGV.CellFormatting += new DataGridViewCellFormattingEventHandler(payHistoryDGV_CellFormatting);

            //Refresh to load data
            payHistoryDGV.Refresh();

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

        private void payHistoryDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            //Calculate the TotalPay, TaxPaid and SuperPaid columns
            //This must be grouped together, as TaxPaid and SuperPaid rely on TotalPay calculation
            if (payHistoryDGV.Columns[e.ColumnIndex].Name == "TotalPay")
            {
                // Get values from the current row, or from global
                double hours = Convert.ToDouble(payHistoryDGV.Rows[e.RowIndex].Cells["hours"].Value);
                double hourlyRate = Convert.ToDouble(payHistoryDGV.Rows[e.RowIndex].Cells["hourlyRate"].Value);
                double taxRate = Utilities.Utilities.getGlobalTaxRate();
                double superRate = Utilities.Utilities.getGlobalSuperAnnuationRate();

                // Perform the calculation
                double totalPay = hours * hourlyRate;
                double taxPaid = totalPay * taxRate;
                double superPaid = totalPay * superRate;

                // Assign the calculated value to the cell
                e.Value = String.Format("{0:C2}", totalPay);
                e.FormattingApplied = true;

                payHistoryDGV.Rows[e.RowIndex].Cells["TaxPaid"].Value = String.Format("{0:C2}", taxPaid);
                payHistoryDGV.Rows[e.RowIndex].Cells["SuperPaid"].Value = String.Format("{0:C2}", superPaid);

            }
        }
    }
}
