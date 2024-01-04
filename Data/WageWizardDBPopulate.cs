using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wage_Wizard.Models.Person;
using Wage_Wizard.Models;
using Wage_Wizard.Utilities;

namespace Wage_Wizard.Data
{
    //This class is used to populate dummy data into the database
    public class WageWizardDBPopulate
    {
        public static void PopulateDB(WageWizardContext context)
        {
            Console.WriteLine("- Begin Verify Administrators Count / Populate Administrators -");
            PopulateAdministrators(context);
            Console.WriteLine("- End Verify Administrators Count / Populate Administrators -\n");

            Console.WriteLine("- Begin Verify Employee Count / Populate Employee -");
            PopulateEmployees(context);
            Console.WriteLine("- End Verify Employee Count / Populate Employee -\n");

            Console.WriteLine("- Begin Verify Payment Requests Count / Populate Payment Requests -");
            PopulatePaymentRequests(context);
            Console.WriteLine("- Begin Verify Payment Requests Count / Populate Payment Requests -\n");

            Console.WriteLine("- Begin Verify Leave Requests Count / Populate Leave Requests -");
            PopulateLeaveRequests(context);
            Console.WriteLine("- End Verify Leave Requests Count / Populate Leave Requests -\n");

            Console.WriteLine("- Begin Verify Person Change Requests Count / Populate Person Change Requests -");
            PopulatePersonChangeRequests(context);
            Console.WriteLine("- End Verify Person Change Requests Count / Populate Person Change Requests -\n");

            Console.WriteLine("- Begin Verify Global Settings / Populate Global Settings -");
            PopulateGlobalSettings(context);
            Console.WriteLine("- End Verify Global Settings / Populate Global Settings -");

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
            }
            else
            {
                Console.WriteLine($"{employees.Count()} Employees already exist in the table. No need to populate.");
            }
        }

