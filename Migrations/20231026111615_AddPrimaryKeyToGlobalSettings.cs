using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wage_Wizard.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryKeyToGlobalSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "GlobalSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "GlobalSettings");
        }
    }
}
