using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wage_Wizard.Models;

namespace Wage_Wizard.Views
{
    public partial class EmployeeRequestPay : Form
    {
        Employee currentUser = Utilities.Utilities.getEmployeeWithID(Utilities.Utilities.currentUserId);
        decimal sumOfHours;
        public EmployeeRequestPay()
        {
            InitializeComponent();
            PayRateDisplay.Text = "$" + Convert.ToString(currentUser.hourlyRate);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void calcTotal()
        {
            sumOfHours = MonHours.Value + TueHours.Value + WedHours.Value + ThuHours.Value + FriHours.Value;
            double totalPay = Convert.ToDouble(sumOfHours) * currentUser.hourlyRate;
            double totalSuper = totalPay * Utilities.Utilities.getGlobalSuperAnnuationRate();
            double totalTax = totalPay * Utilities.Utilities.getGlobalTaxRate();

            TotalHoursDisplay.Text = Convert.ToString(sumOfHours);
            TotalPayDisplay.Text = "$" + Convert.ToString(Math.Round(totalPay, 2));
            TotalSuperDisplay.Text = "$" + Convert.ToString(Math.Round(totalSuper, 2));
            TotalTaxDisplay.Text = "$" + Convert.ToString(Math.Round(totalTax, 2));
        }

        private void MonHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void TueHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void WedHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void ThuHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void FriHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotal();
        }

        private void RequestPayBtn_Click(object sender, EventArgs e)
        {
            //if there's no hours submitted, don't allow for a submission
            if (sumOfHours == 0)
            {
                MessageBox.Show("Cannot submit with no hours worked.", "Request Payment - Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //save request to DB
                PaymentRequest paymentRequest = new PaymentRequest(currentUser.id, Convert.ToDouble(sumOfHours));
                Utilities.Utilities.addPayRequestToDB(paymentRequest);
                MessageBox.Show("Request submitted. The request ID is " + paymentRequest.id, "Request Payment - Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
