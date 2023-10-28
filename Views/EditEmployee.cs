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

namespace Wage_Wizard.Views
{
    public partial class EditEmployee : Form
    {
        private object? context;

        public EditEmployee()
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
            int columnIndex = dataGridViewEmployees.CurrentCell.ColumnIndex;
            string cellValue = dataGridViewEmployees.Rows[selectedRow].Cells[columnIndex].Value.ToString();

            MessageBox.Show($"You clicked: {cellValue}", "Clicked Value");
        }
    }
}
