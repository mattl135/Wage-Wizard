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
            DataGridViewColumn calculatedColumn = new DataGridViewTextBoxColumn();
            calculatedColumn.Name = "TotalPay";
            calculatedColumn.HeaderText = "Total Pay";
            payHistoryDGV.Columns.Add(calculatedColumn);

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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payHistoryDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (payHistoryDGV.Columns[e.ColumnIndex].Name == "TotalPay")
            {
                // Get the values of 'hours' and 'hourlyRate' from the current row
                double hours = Convert.ToDouble(payHistoryDGV.Rows[e.RowIndex].Cells["hours"].Value);
                double hourlyRate = Convert.ToDouble(payHistoryDGV.Rows[e.RowIndex].Cells["hourlyRate"].Value);

                // Perform the calculation
                double totalPay = hours * hourlyRate;

                // Assign the calculated value to the cell
                e.Value = String.Format("{0:C2}", totalPay);
                e.FormattingApplied = true;
            }
        }
    }
}