        public static void PopulatePaymentRequests(WageWizardContext context)
        {
            var paymentRequests = context.PaymentRequests;
            var Employees = context.Employees;
            if (paymentRequests.Count() == 0)
            {
                Console.WriteLine("No Payment Requests exist in the table. Attempting to Populate");

                List<int> employees = Utilities.Utilities.getEmployeeIDs();
                PaymentRequest paymentRequest1 = new PaymentRequest(employees[0], 15.53);
                PaymentRequest paymentRequest2 = new PaymentRequest(employees[0], 53.23);
                PaymentRequest paymentRequest3 = new PaymentRequest(employees[1], 83.63);
                PaymentRequest paymentRequest4 = new PaymentRequest(employees[2], 83.63);
                PaymentRequest paymentRequest5 = new PaymentRequest(employees[3], 25.20);
                PaymentRequest paymentRequest6 = new PaymentRequest(employees[3], 41.00);
                PaymentRequest paymentRequest7 = new PaymentRequest(employees[4], 32.50);
                PaymentRequest paymentRequest8 = new PaymentRequest(employees[4], 75.25);
                PaymentRequest paymentRequest9 = new PaymentRequest(employees[5], 18.00);
                PaymentRequest paymentRequest10 = new PaymentRequest(employees[5], 30.75);
                PaymentRequest paymentRequest11 = new PaymentRequest(employees[6], 44.23);
                PaymentRequest paymentRequest12 = new PaymentRequest(employees[6], 53.12);
                PaymentRequest paymentRequest13 = new PaymentRequest(employees[7], 21.98);
                PaymentRequest paymentRequest14 = new PaymentRequest(employees[7], 64.34);
                PaymentRequest paymentRequest15 = new PaymentRequest(employees[8], 39.12);
                PaymentRequest paymentRequest16 = new PaymentRequest(employees[8], 56.90);
                PaymentRequest paymentRequest17 = new PaymentRequest(employees[9], 72.25);
                PaymentRequest paymentRequest18 = new PaymentRequest(employees[9], 89.50);
                PaymentRequest paymentRequest19 = new PaymentRequest(employees[10], 20.75);
                PaymentRequest paymentRequest20 = new PaymentRequest(employees[10], 33.40);
                PaymentRequest paymentRequest21 = new PaymentRequest(employees[11], 27.90);
                PaymentRequest paymentRequest22 = new PaymentRequest(employees[11], 49.30);
                PaymentRequest paymentRequest23 = new PaymentRequest(employees[12], 60.25);
                PaymentRequest paymentRequest24 = new PaymentRequest(employees[12], 90.00);
                PaymentRequest paymentRequest25 = new PaymentRequest(employees[13], 42.55);
                PaymentRequest paymentRequest26 = new PaymentRequest(employees[13], 55.70);
                PaymentRequest paymentRequest27 = new PaymentRequest(employees[14], 38.90);
                PaymentRequest paymentRequest28 = new PaymentRequest(employees[14], 47.65);
                PaymentRequest paymentRequest29 = new PaymentRequest(employees[14], 62.20);
                PaymentRequest paymentRequest30 = new PaymentRequest(employees[14], 74.30);
                PaymentRequest paymentRequest31 = new PaymentRequest(employees[14], 20.15);
                PaymentRequest paymentRequest32 = new PaymentRequest(employees[14], 29.40);
                PaymentRequest paymentRequest33 = new PaymentRequest(employees[14], 15.65);
                PaymentRequest paymentRequest34 = new PaymentRequest(employees[14], 33.80);
                paymentRequests.AddRange(paymentRequest1, paymentRequest2, paymentRequest3, paymentRequest4,
                                        paymentRequest5, paymentRequest6, paymentRequest7, paymentRequest8,
                                        paymentRequest9, paymentRequest10, paymentRequest11, paymentRequest12,
                                        paymentRequest13, paymentRequest14, paymentRequest15, paymentRequest16,
                                        paymentRequest17, paymentRequest18, paymentRequest19, paymentRequest20,
                                        paymentRequest21, paymentRequest22, paymentRequest23, paymentRequest24,
                                        paymentRequest25, paymentRequest26, paymentRequest27, paymentRequest28,
                                        paymentRequest29, paymentRequest30, paymentRequest31, paymentRequest32,
                                        paymentRequest33, paymentRequest34);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"{paymentRequests.Count()} payment requests already exist in the table. No need to populate.");
            }
        }

        public static void PopulateLeaveRequests(WageWizardContext context)
        {
            var leaveRequests = context.LeaveRequests;
            if (leaveRequests.Count() == 0)
            {
                Console.WriteLine("No Leave Requests exist in the table. Attempting to Populate");

                List<int> employees = Utilities.Utilities.getEmployeeIDs();
                LeaveRequest leaveRequest1 = new LeaveRequest(employees[0], 15.53, "sick");
                LeaveRequest leaveRequest2 = new LeaveRequest(employees[1], 5.53, "Dr Appointment");
                LeaveRequest leaveRequest3 = new LeaveRequest(employees[1], 15.53, "Surgery");
                LeaveRequest leaveRequest4 = new LeaveRequest(employees[2], 8.00, "Vacation");
                LeaveRequest leaveRequest5 = new LeaveRequest(employees[2], 4.50, "Personal");
                LeaveRequest leaveRequest6 = new LeaveRequest(employees[3], 10.25, "Sick");
                LeaveRequest leaveRequest7 = new LeaveRequest(employees[3], 6.75, "Family Emergency");
                LeaveRequest leaveRequest8 = new LeaveRequest(employees[4], 12.00, "Maternity");
                LeaveRequest leaveRequest9 = new LeaveRequest(employees[4], 8.50, "Paternity");
                LeaveRequest leaveRequest10 = new LeaveRequest(employees[5], 7.25, "Sick");
                LeaveRequest leaveRequest11 = new LeaveRequest(employees[5], 3.00, "Vacation");
                LeaveRequest leaveRequest12 = new LeaveRequest(employees[6], 9.75, "Personal");
                LeaveRequest leaveRequest13 = new LeaveRequest(employees[6], 4.25, "Sick");
                LeaveRequest leaveRequest14 = new LeaveRequest(employees[7], 11.00, "Dr Appointment");
                LeaveRequest leaveRequest15 = new LeaveRequest(employees[7], 5.50, "Family Emergency");
                LeaveRequest leaveRequest16 = new LeaveRequest(employees[8], 14.25, "Vacation");
                LeaveRequest leaveRequest17 = new LeaveRequest(employees[8], 7.00, "Sick");
                LeaveRequest leaveRequest18 = new LeaveRequest(employees[9], 10.50, "Maternity");
                LeaveRequest leaveRequest19 = new LeaveRequest(employees[9], 6.75, "Paternity");
                LeaveRequest leaveRequest20 = new LeaveRequest(employees[10], 12.25, "Dr Appointment");
                LeaveRequest leaveRequest21 = new LeaveRequest(employees[10], 4.00, "Surgery");
                LeaveRequest leaveRequest22 = new LeaveRequest(employees[11], 8.25, "Vacation");
                LeaveRequest leaveRequest23 = new LeaveRequest(employees[11], 5.75, "Personal");
                LeaveRequest leaveRequest24 = new LeaveRequest(employees[12], 9.00, "Family Emergency");
                LeaveRequest leaveRequest25 = new LeaveRequest(employees[12], 4.25, "Sick");
                LeaveRequest leaveRequest26 = new LeaveRequest(employees[13], 7.50, "Vacation");
                LeaveRequest leaveRequest27 = new LeaveRequest(employees[13], 3.75, "Personal");
                LeaveRequest leaveRequest28 = new LeaveRequest(employees[14], 11.25, "Dr Appointment");
                LeaveRequest leaveRequest29 = new LeaveRequest(employees[14], 6.00, "Surgery");
                LeaveRequest leaveRequest30 = new LeaveRequest(employees[14], 9.25, "Family Emergency");
                LeaveRequest leaveRequest31 = new LeaveRequest(employees[14], 5.50, "Sick");
                LeaveRequest leaveRequest32 = new LeaveRequest(employees[14], 10.75, "Vacation");
                LeaveRequest leaveRequest33 = new LeaveRequest(employees[14], 4.25, "Personal");
                leaveRequests.AddRange(leaveRequest1, leaveRequest2, leaveRequest3, leaveRequest4,
                                        leaveRequest5, leaveRequest6, leaveRequest7, leaveRequest8,
                                        leaveRequest9, leaveRequest10, leaveRequest11, leaveRequest12,
                                        leaveRequest13, leaveRequest14, leaveRequest15, leaveRequest16,
                                        leaveRequest17, leaveRequest18, leaveRequest19, leaveRequest20,
                                        leaveRequest21, leaveRequest22, leaveRequest23, leaveRequest24,
                                        leaveRequest25, leaveRequest26, leaveRequest27, leaveRequest28,
                                        leaveRequest29, leaveRequest30, leaveRequest31, leaveRequest32,
                                        leaveRequest33);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"{leaveRequests.Count()} Leave requests already exist in the table. No need to populate.");
            }
        }

        public static void PopulatePersonChangeRequests(WageWizardContext context)
        {
            var personChangeRequests = context.PersonChangeRequests;
            if (personChangeRequests.Count() == 0)
            {
                Console.WriteLine("No Person Change Requests exist in the table. Attempting to Populate");

                List<int> employees = Utilities.Utilities.getEmployeeIDs();
                Employee employee1 = Utilities.Utilities.getEmployeeWithID(employees[0]);
                PersonChangeRequest personChangeRequest1 = new PersonChangeRequest(employees[0],
                    "password101",
                    (PersonChangeRequest.Title)employee1.title,
                    employee1.fName,
                    employee1.lName,
                    employee1.emailAddress,
                    employee1.dob,
                    0412334353,
                    employee1.streetNumber,
                    employee1.streetName,
                    employee1.suburb,
                    employee1.city,
                    employee1.state,
                    employee1.country,
                    employee1.bsb,
                    employee1.accountName,
                    employee1.accountNumber,
                    employee1.taxFileNumber,
                    "USD");
                Employee employee2 = Utilities.Utilities.getEmployeeWithID(employees[4]);
                PersonChangeRequest personChangeRequest2 = new PersonChangeRequest(employees[4],
                    "iLoveCatsAndDogs",
                    (PersonChangeRequest.Title)employee1.title,
                    employee2.fName,
                    employee2.lName,
                    "ILoveCatsAndDogs@gmail.com",
                    employee2.dob,
                    employee2.mobileNumber,
                    15,
                    "MyNewStreet",
                    "MyNewSuburb",
                    "CatAndDogTown",
                    "NSW",
                    "Australia",
                    employee2.bsb,
                    employee2.accountName,
                    employee2.accountNumber,
                    employee2.taxFileNumber,
                    "USD");
                personChangeRequests.AddRange(personChangeRequest1, personChangeRequest2);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"{personChangeRequests.Count()} Employees change requests already exist in the table. No need to populate.");
            }
        }

        public static void PopulateGlobalSettings(WageWizardContext context)
        {
            var globalSettingsDB = context.GlobalSettings;
            if (globalSettingsDB.Count() == 0)
            {
                Console.WriteLine("No Global Settings exist in the table. Attempting to Populate");
                GlobalSettings globalSettings = new GlobalSettings();
                globalSettings.globalLeaveRate = 0.15;//15% leave rate
                globalSettings.globalTaxRate = 0.2; //20% tax rate
                globalSettings.globalSuperAnnuationRate = 0.1; //10% super rate
                globalSettingsDB.Add(globalSettings);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"{globalSettingsDB.Count()} GlobalSettings Objects already exist in the table. No need to populate.");
                Console.WriteLine($"Tax rate: {Utilities.Utilities.getGlobalTaxRate()}\nSuperannuation Rate: {Utilities.Utilities.getGlobalSuperAnnuationRate()}\nLeave Rate: {Utilities.Utilities.getGlobalLeaveRate()}");
            }
        }
    }
}
