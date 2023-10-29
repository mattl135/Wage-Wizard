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
