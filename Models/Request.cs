using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wage_Wizard.Models.Person;

namespace Wage_Wizard.Models
{
    [Table("Requests")]
    public abstract class Request
    {
        public int id { get; protected set; }
        public int employeeId { get; protected set; }
        public enum approvalStatus { Pending, Approved, Rejected }
        public Title title { get; protected set; }

        //Attributes: ID, employeeID, approvalStatus (enum: Pending, Approved, Rejected)
    }
}
