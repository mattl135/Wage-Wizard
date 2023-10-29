using System.Runtime.InteropServices;
using Wage_Wizard.Data;
using Wage_Wizard.Models;

namespace Wage_Wizard
{
   
    public static class Program
    {
        public static bool showConsole = true;
        //======Gather Resources to Display the Console======//
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //==================================================//



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Create the Database context
            using WageWizardContext context = new WageWizardContext();

            // This will open a console window if set to true
            if (showConsole) { AllocConsole(); } 

            try
            {
                WageWizardDBPopulate.PopulateDB(context);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.Message, "An error occured when attempting to populate the database",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
            }

            if (showConsole)
            {
                Utilities.TestUtilities.UtilitiesTest();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}