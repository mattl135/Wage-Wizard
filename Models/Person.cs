using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wage_Wizard.Models.Person;

namespace Wage_Wizard.Models
{
    [Table("Persons")]
    public abstract class Person
    {
        public int id { get; protected set; }
        public string password { get; protected set; }
        public enum Title { Mr, Mrs, Dr, Miss, Ms, Master };
        public Title title { get; protected set; }
        public string fName { get; protected set; }
        public string lName { get; protected set; }
        public string emailAddress { get; protected set; }
        public string dob { get; protected set; }
        public int mobileNumber { get; protected set; }
        public int streetNumber { get; protected set; }
        public string streetName { get; protected set; }
        public string suburb { get; protected set; }
        public string city { get; protected set; }
        public string state { get; protected set; }
        public string country { get; protected set; }

        protected Person(
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
        )
        {
            this.password = password;
            this.title = title;
            this.fName = fName;
            this.lName = lName;
            this.emailAddress = emailAddress;
            this.dob = dob;
            this.mobileNumber = mobileNumber;
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.suburb = suburb;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        //Purpose: Combines Title, First Name and Last Name into a string and returns it.
        public string GetPersonFullName()
        {
            return $"{title} {fName} {lName}";
        }

        public void LoadMenu(string userID)
        {

        }
    }
}
