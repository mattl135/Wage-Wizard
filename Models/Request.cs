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
        //Primary Key
        public int id { get; protected set; }
        //Foreign Key
        public int employeeID { get; protected set; }
        // Navigation Property
        public Employee employee { get; set; }
        public enum ApprovalStatus { Pending, Approved, Rejected }
        public ApprovalStatus approvalStatus { get; set; }

        protected Request(int employeeID)
        {
            this.employeeID = employeeID;
            this.approvalStatus = ApprovalStatus.Pending;
        }
    }
}
