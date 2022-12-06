using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealForFamily.Migrations
{
    public partial class migration_name1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "AboutUs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Test",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "AboutUs");
        }
    }
}
