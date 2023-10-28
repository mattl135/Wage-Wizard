using Microsoft.VisualBasic.ApplicationServices;
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

        public static void addAdministratorToDB(Administrator administrator)
        {
            try
            {
                using WageWizardContext context = new WageWizardContext();
                var administrators = context.Administrators;
                administrators.Add(administrator);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }   
        }

        public static void saveAdministratorChangesToDB(Administrator administrator) //Confirmed
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                context.Administrators.Update(administrator);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        public static void removeAdministratorFromDB(Administrator administrator)
        {
            try
            {
                if (Utilities.isValidID(administrator.id) && Utilities.isAdministrator(administrator.id))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.Administrators.Remove(administrator);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void removeAdministratorFromDB(int administratorID)
        {
            try
            {
                if (Utilities.isValidID(administratorID) && Utilities.isAdministrator(administratorID))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.Administrators.Remove(getAdministratorWithID(administratorID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
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
            }
            catch (Exception ex)
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

        public static void addEmployeeToDB(Employee employee)
        {
            try
            {
                using WageWizardContext context = new WageWizardContext();
                var employees = context.Employees;
                employees.Add(employee);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void saveEmployeeChangesToDB(Employee employee) //Confirmed
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                context.Employees.Update(employee);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        public static void removeEmployeeFromDB(Employee employee)
        {
            try
            {
                if (Utilities.isValidID(employee.id) && Utilities.isEmployee(employee.id))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void removeEmployeeFromDB(int employeeeID)
        {
            try
            {
                if (Utilities.isValidID(employeeeID) && Utilities.isEmployee(employeeeID))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.Employees.Remove(getEmployeeWithID(employeeeID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
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
