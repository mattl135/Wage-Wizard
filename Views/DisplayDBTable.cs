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

namespace Wage_Wizard.Views
{
    public partial class DisplayDBTable : Form
    {
        private object? dbContext;

        public DisplayDBTable()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            WageWizardContext context = new WageWizardContext();
            dbContext = context;
            var admins = context.Administrators;
            var employees = context.Employees;
            admins.Load();
            employees.Load();
            dataGridViewAdmins.DataSource = admins.Local.ToBindingList();
            dataGridViewEmployees.DataSource = employees.Local.ToBindingList();
            dataGridViewAdmins.Refresh();
            dataGridViewEmployees.Refresh();
            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dbContext = null;
        }
    }
}
