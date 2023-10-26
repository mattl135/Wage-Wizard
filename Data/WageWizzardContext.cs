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
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<GlobalSettings> GlobalSettings { get; set; } = null!;

        //Comment me out when using TPH method.
        public DbSet<Administrator> Administrators { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WageWizzardLocal");
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
