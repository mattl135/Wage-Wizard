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
    public partial class GlobalSettingsMenu : Form
    {
        public GlobalSettingsMenu()
        {
            InitializeComponent();
            /*            globalTaxRateNumericField.CenterVertically();
                        GlobalLeaveRateDescriptionLabel.CenterVertically();
                        GlobalSuperRateDescriptionLabel.CenterVertically();
                        GlobalTaxRateDescriptionLabel.CenterVertically();
                        GlobalLeaveRateLabel.CenterVertically();
                        GlobalSuperAnnuationLabel.CenterVertically();
                        GlobalTaxRateLabel.CenterVertically();
                        exitBtn.CenterVertically();
                        Header.CenterVertically();
                        globalSuperRateNumericField.CenterVertically();
                        globalLeaveRateNumericField.CenterVertically();
                        Subheader.CenterVertically();*/
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Attempting to save changes to the Global settings to Database");
            Utilities.Utilities.setGlobalLeaveRate(Convert.ToDouble(globalLeaveRateNumericField.Value) / 100);
            Utilities.Utilities.setGlobalTaxRate(Convert.ToDouble(globalTaxRateNumericField.Value) / 100);
            Utilities.Utilities.setGlobalSuperAnnuationRate(Convert.ToDouble(globalSuperRateNumericField.Value) / 100);
            this.Hide();
        }

        private void GlobalSettings_Load(object sender, EventArgs e)
        {
            globalTaxRateNumericField.Value = Convert.ToDecimal(Utilities.Utilities.getGlobalTaxRate() * 100);
            globalSuperRateNumericField.Value = Convert.ToDecimal(Utilities.Utilities.getGlobalSuperAnnuationRate() * 100);
            globalLeaveRateNumericField.Value = Convert.ToDecimal(Utilities.Utilities.getGlobalLeaveRate() * 100);
        }

        private void ResetDefaultValuesBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
               "Are you sure you want to reset values to default?",
               "Reset to Default",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                Console.WriteLine("User Clicked Yes - Changing values to default");

                // Reset values to default here
                Utilities.Utilities.setGlobalLeaveRate(0.15); //15% leave rate
                Utilities.Utilities.setGlobalTaxRate(0.2); //20% tax rate
                Utilities.Utilities.setGlobalSuperAnnuationRate(0.1); //10% super rate

                globalTaxRateNumericField.Value = Convert.ToDecimal(Utilities.Utilities.getGlobalTaxRate() * 100);
                globalSuperRateNumericField.Value = Convert.ToDecimal(Utilities.Utilities.getGlobalSuperAnnuationRate() * 100);
                globalLeaveRateNumericField.Value = Convert.ToDecimal(Utilities.Utilities.getGlobalLeaveRate() * 100);
            }
            else
            {
                // User clicked 'No', do nothing
                Console.WriteLine("User Clicked No - No action");
            }
        }
    }
}
