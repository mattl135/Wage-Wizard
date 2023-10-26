﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wage_Wizard.Data;

#nullable disable

namespace Wage_Wizard.Migrations
{
    [DbContext(typeof(WageWizardContext))]
    [Migration("20231026134954_setBusinessRulesForIDs")]
    partial class setBusinessRulesForIDs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Wage_Wizard.Models.GlobalSettings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<double>("globalLeaveRate")
                        .HasColumnType("float");

                    b.Property<double>("globalSuperAnnuationRate")
                        .HasColumnType("float");

                    b.Property<double>("globalTaxRate")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("GlobalSettings");
                });

            modelBuilder.Entity("Wage_Wizard.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("streetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("streetNumber")
                        .HasColumnType("int");

                    b.Property<string>("suburb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("title")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Persons", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Wage_Wizard.Models.Administrator", b =>
                {
                    b.HasBaseType("Wage_Wizard.Models.Person");

                    b.ToTable("Administrators", (string)null);

                    b.HasAnnotation("SqlServer:ExecuteSql", "DBCC CHECKIDENT ('Administrators', RESEED, 900000)");
                });

            modelBuilder.Entity("Wage_Wizard.Models.Employee", b =>
                {
                    b.HasBaseType("Wage_Wizard.Models.Person");

                    b.Property<string>("accountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("accountNumber")
                        .HasColumnType("int");

                    b.Property<int>("bsb")
                        .HasColumnType("int");

                    b.Property<int>("hourlyRate")
                        .HasColumnType("int");

                    b.Property<string>("paymentCurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("taxFileNumber")
                        .HasColumnType("int");

                    b.ToTable("Employees", (string)null);

                    b.HasAnnotation("SqlServer:ExecuteSql", "DBCC CHECKIDENT ('Employees', RESEED, 100000)");
                });

            modelBuilder.Entity("Wage_Wizard.Models.Administrator", b =>
                {
                    b.HasOne("Wage_Wizard.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Wage_Wizard.Models.Administrator", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Wage_Wizard.Models.Employee", b =>
                {
                    b.HasOne("Wage_Wizard.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("Wage_Wizard.Models.Employee", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
