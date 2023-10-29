using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
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
    public partial class AdminEditEmployee : Form
    {
        private object? context;

        public AdminEditEmployee()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            WageWizardContext context = new WageWizardContext();
            var employees = context.Employees;
            employees.Load();
            dataGridViewEmployees.DataSource = employees.Local.ToBindingList();
            dataGridViewEmployees.Refresh();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            context = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewEmployees.SelectedCells[0].RowIndex;
            string empId = dataGridViewEmployees.Rows[selectedRow].Cells[0].Value.ToString();

            EmployeePICRequest employeePICRequest = new EmployeePICRequest(Convert.ToInt32(empId));
            employeePICRequest.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeEmployee_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
               "Are you sure you want to delete these employees?",
               "Confirm Employee Deletion?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in dataGridViewEmployees.SelectedRows)
                {
                    Employee employee1 = Utilities.Utilities.getEmployeeWithID(Convert.ToInt32(r.Cells[0].Value));
                    Utilities.Utilities.removeEmployeeFromDB(employee1);

                }
                //reopens the screen to refresh/update the database on screen
                AdminEditEmployee refresh = new AdminEditEmployee();
                refresh.Show();
                this.Close();
            }
            else
            {
                // User clicked 'No', do nothing
            }
        }
    }
}
