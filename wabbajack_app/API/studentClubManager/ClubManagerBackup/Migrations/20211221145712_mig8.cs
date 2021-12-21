using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriptor",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descriptor",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
