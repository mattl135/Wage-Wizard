using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wage_Wizard.Models.Person;
using Wage_Wizard.Models;

namespace Wage_Wizard.Data
{
    //This class is used to populate dummy data into the database
    public class WageWizardDBPopulate
    {
        public static void PopulateDB(WageWizardContext context)
        {
            Console.WriteLine("-Begin Verify Administrators Count / Populate Administrators -");
            PopulateAdministrators(context);
            Console.WriteLine("-End Verify Administrators Count / Populate Administrators -\n");

            Console.WriteLine("-Begin Verify Employee Count / Populate Employee -");
            PopulateEmployees(context);
            Console.WriteLine("-End Verify Employee Count / Populate Employee -\n");
        }

        public static void PopulateAdministrators(WageWizardContext context) 
        {
            var administrators = context.Administrators;
            if (administrators.Count() == 0)
            {
                Console.WriteLine("No Administrators exist in the table. Attempting to Populate");
                Administrator admin1 = new Administrator("password1", Title.Mr, "John", "Doe", "john.doe@example.com", "1980-01-01", 0412345678, 123, "Main St", "Sydney", "Sydney", "NSW", "Australia");
                Administrator admin2 = new Administrator("password2", Title.Mrs, "Jane", "Smith", "jane.smith@example.com", "1985-02-02", 0412345679, 124, "Second St", "Melbourne", "Melbourne", "VIC", "Australia");
                Administrator admin3 = new Administrator("password3", Title.Dr, "Emily", "Brown", "emily.brown@example.com", "1990-03-03", 0412345680, 125, "Third St", "Brisbane", "Brisbane", "QLD", "Australia");
                Administrator admin4 = new Administrator("password4", Title.Ms, "Alice", "Williams", "alice.williams@example.com", "1995-04-04", 0412345681, 126, "Fourth St", "Adelaide", "Adelaide", "SA", "Australia");
                Administrator admin5 = new Administrator("password5", Title.Mr, "David", "Johnson", "david.johnson@example.com", "2000-05-05", 0412345682, 127, "Fifth St", "Perth", "Perth", "WA", "Australia");
                administrators.AddRange(admin1, admin2, admin3, admin4, admin5);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"{administrators.Count()} Administrators already exist in the table. No need to populate.");
            }
        }

