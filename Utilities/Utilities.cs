using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wage_Wizard.Data;
using Wage_Wizard.Models;

namespace Wage_Wizard.Utilities
{
    public class Utilities
    {

        /********************Universal************************/

        public static bool isValidID(int userIDInput) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.Persons.Any(person => person.id == userIDInput);
        }

        public static bool isValidCredentials(int userIDInput, string passwordInput) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            if (isValidID(userIDInput))
            {
                Console.WriteLine("User ID is valid");
                // Check if there's any person with both the given userIDInput and passwordInput
                if (context.Persons.Any(person => person.id == userIDInput && person.password == passwordInput))
                {
                    Console.WriteLine("Password is valid");
                    return true;
                }
            }
            return false;
        }

        /*********************Administrators***********************/

        public static bool isAdministrator(Person unknownPerson)
        {
            using WageWizardContext context = new WageWizardContext();
            return context.Administrators.Any(person => person.id == unknownPerson.id);
        }
        public static bool isAdministrator(int userID) ////Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.Administrators.Any(person => person.id == userID);
        }

        public static int getAdministratorCount() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var administrators = context.Administrators;
            return administrators.Count();

        }
        public static Administrator? getAdministratorWithID(int userID) //Confirmed Working
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                var administrators = context.Administrators;
                var user = administrators.SingleOrDefault(p => p.id == userID);
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static List<int> getAdministratorsIDs() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var administrators = context.Administrators;
            List<int> adminIds = administrators.Select(admin => admin.id).ToList();
            return adminIds;
        }

        /*********************Employees***********************/
        public static Employee? getEmployeeWithID(int userID) //Confirmed Working
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                var employees = context.Employees;
                var user = employees.SingleOrDefault(p => p.id == userID);
                return user;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                return null;
            }
            
        }

        public static bool isEmployee(Person unknownPerson)
        {
            using WageWizardContext context = new WageWizardContext();
            return context.Employees.Any(person => person.id == unknownPerson.id);
        }

        public static bool isEmployee(int userID) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.Employees.Any(person => person.id == userID);
        }

        public static int getEmployeeCount() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var employees = context.Employees;
            return employees.Count();

        }

        public static List<int> getEmployeeIDs() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var employees = context.Employees;
            List<int> employeeIds = employees.Select(employee => employee.id).ToList();
            return employeeIds;
        }

        /*********************Persons***********************/

        public static int getPersonCount() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var persons = context.Persons;
            return persons.Count();

        }

        public static List<int> getPersonsIDs() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var employees = context.Persons;
            List<int> employeeIds = employees.Select(employee => employee.id).ToList();
            return employeeIds;
        }


    }
}
