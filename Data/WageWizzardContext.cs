using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Wage_Wizard.Models;

namespace Wage_Wizard.Data
{
    
    //Table-Per-Type (TPT) approach selected
    public class WageWizardContext : DbContext
    {
        //!!!! Caution !!!!//
        //Flag for using either the localDB or Live Azure Cloud MySQL Database.
        public static bool useProductionDB { get; set; } = true;
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<GlobalSettings> GlobalSettings { get; set; } = null!;
        public DbSet<Request> Requests { get; set; } = null!;

        //Comment me out when using TPH method.
        public DbSet<Administrator> Administrators { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<LeaveRequest> LeaveRequests { get; set; } = null!;
        public DbSet<PaymentRequest> PaymentRequests { get; set; } = null!;
        public DbSet<PersonChangeRequest> PersonChangeRequests { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (useProductionDB)
            {
                optionsBuilder.UseSqlServer(@"Data Source=tcp:wage-wizard.database.windows.net,1433;Initial Catalog=Wage-Wizard-DB;User Id=SuperAdmin@wage-wizard;Password=7As3GfsZ97hU");
            }
            else
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WageWizzardLocal");
            }
        }

        //Method TPT
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .ToTable("Persons");

            modelBuilder.Entity<Administrator>()
            .ToTable("Administrators");

            modelBuilder.Entity<Employee>()
                .ToTable("Employees");

            modelBuilder.Entity<Request>()
                .ToTable("Requests")
                .HasOne(r => r.employee)
                .WithMany(e => e.requests)
                .HasForeignKey(r => r.employeeID);

            modelBuilder.Entity<LeaveRequest>()
                .ToTable("LeaveRequests");

            modelBuilder.Entity<PaymentRequest>()
                .ToTable("PaymentRequests");

            modelBuilder.Entity<PersonChangeRequest>()
                .ToTable("PersonChangeRequests");

            modelBuilder.Entity<GlobalSettings>();

            // Execute raw SQL to set identity seed and increment for Administrators
            modelBuilder.Entity<Administrator>()
                .HasAnnotation("SqlServer:ExecuteSql", "DBCC CHECKIDENT ('Administrators', RESEED, 900000)");
            // Execute raw SQL to set identity seed and increment for Employees
            modelBuilder.Entity<Employee>()
                .HasAnnotation("SqlServer:ExecuteSql", "DBCC CHECKIDENT ('Employees', RESEED, 100000)");
        }

        //Method TPH
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("PersonType")
                .HasValue<Administrator>("Administrator")
                .HasValue<Employee>("Employee");
        }*/

        //
    }
}
