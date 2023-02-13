using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIWarsUser.Migrations
{
    public partial class FixCodeNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConeNumber",
                table: "EventNew",
                newName: "CodeNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodeNumber",
                table: "EventNew",
                newName: "ConeNumber");
        }
    }
}
