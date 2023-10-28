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

        public static int currentUserId { get; set; }

        public static bool isValidID(int userIDInput) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.Persons.Any(person => person.id == userIDInput);
        }

        public static bool isValidRequestID(int requestIDInput) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.Requests.Any(request => request.id == requestIDInput);
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
            var persons = context.Persons;
            List<int> personIds = persons.Select(person => person.id).ToList();
            return personIds;
        }

        /*********************Requests***********************/
        public static int getRequestCount() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var requests = context.Requests;
            return requests.Count();
        }

        public static List<int> getRequestsIDs() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var requests = context.Requests;
            List<int> requestsIds = requests.Select(request => request.id).ToList();
            return requestsIds;
        }

        /*********************Pay-Requests***********************/
        public static PaymentRequest? getPayRequestWithID(int requestID) //Confirmed Working
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                var requests = context.PaymentRequests;
                var payRequest = requests.SingleOrDefault(r => r.id == requestID);
                return payRequest;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public static bool isPayRequest(PaymentRequest unknownRequest)
        {
            using WageWizardContext context = new WageWizardContext();
            return context.PaymentRequests.Any(request => request.id == unknownRequest.id);
        }

        public static bool isPayRequest(int requestID) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.PaymentRequests.Any(request => request.id == requestID);
        }

        public static int getPayRequestCount() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var paymentRequests = context.PaymentRequests;
            return paymentRequests.Count();
        }

        public static List<int> getPayRequestIDs() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var paymentRequests = context.PaymentRequests;
            List<int> paymentRequestsIds = paymentRequests.Select(request => request.id).ToList();
            return paymentRequestsIds;
        }

        public static void addPayRequestToDB(PaymentRequest paymentRequest)
        {
            try
            {
                using WageWizardContext context = new WageWizardContext();
                var paymentRequests = context.PaymentRequests;
                paymentRequests.Add(paymentRequest);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void savePayRequestChangesToDB(PaymentRequest paymentRequest) //Confirmed
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                context.PaymentRequests.Update(paymentRequest);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        public static void removePaymentRequestFromDB(PaymentRequest paymentRequest)
        {
            try
            {
                if (Utilities.isValidRequestID(paymentRequest.id) && Utilities.isPayRequest(paymentRequest.id))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.PaymentRequests.Remove(paymentRequest);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void removePaymentRequestFromDB(int paymentRequestID)
        {
            try
            {
                if (Utilities.isValidRequestID(paymentRequestID) && Utilities.isPayRequest(paymentRequestID))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.PaymentRequests.Remove(getPayRequestWithID(paymentRequestID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        /*********************Leave-Requests***********************/
        public static LeaveRequest? getLeaveReqestWithID(int requestID) //Confirmed Working
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                var requests = context.LeaveRequests;
                var leaveRequest = requests.SingleOrDefault(r => r.id == requestID);
                return leaveRequest;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public static bool isLeaveRequest(LeaveRequest unknownRequest)
        {
            using WageWizardContext context = new WageWizardContext();
            return context.LeaveRequests.Any(request => request.id == unknownRequest.id);
        }

        public static bool isLeaveRequest(int requestID) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.LeaveRequests.Any(request => request.id == requestID);
        }

        public static int getLeaveRequestCount() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var leaveRequests = context.LeaveRequests;
            return leaveRequests.Count();
        }

        public static List<int> getLeaveRequestsIDs() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var leaveRequests = context.LeaveRequests;
            List<int> leaveRequestsIds = leaveRequests.Select(request => request.id).ToList();
            return leaveRequestsIds;
        }

        public static void addLeaveRequestToDB(LeaveRequest paymentRequest)
        {
            try
            {
                using WageWizardContext context = new WageWizardContext();
                var leaveRequests = context.LeaveRequests;
                leaveRequests.Add(paymentRequest);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void saveLeaveRequestChangesToDB(LeaveRequest leaveRequest) //Confirmed
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                context.LeaveRequests.Update(leaveRequest);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        public static void removeLeaveRequestFromDB(LeaveRequest leaveRequest)
        {
            try
            {
                if (Utilities.isValidRequestID(leaveRequest.id) && Utilities.isLeaveRequest(leaveRequest.id))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.LeaveRequests.Remove(leaveRequest);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void removeLeaveRequestFromDB(int leaveRequestID)
        {
            try
            {
                if (Utilities.isValidRequestID(leaveRequestID) && Utilities.isPayRequest(leaveRequestID))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.LeaveRequests.Remove(getLeaveReqestWithID(leaveRequestID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        /*********************Person-Change-Requests***********************/
        public static PersonChangeRequest? getPersonChangeReqestWithID(int requestID) //Confirmed Working
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                var requests = context.PersonChangeRequests;
                var personChangeRequest = requests.SingleOrDefault(r => r.id == requestID);
                return personChangeRequest;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public static bool isPersonChangeRequest(PersonChangeRequest unknownRequest)
        {
            using WageWizardContext context = new WageWizardContext();
            return context.PersonChangeRequests.Any(request => request.id == unknownRequest.id);
        }

        public static bool isPersonChangeRequest(int requestID) //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            return context.PersonChangeRequests.Any(request => request.id == requestID);
        }

        public static int getPersonChangeCount() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var personChangeRequests = context.PersonChangeRequests;
            return personChangeRequests.Count();
        }

        public static List<int> getPersonChangeRequestsIDs() //Confirmed Working
        {
            using WageWizardContext context = new WageWizardContext();
            var personChangeRequests = context.PersonChangeRequests;
            List<int> personChangeRequestsIds = personChangeRequests.Select(request => request.id).ToList();
            return personChangeRequestsIds;
        }

        public static void addPersonChangeRequestsToDB(PersonChangeRequest personChangeRequest)
        {
            try
            {
                using WageWizardContext context = new WageWizardContext();
                var personChangeRequests = context.PersonChangeRequests;
                personChangeRequests.Add(personChangeRequest);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void savePersonChangeRequestsChangesToDB(PersonChangeRequest personChangeRequest) //Confirmed
        {
            try
            {
                using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                context.PersonChangeRequests.Update(personChangeRequest);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        public static void removePersonChangeRequestFromDB(PersonChangeRequest personChangeRequest)
        {
            try
            {
                if (Utilities.isValidRequestID(personChangeRequest.id) && Utilities.isPersonChangeRequest(personChangeRequest.id))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.PersonChangeRequests.Remove(personChangeRequest);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
        public static void removePersonChangeRequestFromDB(int personChangeRequestID)
        {
            try
            {
                if (Utilities.isValidRequestID(personChangeRequestID) && Utilities.isPersonChangeRequest(personChangeRequestID))
                {
                    using WageWizardContext context = new WageWizardContext(); //THIS IS SAFE
                    context.PersonChangeRequests.Remove(getPersonChangeReqestWithID(personChangeRequestID));
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
