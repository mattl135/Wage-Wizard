using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wage_Wizard.Migrations
{
    /// <inheritdoc />
    public partial class AddAccumulatedLeaveToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "accumulatedLeave",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accumulatedLeave",
                table: "Employees");
        }
    }
}
