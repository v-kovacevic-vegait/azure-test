using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealForFamily.Migrations
{
    public partial class migration_name4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewTest",
                table: "AboutUs",
                newName: "NewTest2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewTest2",
                table: "AboutUs",
                newName: "NewTest");
        }
    }
}
