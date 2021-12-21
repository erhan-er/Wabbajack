using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AdminID",
                table: "Events");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AdminID",
                table: "Events",
                column: "AdminID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_AdminID",
                table: "Events");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AdminID",
                table: "Events",
                column: "AdminID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
