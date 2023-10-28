﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wage_Wizard.Data;
using Wage_Wizard.Models;
using static Wage_Wizard.Models.Person;

namespace Wage_Wizard.Utilities
{
    public class TestUtilities
    {
        public static void UtilitiesTest() 
        {
            //######## Begin Testing Utilities - Persons ###############
            Console.WriteLine("Begin Testing Utilities - Persons");
            //getPersonCount
            Console.WriteLine($"Total Number of Persons = {Utilities.getPersonCount()}");
            //getPersonsIDs
            Console.WriteLine($"Begin Print of all ID's of People");
            List<int> peopleIDs = Utilities.getPersonsIDs();
            int counter = 0;
            foreach ( int personID in peopleIDs )
            {
                counter++;
                Console.WriteLine($"\t {counter} : {personID}");
            }

            //######## Begin Testing Utilities - Universal ###############
            //isValidID
            Console.WriteLine("\nBegin Testing Utilities - Universal");
            Console.WriteLine($"The id 99 should return False and returned {Utilities.isValidID(99).ToString()}");
            Console.WriteLine($"The id {peopleIDs.Last()} should return True and returned {Utilities.isValidID(peopleIDs.Last()).ToString()}");
            
            //isValidCredentials
            Console.WriteLine($"The credentials id {peopleIDs.First()} and password password1 should return True and returned {Utilities.isValidCredentials(peopleIDs.First(), "password1").ToString()}");
            Console.WriteLine($"The credentials id {peopleIDs.First()} and password abc123 should return False and returned {Utilities.isValidCredentials(peopleIDs.First(), "abc123").ToString()}");

            //######## Begin Testing Utilities - Administrators ###############
            //getAdministratorCount
            Console.WriteLine("\nBegin Testing Utilities - Administrators");
            Console.WriteLine($"Total Number of Administrators = {Utilities.getAdministratorCount()}");
            //getAdministratorCount
            Console.WriteLine($"Total Number of Persons = {Utilities.getAdministratorCount()}");
            //getAdministratorsIDs
            Console.WriteLine($"Begin Print of all ID's of Admins");
            //getAdministratorsIDs
            List<int> adminIDs = Utilities.getAdministratorsIDs();
            counter = 0;
            foreach (int adminID in adminIDs)
            {
                counter++;
                Console.WriteLine($"\t {counter} : {adminID}");
            }

            //isAdministrator
            Console.WriteLine($"The id {peopleIDs.First()} and should return True and returned {Utilities.isAdministrator(peopleIDs.First()).ToString()}");
            Console.WriteLine($"The id {peopleIDs.Last()} and should return False and returned {Utilities.isAdministrator(peopleIDs.Last()).ToString()}");

            Console.WriteLine($"The admin object returned is: {Utilities.getAdministratorWithID(adminIDs.First()).GetPersonFullName()}");

            //addAdministratorToDB
            Administrator testAdmin = new Administrator("testAdminPass", Title.Ms, "Emily", "Williams", "emily.williams@example.com", "1985-12-12", 0412345678, 321, "Sixth Ave", "Sydney", "Sydney", "NSW", "Australia");
            Console.WriteLine("Attempting to create an administrator.");
            Utilities.addAdministratorToDB(testAdmin);
            Console.WriteLine($"ID of new admin is: {testAdmin.id}");

            //removeAdministratorFromDB
            Console.WriteLine("Attempting to delete an administrator.");
            int adminTempID = testAdmin.id;
            Utilities.removeAdministratorFromDB(testAdmin);
            Console.WriteLine($"The id {adminTempID} should return False and returned {Utilities.isAdministrator(adminTempID).ToString()}");


            //######## Begin Testing Utilities - Employees ###############
            //getEmployeeCount
            Console.WriteLine("\nBegin Testing Utilities - Employees");
            Console.WriteLine($"Total Number of Employees = {Utilities.getEmployeeCount()}");
            //getEmployeeIDs
            Console.WriteLine($"Begin Print of all ID's of Employees");
            //getAdministratorsIDs
            List<int> employeeIDs = Utilities.getEmployeeIDs();
            counter = 0;
            foreach (int employeeID in employeeIDs)
            {
                counter++;
                Console.WriteLine($"\t {counter} : {employeeID}");
            }

            //isEmployee
            Console.WriteLine($"The id {peopleIDs.Last()} and should return True and returned {Utilities.isEmployee(peopleIDs.Last()).ToString()}");
            Console.WriteLine($"The id {peopleIDs.First()} and should return False and returned {Utilities.isEmployee(peopleIDs.First()).ToString()}");
            
            //getEmployeeWithID
            Console.WriteLine($"The employee object returned is: {Utilities.getEmployeeWithID(employeeIDs.Last()).GetPersonFullName()}");

            //addEmployeeToDB
            Employee testEmployee = new Employee(123458, "Chuck's Account", 78901236, 35, 876543210, "AUD", "passwordChuck", Title.Mr, "Chuck", "Williams", "chuck.williams@example.com", "1982-03-03", 0412345673, 103, "3rd St", "Suburb3", "Brisbane", "QLD", "Australia");

            //Utilities.addEmployeeToDB(testEmployee);
            testEmployee.hourlyRate = 1000;            

            Console.WriteLine($"ID of new employee is: {testEmployee.id}");
            Utilities.saveEmployeeChangesToDB(testEmployee);
            Console.WriteLine($"chucks new hourly rate is {testEmployee.hourlyRate}");

            //removeAdministratorFromDB
            Console.WriteLine("Attempting to delete an employee.");
            int employeeTempID = testEmployee.id;
            Utilities.removeEmployeeFromDB(testEmployee);
            Console.WriteLine($"The id {employeeTempID} should return False and returned {Utilities.isEmployee(employeeTempID).ToString()}");
        }


    }
}