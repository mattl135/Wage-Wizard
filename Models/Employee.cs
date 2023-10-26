using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Wizard.Models
{
    class Employee : Person
    {
        private int bsb {  get; set; }
        private string accountName { get; set; }
        private int accountNumber { get; set; }
        private int hourlyRate {  get; set; }
        private int taxFileNumber { get; set;}
        private string paymentCurrencyCode {  get; set; }

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