        public static void PopulateEmployees(WageWizardContext context)
        {
            var employees = context.Employees;
            if (employees.Count() == 0)
            {
                Console.WriteLine("No Employees exist in the table. Attempting to Populate");
                Employee employee1 = new Employee(123456, "John's Account", 78901234, 25, 123456789, "AUD", "password6", Title.Mr, "John", "Doe", "john.doe@example.com", "1990-01-01", 0412345671, 101, "1st St", "Suburb1", "Sydney", "NSW", "Australia");
                Employee employee2 = new Employee(123457, "Jane's Account", 78901235, 26, 123456790, "AUD", "password7", Title.Mrs, "Jane", "Smith", "jane.smith@example.com", "1991-02-02", 0412345672, 102, "2nd St", "Suburb2", "Melbourne", "VIC", "Australia");
                Employee employee3 = new Employee(123458, "Bob's Account", 78901236, 27, 123456791, "AUD", "password8", Title.Mr, "Bob", "Williams", "bob.williams@example.com", "1992-03-03", 0412345673, 103, "3rd St", "Suburb3", "Adelaide", "SA", "Australia");
                Employee employee4 = new Employee(123459, "Alice's Account", 78901237, 28, 123456792, "AUD", "password9", Title.Ms, "Alice", "Johnson", "alice.johnson@example.com", "1993-04-04", 0412345674, 104, "4th St", "Suburb4", "Perth", "WA", "Australia");
                Employee employee5 = new Employee(123460, "Tom's Account", 78901238, 29, 123456793, "AUD", "password10", Title.Mr, "Tom", "Brown", "tom.brown@example.com", "1994-05-05", 0412345675, 105, "5th St", "Suburb5", "Canberra", "ACT", "Australia");
                Employee employee6 = new Employee(123461, "Sara's Account", 78901239, 30, 123456794, "AUD", "password11", Title.Mrs, "Sara", "Davis", "sara.davis@example.com", "1995-06-06", 0412345676, 106, "6th St", "Suburb6", "Darwin", "NT", "Australia");
                Employee employee7 = new Employee(123462, "Mike's Account", 78901240, 31, 123456795, "AUD", "password12", Title.Mr, "Mike", "Miller", "mike.miller@example.com", "1996-07-07", 0412345677, 107, "7th St", "Suburb7", "Hobart", "TAS", "Australia");
                Employee employee8 = new Employee(123463, "Laura's Account", 78901241, 32, 123456796, "AUD", "password13", Title.Ms, "Laura", "Wilson", "laura.wilson@example.com", "1997-08-08", 0412345678, 108, "8th St", "Suburb8", "Sydney", "NSW", "Australia");
                Employee employee9 = new Employee(123464, "Steve's Account", 78901242, 33, 123456797, "AUD", "password14", Title.Mr, "Steve", "Moore", "steve.moore@example.com", "1998-09-09", 0412345679, 109, "9th St", "Suburb9", "Melbourne", "VIC", "Australia");
                Employee employee10 = new Employee(123465, "Karen's Account", 78901243, 34, 123456798, "AUD", "password15", Title.Mrs, "Karen", "Taylor", "karen.taylor@example.com", "1999-10-10", 0412345680, 110, "10th St", "Suburb10", "Brisbane", "QLD", "Australia");
                Employee employee11 = new Employee(123466, "James's Account", 78901244, 35, 123456799, "AUD", "password16", Title.Mr, "James", "Anderson", "james.anderson@example.com", "2000-11-11", 0412345681, 111, "11th St", "Suburb11", "Adelaide", "SA", "Australia");
                Employee employee12 = new Employee(123467, "Linda's Account", 78901245, 36, 123456800, "AUD", "password17", Title.Ms, "Linda", "Thomas", "linda.thomas@example.com", "2001-12-12", 0412345682, 112, "12th St", "Suburb12", "Perth", "WA", "Australia");
                Employee employee13 = new Employee(123468, "Brian's Account", 78901246, 37, 123456801, "AUD", "password18", Title.Mr, "Brian", "Jackson", "brian.jackson@example.com", "2002-01-13", 0412345683, 113, "13th St", "Suburb13", "Canberra", "ACT", "Australia");
                Employee employee14 = new Employee(123469, "Nancy's Account", 78901247, 38, 123456802, "AUD", "password19", Title.Mrs, "Nancy", "Harris", "nancy.harris@example.com", "2003-02-14", 0412345684, 114, "14th St", "Suburb14", "Darwin", "NT", "Australia");
                Employee employee15 = new Employee(123470, "Gary's Account", 78901248, 39, 123456803, "AUD", "password20", Title.Mr, "Gary", "Clark", "gary.clark@example.com", "2004-03-15", 0412345685, 115, "15th St", "Suburb15", "Hobart", "TAS", "Australia");
                employees.AddRange(employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10, employee11, employee12, employee13, employee14, employee15);
                context.SaveChanges();
            } else
            {
                Console.WriteLine($"{employees.Count()} Employees already exist in the table. No need to populate.");
            }
        }
/*
        public static List<Employee> SeedEmployees()
        {
            // List to hold Employee objects
            List<Employee> employees = new List<Employee>();

            // Common fields for Employee objects
            int commonBsb = 123456;
            string commonAccountName = "Employee Account";
            int commonAccountNumber = 78901234;
            int commonHourlyRate = 25;
            int commonTaxFileNumber = 123456789;

            // Create 15 Employee objects
            for (int i = 1; i <= 15; i++)
            {
                employees.Add(new Employee(
                    commonBsb,
                    commonAccountName,
                    commonAccountNumber,
                    commonHourlyRate,
                    commonTaxFileNumber,
                    "AUD",
                    //i + 100000, // ID starts from 6 to avoid conflict with Administrators
                    $"password{i + 5}",
                    Title.Mr,
                    $"FirstName{i}",
                    $"LastName{i}",
                    $"email{i}@example.com",
                    $"1990-01-{i.ToString("D2")}",
                    $"04123456{i + 10}",
                    100 + i,
                    $"{i}th St",
                    $"{i + 4}th Suburb",
                    "Sydney",
                    "NSW",
                    "Australia"
                ));
            }
            return employees;
        }*/
    }
}
