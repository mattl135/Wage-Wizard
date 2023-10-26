using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        //Method TPH
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("PersonType")
                .HasValue<Administrator>("Administrator")
                .HasValue<Employee>("Employee");
        }*/

    }
}
