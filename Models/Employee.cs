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
        
        [Column(TypeName = "decimal(18, 2)")]
        public double hourlyRate {  get; set; }
        public int taxFileNumber { get; set;}
        public string paymentCurrencyCode {  get; set; }

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
        }
    }
}
