using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wage_Wizard.Models;

namespace Wage_Wizard.Data
{
    public class WageWizardDBTest
    {
        private static double dummyGlobalTaxRate = 50;
        private static double dummyGlobalSuperAnnuationRate = 25.23;
        private static double dummyGlobalLeaveRate = 150.55;
        private static int incrementAmount = 100;

        public static void dbTestCRUD(WageWizardContext context)
        {
            Console.WriteLine("-Begin Create and Save Test-");
            CreateAndSaveTest(context);
            Console.WriteLine("-End Create and Save Test-");

            Console.WriteLine("-Begin Read From DB Test-");
            ReadFromDBTest(context);
            Console.WriteLine("-End Read From DB Test-");

            Console.WriteLine("-Begin Edit DB Test-");
            EditDBTest(context);
            Console.WriteLine("-End Edit DB Test-");

            Console.WriteLine("-Begin Verify Edit DB Test-");
            VerifyIncreasedGlobalSettings(context);
            Console.WriteLine("-End Verify Edit DB Test-");
            
            Console.WriteLine("-Begin Delete DB Test-");
            DeleteGlobalSettings(context);
            Console.WriteLine("-End Delete DB Test-");

            Console.WriteLine("-Begin Verify Delete DB Test-");
            VerifyGlobalSettingsDeletion(context);
            Console.WriteLine("-End Verify Delete DB Test-");
        }

        public static void CreateAndSaveTest(WageWizardContext context)
        {
            // Try to fetch the GlobalSettings object
            // If an object can not be found, null is returned
            var globalSettings = context.GlobalSettings.FirstOrDefault();

            if (globalSettings != null)
            {
                Console.WriteLine("Global Settings already exists in the database - Rewritting values.");
                // Update the properties if the object exists
                globalSettings.globalTaxRate = dummyGlobalTaxRate;
                globalSettings.globalSuperAnnuationRate = dummyGlobalSuperAnnuationRate;
                globalSettings.globalLeaveRate = dummyGlobalLeaveRate;
            }
            else
            {
                Console.WriteLine("No Global Settings found. Attempting to create and save new instance of Global Settings.");
                // Create a new GlobalSettings object if it doesn't exist
                globalSettings = new GlobalSettings();
                globalSettings.globalTaxRate = dummyGlobalTaxRate;
                globalSettings.globalSuperAnnuationRate = dummyGlobalSuperAnnuationRate;
                globalSettings.globalLeaveRate = dummyGlobalLeaveRate;
                context.GlobalSettings.Add(globalSettings);
            }
            
            // Save changes to the database
            context.SaveChanges();
        }

        public static void ReadFromDBTest(WageWizardContext context)
        {
            // Try to fetch the GlobalSettings object
            var globalSettings = context.GlobalSettings.FirstOrDefault();

            if (globalSettings != null)
            {

                // Check if the values are as expected
                if (globalSettings.globalTaxRate == dummyGlobalTaxRate &&
                    globalSettings.globalSuperAnnuationRate == dummyGlobalSuperAnnuationRate &&
                    globalSettings.globalLeaveRate == dummyGlobalLeaveRate)
                {
                    Console.WriteLine("GlobalSettings values are as expected.");
                }
                else
                {
                    Console.WriteLine("GlobalSettings values are NOT as expected.");
                    Console.WriteLine($"Expected Tax Rate: {dummyGlobalTaxRate}, Actual: {globalSettings.globalTaxRate}");
                    Console.WriteLine($"Expected Super Rate: {dummyGlobalSuperAnnuationRate}, Actual: {globalSettings.globalSuperAnnuationRate}");
                    Console.WriteLine($"Expected Leave Rate: {dummyGlobalLeaveRate}, Actual: {globalSettings.globalLeaveRate}");
                }
            }
            else
            {
                Console.WriteLine("GlobalSettings object does not exist in the database.");
            }
        }

        public static void EditDBTest(WageWizardContext context)
        {
            // Try to fetch the GlobalSettings object
            var globalSettings = context.GlobalSettings.FirstOrDefault();

            if (globalSettings != null)
            {
                // Increase the values by incrementAmount
                globalSettings.globalTaxRate += incrementAmount;
                globalSettings.globalSuperAnnuationRate += incrementAmount;
                globalSettings.globalLeaveRate += incrementAmount;

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Successfully increased GlobalSettings values by 100.");
            }
            else
            {
                Console.WriteLine("GlobalSettings object does not exist in the database.");
            }
        }

        public static void VerifyIncreasedGlobalSettings(WageWizardContext context)
        {
            // Try to fetch the GlobalSettings object
            var globalSettings = context.GlobalSettings.FirstOrDefault();

            if (globalSettings != null)
            {
                // Expected increased values
                double expectedIncreasedTaxRate = dummyGlobalTaxRate + incrementAmount;  // Replace with the expected increased value
                double expectedIncreasedSuperRate = dummyGlobalSuperAnnuationRate + incrementAmount;  // Replace with the expected increased value
                double expectedIncreasedLeaveRate = dummyGlobalLeaveRate + incrementAmount;  // Replace with the expected increased value

                // Check if the values are as expected
                if (globalSettings.globalTaxRate == expectedIncreasedTaxRate &&
                    globalSettings.globalSuperAnnuationRate == expectedIncreasedSuperRate &&
                    globalSettings.globalLeaveRate == expectedIncreasedLeaveRate)
                {
                    Console.WriteLine("GlobalSettings values have been successfully increased by 100.");
                }
                else
                {
                    Console.WriteLine("GlobalSettings values have NOT been successfully increased by 100.");
                    Console.WriteLine($"Expected Increased Tax Rate: {expectedIncreasedTaxRate}, Actual: {globalSettings.globalTaxRate}");
                    Console.WriteLine($"Expected Increased Super Rate: {expectedIncreasedSuperRate}, Actual: {globalSettings.globalSuperAnnuationRate}");
                    Console.WriteLine($"Expected Increased Leave Rate: {expectedIncreasedLeaveRate}, Actual: {globalSettings.globalLeaveRate}");
                }
            }
            else
            {
                Console.WriteLine("GlobalSettings object does not exist in the database.");
            }
        }

        public static void DeleteGlobalSettings(WageWizardContext context)
        {
            // Try to fetch the GlobalSettings object
            var globalSettings = context.GlobalSettings.FirstOrDefault();

            if (globalSettings != null)
            {
                // Remove the object from the database
                context.GlobalSettings.Remove(globalSettings);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Successfully deleted GlobalSettings object from the database.");
            }
            else
            {
                Console.WriteLine("GlobalSettings object does not exist in the database.");
            }
        }

        public static void VerifyGlobalSettingsDeletion(WageWizardContext context)
        {
            // Try to fetch the GlobalSettings object
            var globalSettings = context.GlobalSettings.FirstOrDefault();

            if (globalSettings == null)
            {
                Console.WriteLine("GlobalSettings object has been successfully deleted from the database.");
            }
            else
            {
                Console.WriteLine("GlobalSettings object still exists in the database.");
            }
        }
    }
}
