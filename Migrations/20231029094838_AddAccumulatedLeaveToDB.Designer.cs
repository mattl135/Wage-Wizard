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
    [Migration("20231029094838_AddAccumulatedLeaveToDB")]
    partial class AddAccumulatedLeaveToDB
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

                    b.Property<int>("mobileNumber")
                        .HasColumnType("int");

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

            modelBuilder.Entity("Wage_Wizard.Models.Request", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("approvalStatus")
                        .HasColumnType("int");

                    b.Property<int>("employeeID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("employeeID");

                    b.ToTable("Requests", (string)null);

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

                    b.Property<decimal>("accumulatedLeave")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("bsb")
                        .HasColumnType("int");

                    b.Property<decimal>("hourlyRate")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("paymentCurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("taxFileNumber")
                        .HasColumnType("int");

                    b.ToTable("Employees", (string)null);

                    b.HasAnnotation("SqlServer:ExecuteSql", "DBCC CHECKIDENT ('Employees', RESEED, 100000)");
                });

            modelBuilder.Entity("Wage_Wizard.Models.LeaveRequest", b =>
                {
                    b.HasBaseType("Wage_Wizard.Models.Request");

                    b.Property<decimal>("hours")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("leaveDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("LeaveRequests", (string)null);
                });

            modelBuilder.Entity("Wage_Wizard.Models.PaymentRequest", b =>
                {
                    b.HasBaseType("Wage_Wizard.Models.Request");

                    b.Property<decimal>("hours")
                        .HasColumnType("decimal(18, 2)");

                    b.ToTable("PaymentRequests", (string)null);
                });

            modelBuilder.Entity("Wage_Wizard.Models.PersonChangeRequest", b =>
                {
                    b.HasBaseType("Wage_Wizard.Models.Request");

                    b.Property<string>("updatedAccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("updatedAccountNumber")
                        .HasColumnType("int");

                    b.Property<int>("updatedBSB")
                        .HasColumnType("int");

                    b.Property<string>("updatedCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedDOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedEmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("updatedMobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("updatedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedPaymentCurrencyCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("updatedStreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("updatedStreetNumber")
                        .HasColumnType("int");

                    b.Property<string>("updatedSuburb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("updatedTaxFileNumber")
                        .HasColumnType("int");

                    b.Property<int>("updatedTitle")
                        .HasColumnType("int");

                    b.ToTable("PersonChangeRequests", (string)null);
                });

            modelBuilder.Entity("Wage_Wizard.Models.Request", b =>
                {
                    b.HasOne("Wage_Wizard.Models.Employee", "employee")
                        .WithMany("requests")
                        .HasForeignKey("employeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
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

            modelBuilder.Entity("Wage_Wizard.Models.LeaveRequest", b =>
                {
                    b.HasOne("Wage_Wizard.Models.Request", null)
                        .WithOne()
                        .HasForeignKey("Wage_Wizard.Models.LeaveRequest", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Wage_Wizard.Models.PaymentRequest", b =>
                {
                    b.HasOne("Wage_Wizard.Models.Request", null)
                        .WithOne()
                        .HasForeignKey("Wage_Wizard.Models.PaymentRequest", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Wage_Wizard.Models.PersonChangeRequest", b =>
                {
                    b.HasOne("Wage_Wizard.Models.Request", null)
                        .WithOne()
                        .HasForeignKey("Wage_Wizard.Models.PersonChangeRequest", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Wage_Wizard.Models.Employee", b =>
                {
                    b.Navigation("requests");
                });
#pragma warning restore 612, 618
        }
    }
}