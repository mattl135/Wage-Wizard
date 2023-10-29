using System.Runtime.InteropServices;
using Wage_Wizard.Data;
using Wage_Wizard.Models;

namespace Wage_Wizard
{
   
    public static class Program
    {
        public static bool showConsole = false;
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
            //Test if program can connect to a cloud database before begining the program.
            // This will open a console window if set to true
            if (showConsole){ AllocConsole();}
            try
            {
                if (Utilities.Utilities.CanConnectToCloudDB())
                {
                    WageWizardContext.useProductionDB = true;
                }
                else
                {
                    Console.WriteLine("Unable to connect to cloud database");
                    MessageBox.Show("An error occured when attempting to connect to cloud storage.\nApplication will attempt to use localDB.", "Connection Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                    WageWizardContext.useProductionDB = false;
                }

                //Create the Database context
                using WageWizardContext context = new WageWizardContext();

                // This will open a console window if set to true
                if (showConsole) 
                { 
                    AllocConsole();
                    try
                    {
                        WageWizardDBPopulate.PopulateDB(context);
                    }
                    catch (Exception e)
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
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Unable to connect to database\n{ex.Message}");
                MessageBox.Show($"An error occured when attempting to connect to storage.\n{ex.Message}", "Connection Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                WageWizardContext.useProductionDB = false;
            }
            

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}