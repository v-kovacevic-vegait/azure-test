using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealForFamily.Migrations
{
    public partial class migration_name7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewTest3",
                table: "AboutUs",
                newName: "NewTest4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewTest4",
                table: "AboutUs",
                newName: "NewTest3");
        }
    }
}
