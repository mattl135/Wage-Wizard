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
        public double hours { get; protected set; }
        public string leaveDescription {  get; protected set; }
    }
}
