using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Wizard.Models
{
    //Comment me out when using TPH method.
    [Table("Administrators")]
    public class Administrator : Person
    {
        protected Administrator(
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
            //No Variables Initalised in Constructor
        }
    }
}
