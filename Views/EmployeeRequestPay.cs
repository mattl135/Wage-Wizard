using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wage_Wizard.Views
{
    public partial class EmployeeRequestPay : Form
    {
        public EmployeeRequestPay()
        {
            InitializeComponent();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void calcTotalHours()
        {
            TotalHoursDisplay.Text = Convert.ToString(MonHours.Value + TueHours.Value + WedHours.Value + ThuHours.Value + FriHours.Value);
        }

        private void MonHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotalHours();
        }

        private void TueHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotalHours();
        }

        private void WedHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotalHours();
        }

        private void ThuHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotalHours();
        }

        private void FriHours_ValueChanged(object sender, EventArgs e)
        {
            calcTotalHours();
        }
    }
}
