using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Wizard.Models
{
    [Table("LeaveRequests")]
    public class LeaveRequest : Request
    {
        [Column(TypeName = "decimal(18, 2)")]
        public double hours { get; protected set; }
        public string leaveDescription {  get; protected set; }

        public LeaveRequest(
            int employeeID,
            double hours,
            string leaveDescription) : base(employeeID)
        {
            this.hours = hours;
            this.leaveDescription = leaveDescription;

        }
    }
}
