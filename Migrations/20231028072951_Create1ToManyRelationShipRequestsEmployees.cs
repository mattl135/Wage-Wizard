using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wage_Wizard.Migrations
{
    /// <inheritdoc />
    public partial class Create1ToManyRelationShipRequestsEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "employeeId",
                table: "Requests",
                newName: "employeeID");

            migrationBuilder.AlterColumn<decimal>(
                name: "hours",
                table: "LeaveRequests",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_employeeID",
                table: "Requests",
                column: "employeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Employees_employeeID",
                table: "Requests",
                column: "employeeID",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Employees_employeeID",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_employeeID",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "employeeID",
                table: "Requests",
                newName: "employeeId");

            migrationBuilder.AlterColumn<double>(
                name: "hours",
                table: "LeaveRequests",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
