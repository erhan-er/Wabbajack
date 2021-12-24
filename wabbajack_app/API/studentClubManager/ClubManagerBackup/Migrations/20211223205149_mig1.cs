using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_AdminID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AdminID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Events",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdminID",
                table: "Users",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_AdminID",
                table: "Users",
                column: "AdminID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
