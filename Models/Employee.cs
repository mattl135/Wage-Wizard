using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wage_Wizard.Data;

namespace Wage_Wizard.Models
{
    //Comment me out when using TPH method.
    [Table("Employees")]
    public class Employee : Person
    {
        public int bsb {  get; set; }
        public string accountName { get; set; }
        public int accountNumber { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public double hourlyRate {  get; set; }
        public int taxFileNumber { get; set;}
        public string paymentCurrencyCode { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double accumulatedLeave { get; set; }

        // Navigation Property
        public ICollection<Request> requests { get; set; }

        public Employee(
            int bsb,
            string accountName,
            int accountNumber,
            double hourlyRate,
            int taxFileNumber,
            string paymentCurrencyCode,
            string password,
            Title title,
            string fName,
            string lName,
            string emailAddress,
            string dob,
            int mobileNumber,
            int streetNumber,
            string streetName,
            string suburb,
            string city,
            string state,
            string country
            ) : base(
                password,
                title,
                fName,
                lName,
                emailAddress,
                dob,
                mobileNumber,
                streetNumber,
                streetName,
                suburb,
                city,
                state,
                country
            )
        {
            this.bsb = bsb;
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.hourlyRate = hourlyRate;
            this.taxFileNumber = taxFileNumber;
            this.paymentCurrencyCode = paymentCurrencyCode;
            this.accumulatedLeave = 0;
        }

        public void updatePersonalInformationFromPersonChangeRequest(int personChangeRequestID)
        {
            try
            {
                if (Utilities.Utilities.isValidRequestID(personChangeRequestID) && Utilities.Utilities.isPersonChangeRequest(personChangeRequestID))
                {
                    using WageWizardContext context = new WageWizardContext();
                    var personChangeRequests = context.PersonChangeRequests;

                    if (Utilities.Utilities.isValidRequestID(personChangeRequestID) && Utilities.Utilities.isPersonChangeRequest(personChangeRequestID))
                    {
                        PersonChangeRequest personChangeRequest = Utilities.Utilities.getPersonChangeReqestWithID(personChangeRequestID);
                        int changeRequestEmployeeID = personChangeRequest.employeeID;
                        if (Utilities.Utilities.isValidID(changeRequestEmployeeID) && this.id == changeRequestEmployeeID)
                        {
                            if (personChangeRequest.approvalStatus == Request.ApprovalStatus.Pending) 
                            {
                                this.password = personChangeRequest.updatedPassword;
                                this.title = (Title)personChangeRequest.updatedTitle;
                                this.fName = personChangeRequest.updatedFName;
                                this.lName = personChangeRequest.updatedLName;
                                this.emailAddress = personChangeRequest.updatedEmailAddress;
                                this.dob = personChangeRequest.updatedDOB;
                                this.mobileNumber = personChangeRequest.updatedMobileNumber;
                                this.streetNumber = personChangeRequest.updatedStreetNumber;
                                this.streetName = personChangeRequest.updatedStreetName;
                                this.suburb = personChangeRequest.updatedSuburb;
                                this.city = personChangeRequest.updatedCity;
                                this.state = personChangeRequest.updatedState;
                                this.country = personChangeRequest.updatedCountry;
                                this.bsb = personChangeRequest.updatedBSB;
                                this.accountName = personChangeRequest.updatedAccountName;
                                this.accountNumber = personChangeRequest.updatedAccountNumber;
                                this.taxFileNumber = personChangeRequest.updatedTaxFileNumber;
                                this.paymentCurrencyCode = personChangeRequest.updatedPaymentCurrencyCode;
                                Utilities.Utilities.saveEmployeeChangesToDB(this);
                            } else
                            {
                                Console.WriteLine("Error - Approval status not correct.");
                            }
                        } else
                        {
                            Console.WriteLine("Error - EmployeeID not valid.");
                        }
                    } else
                    {
                        Console.WriteLine("Error - PersonChangeRequestID not valid.");
                    }
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
