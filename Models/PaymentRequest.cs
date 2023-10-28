using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Wizard.Models
{
    [Table("PaymentRequests")]
    public class PaymentRequest : Request
    {
        [Column(TypeName = "decimal(18, 2)")]
        public double hours { get; protected set; }

        public PaymentRequest(int employeeID, double hours) : base(employeeID)
        {
            this.hours = hours;
        }
    }


}
