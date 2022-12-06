using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealForFamily.Migrations
{
    public partial class migration_name3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NewTest",
                table: "AboutUs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1,
                column: "NewTest",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewTest",
                table: "AboutUs");
        }
    }
}
