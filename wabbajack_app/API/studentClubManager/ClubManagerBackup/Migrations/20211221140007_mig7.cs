using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Users_StudentID1",
                table: "Clubs");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_StudentID1",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "StudentID1",
                table: "Clubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Clubs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_StudentID1",
                table: "Clubs",
                column: "StudentID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Users_StudentID1",
                table: "Clubs",
                column: "StudentID1",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
