using Azure.Core;
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
    public partial class AdminPICRequest : Form
    {
        private object? dbContext;
        public AdminPICRequest()
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
                                where request.approvalStatus == Models.Request.ApprovalStatus.Pending
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
            PICRequestsDGV.DataSource = filteredData;

            PICRequestsDGV.Columns["id"].HeaderText = "Change Request ID";
            PICRequestsDGV.Columns["approvalStatus"].HeaderText = "Approval Status";
            PICRequestsDGV.Columns["employeeID"].HeaderText = "Employee ID";
            PICRequestsDGV.Columns["updatedPassword"].HeaderText = "New Password";
            PICRequestsDGV.Columns["updatedTitle"].HeaderText = "New Title";
            PICRequestsDGV.Columns["updatedFName"].HeaderText = "New First Name";
            PICRequestsDGV.Columns["updatedLName"].HeaderText = "New Last Name";
            PICRequestsDGV.Columns["updatedEmailAddress"].HeaderText = "New Email Address";
            PICRequestsDGV.Columns["updatedDOB"].HeaderText = "New Date of Birth";
            PICRequestsDGV.Columns["updatedMobileNumber"].HeaderText = "New Mobile Number";
            PICRequestsDGV.Columns["updatedStreetNumber"].HeaderText = "New Street Number";
            PICRequestsDGV.Columns["updatedStreetName"].HeaderText = "New Street Name";
            PICRequestsDGV.Columns["updatedSuburb"].HeaderText = "New Suburb";
            PICRequestsDGV.Columns["updatedCity"].HeaderText = "New City";
            PICRequestsDGV.Columns["updatedState"].HeaderText = "New State";
            PICRequestsDGV.Columns["updatedCountry"].HeaderText = "New Country";
            PICRequestsDGV.Columns["updatedBSB"].HeaderText = "New BSB";
            PICRequestsDGV.Columns["updatedAccountName"].HeaderText = "New Account Name";
            PICRequestsDGV.Columns["updatedAccountNumber"].HeaderText = "New Account Number";
            PICRequestsDGV.Columns["updatedTaxFileNumber"].HeaderText = "New Tax File Number";
            PICRequestsDGV.Columns["updatedPaymentCurrencyCode"].HeaderText = "New Payment Currency Code";

            //Refresh to load data
            PICRequestsDGV.Refresh();

            //Forces the screen to open the window in the topleft of the screen
            int x = Screen.PrimaryScreen.WorkingArea.Top;
            int y = Screen.PrimaryScreen.WorkingArea.Left;
            this.Location = new Point(x, y);
        }

        //Exit button to close menu
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to Approve these Personal Information Change Requests?",
                "Confirm Personal Information Change Request Approval?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in PICRequestsDGV.SelectedRows)
                {
                    PersonChangeRequest personChangeRequest = Utilities.Utilities.getPersonChangeReqestWithID(Convert.ToInt32(r.Cells[0].Value));
                    //Checks if the approval status is pending to prevent users from editing already actioned requests
                    if (Utilities.Utilities.getPersonChangeReqestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Models.Request.ApprovalStatus.Pending)
                    {
                        personChangeRequest.approvalStatus = Models.Request.ApprovalStatus.Approved;
                        Utilities.Utilities.savePersonChangeRequestsChangesToDB(personChangeRequest);
                        Employee employee = Utilities.Utilities.getEmployeeWithID(personChangeRequest.employeeID);
                        employee.updatePersonalInformationFromPersonChangeRequest(personChangeRequest.id);
                        Thread.Sleep(1000);
                        MessageBox.Show($"The personal information change request was succesfully processed", "Request submitted successfully",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                }
                //reopens the screen to refresh/update the database on screen
                AdminPICRequest refresh = new AdminPICRequest();
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
                "Are you sure you want to Reject these Personal Information Change Requests?",
                "Confirm Personal Information Change Request Rejection?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,  // This sets the icon to a question mark
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in PICRequestsDGV.SelectedRows)
                {
                    PersonChangeRequest personChangeRequest = Utilities.Utilities.getPersonChangeReqestWithID(Convert.ToInt32(r.Cells[0].Value));

                    //Checks if the approval status is pending to prevent users from editing already actioned requests
                    if (Utilities.Utilities.getPersonChangeReqestWithID(Convert.ToInt32(r.Cells[0].Value)).approvalStatus == Models.Request.ApprovalStatus.Pending)
                    {
                        personChangeRequest.approvalStatus = Models.Request.ApprovalStatus.Rejected;
                        Utilities.Utilities.savePersonChangeRequestsChangesToDB(personChangeRequest);
                    }
                    else
                    {
                        MessageBox.Show("You can only edit 'Pending' Requests!");
                    }

                    //reopens the screen to refresh/update the database on screen
                    AdminPICRequest refresh = new AdminPICRequest();
                    refresh.Show();
                    this.Close();
                }
            }
            else
            {
                // User clicked 'No', do nothing
            }
        }
    }
}
