using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Wizard.Models
{
    public class GlobalSettings
    {
        public static double globalTaxRate {  get; set; }
        public static double globalSuperAnnuationRate { get; set; }
        public static double globalLeaveRate { get; set; }
    }
}
