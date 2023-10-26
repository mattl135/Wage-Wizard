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
            
            // This will test if the database can be written or not.
            try
            {
                WageWizardDBTest.dbTestCRUD(context);
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.Message, "Database CRUD Test Failed");
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}