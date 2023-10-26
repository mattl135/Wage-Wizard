using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wage_Wizard.Models
{
    public class GlobalSettings
    {
        //public int id { get; set; } = 1; //Always 1 for DB Initialisation
        public double globalTaxRate {  get; set; }
        public double globalSuperAnnuationRate { get; set; }
        public double globalLeaveRate { get; set; }
    }
}
