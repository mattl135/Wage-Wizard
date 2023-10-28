using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wage_Wizard.Models;

namespace Wage_Wizard.Models
{
    [Table("PersonChangeRequests")]
    public class PersonChangeRequest : Request
    {
        public string updatedPassword { get; protected set; }
        public enum Title { Mr, Mrs, Dr, Miss, Ms, Master };
        public Title updatedTitle { get; protected set; }
        public string updatedFName { get; protected set; }
        public string updatedLName { get; protected set; }
        public string updatedEmailAddress { get; protected set; }
        public string updatedDOB { get; protected set; }
        public int updatedMobileNumber { get; protected set; }
        public int updatedStreetNumber { get; protected set; }
        public string updatedStreetName { get; protected set; }
        public string updatedSuburb { get; protected set; }
        public string updatedCity { get; protected set; }
        public string updatedState { get; protected set; }
        public string updatedCountry { get; protected set; }
        public int updatedBSB { get; protected set; }
        public string updatedAccountName { get; protected set; }
        public int updatedAccountNumber { get; protected set; }
        public int updatedTaxFileNumber { get; protected set; }
        public string updatedPaymentCurrencyCode { get; protected set; }

        public PersonChangeRequest(
            int employeeID,
            string updatedPassword,
            Title updatedTitle,
            string updatedFName,
            string updatedLName,
            string updatedEmailAddress,
            string updatedDOB,
            int updatedMobileNumber,
            int updatedStreetNumber,
            string updatedStreetName,
            string updatedSuburb,
            string updatedCity,
            string updatedState,
            string updatedCountry,
            int updatedBSB,
            string updatedAccountName,
            int updatedAccountNumber,
            int updatedTaxFileNumber,
            string updatedPaymentCurrencyCode) : base(employeeID)
        {
            this.updatedPassword = updatedPassword;
            this.updatedTitle = updatedTitle;
            this.updatedFName = updatedFName;
            this.updatedLName = updatedLName;
            this.updatedEmailAddress = updatedEmailAddress;
            this.updatedDOB = updatedDOB;
            this.updatedMobileNumber = updatedMobileNumber;
            this.updatedStreetNumber = updatedStreetNumber;
            this.updatedStreetName = updatedStreetName;
            this.updatedSuburb = updatedSuburb;
            this.updatedCity = updatedCity;
            this.updatedState = updatedState;
            this.updatedCountry = updatedCountry;
            this.updatedBSB = updatedBSB;
            this.updatedAccountName = updatedAccountName;
            this.updatedAccountNumber = updatedAccountNumber;
            this.updatedTaxFileNumber = updatedTaxFileNumber;
            this.updatedPaymentCurrencyCode = updatedPaymentCurrencyCode;
        }
    }
}
