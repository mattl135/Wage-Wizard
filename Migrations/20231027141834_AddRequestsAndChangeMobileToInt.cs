using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wage_Wizard.Migrations
{
    /// <inheritdoc />
    public partial class AddRequestsAndChangeMobileToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "mobileNumber",
                table: "Persons",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    title = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    hours = table.Column<double>(type: "float", nullable: false),
                    leaveDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Requests_id",
                        column: x => x.id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    hours = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequests", x => x.id);
                    table.ForeignKey(
                        name: "FK_PaymentRequests_Requests_id",
                        column: x => x.id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonChangeRequests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    updatedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedTitle = table.Column<int>(type: "int", nullable: false),
                    updatedFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedDOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedMobileNumber = table.Column<int>(type: "int", nullable: false),
                    updatedStreetNumber = table.Column<int>(type: "int", nullable: false),
                    updatedStreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedSuburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedBSB = table.Column<int>(type: "int", nullable: false),
                    updatedAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedAccountNumber = table.Column<int>(type: "int", nullable: false),
                    updatedTaxFileNumber = table.Column<int>(type: "int", nullable: false),
                    updatedPaymentCurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonChangeRequests", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonChangeRequests_Requests_id",
                        column: x => x.id,
                        principalTable: "Requests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "PaymentRequests");

            migrationBuilder.DropTable(
                name: "PersonChangeRequests");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.AlterColumn<string>(
                name: "mobileNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
