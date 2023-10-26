using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Wizard.Models
{
    //Comment me out when using TPH method.
    [Table("Employees")]
    public class Employee : Person
    {
        public int bsb {  get; set; }
        public string accountName { get; set; }
        public int accountNumber { get; set; }
        public int hourlyRate {  get; set; }
        public int taxFileNumber { get; set;}
        public string paymentCurrencyCode {  get; set; }

        protected Employee(
            int bsb,
            string accountName,
            int accountNumber,
            int hourlyRate,
            int taxFileNumber,
            string paymentCurrencyCode,
            int id,
            string password,
            Title title,
            string fName,
            string lName,
            string emailAddress,
            string dob,
            string mobileNumber,
            int streetNumber,
            string streetName,
            string suburb,
            string city,
            string state,
            string country
            ) : base(
                id,
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

        }
    }
}
