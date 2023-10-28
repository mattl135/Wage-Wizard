using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wage_Wizard.Migrations
{
    /// <inheritdoc />
    public partial class FixBugInRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Requests",
                newName: "approvalStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "approvalStatus",
                table: "Requests",
                newName: "title");
        }
    }
}
