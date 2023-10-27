using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int updatedBSB { get; set; }
        public string updatedAccountName { get; set; }
        public int updatedAccountNumber { get; set; }
        public int updatedTaxFileNumber { get; set; }
        public string updatedPaymentCurrencyCode { get; set; }
    }
}
