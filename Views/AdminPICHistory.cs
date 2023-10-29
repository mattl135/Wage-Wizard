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
    public partial class AdminPICHistory : Form
    {
        private object? dbContext;
        public AdminPICHistory()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using WageWizardContext context = new WageWizardContext();
            var personChange = context.PersonChangeRequests;
            var employees = context.Employees;
            var persons = context.Persons;


            var filteredData = (from request in personChange
                                join employee in employees on request.employeeID equals employee.id
                                join person in persons on employee.id equals person.id
                                select new
                                {
                                    request.id,
                                    request.approvalStatus,
                                    request.employeeID,
                                    request.updatedPassword,
                                    request.updatedTitle,
                                    request.updatedFName,
                                    request.updatedLName,
                                    request.updatedEmailAddress,
                                    request.updatedDOB,
                                    request.updatedMobileNumber,
                                    request.updatedStreetNumber,
                                    request.updatedStreetName,
                                    request.updatedSuburb,
                                    request.updatedCity,
                                    request.updatedState,
                                    request.updatedCountry,
                                    request.updatedBSB,
                                    request.updatedAccountName,
                                    request.updatedAccountNumber,
                                    request.updatedTaxFileNumber,
                                    request.updatedPaymentCurrencyCode
                                }).ToList();
            PICHistoryDGV.DataSource = filteredData;

            PICHistoryDGV.Columns["id"].HeaderText = "Change Request ID";
            PICHistoryDGV.Columns["approvalStatus"].HeaderText = "Approval Status";
            PICHistoryDGV.Columns["employeeID"].HeaderText = "Employee ID";
            PICHistoryDGV.Columns["updatedPassword"].HeaderText = "New Password";
            PICHistoryDGV.Columns["updatedTitle"].HeaderText = "New Title";
            PICHistoryDGV.Columns["updatedFName"].HeaderText = "New First Name";
            PICHistoryDGV.Columns["updatedLName"].HeaderText = "New Last Name";
            PICHistoryDGV.Columns["updatedEmailAddress"].HeaderText = "New Email Address";
            PICHistoryDGV.Columns["updatedDOB"].HeaderText = "New Date of Birth";
            PICHistoryDGV.Columns["updatedMobileNumber"].HeaderText = "New Mobile Number";
            PICHistoryDGV.Columns["updatedStreetNumber"].HeaderText = "New Street Number";
            PICHistoryDGV.Columns["updatedStreetName"].HeaderText = "New Street Name";
            PICHistoryDGV.Columns["updatedSuburb"].HeaderText = "New Suburb";
            PICHistoryDGV.Columns["updatedCity"].HeaderText = "New City";
            PICHistoryDGV.Columns["updatedState"].HeaderText = "New State";
            PICHistoryDGV.Columns["updatedCountry"].HeaderText = "New Country";
            PICHistoryDGV.Columns["updatedBSB"].HeaderText = "New BSB";
            PICHistoryDGV.Columns["updatedAccountName"].HeaderText = "New Account Name";
            PICHistoryDGV.Columns["updatedAccountNumber"].HeaderText = "New Account Number";
            PICHistoryDGV.Columns["updatedTaxFileNumber"].HeaderText = "New Tax File Number";
            PICHistoryDGV.Columns["updatedPaymentCurrencyCode"].HeaderText = "New Payment Currency Code";

            //Refresh to load data
            PICHistoryDGV.Refresh();

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

        private void Header_Click(object sender, EventArgs e)
        {
        }
    }
}
