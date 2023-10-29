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
            decimal sumOfHours = MonHours.Value + TueHours.Value + WedHours.Value + ThuHours.Value + FriHours.Value;
            double totalPay = Convert.ToDouble(sumOfHours) * currentUser.hourlyRate;
            TotalHoursDisplay.Text = Convert.ToString(sumOfHours);
            TotalPayDisplay.Text = "$" + Convert.ToString(totalPay);
            TotalSuperDisplay.Text = "$" + Convert.ToString(totalPay * Utilities.Utilities.getGlobalSuperAnnuationRate());
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
    }
}
