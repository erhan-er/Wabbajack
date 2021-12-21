using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Users_StudentID2",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_StudentID2",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clubs_ClubID1",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clubs_ClubID2",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClubID1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClubID2",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Events_StudentID2",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_StudentID2",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "ClubID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClubID2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StudentID2",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "StudentID2",
                table: "Clubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubID1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClubID2",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID2",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID2",
                table: "Clubs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClubID1",
                table: "Users",
                column: "ClubID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClubID2",
                table: "Users",
                column: "ClubID2");

            migrationBuilder.CreateIndex(
                name: "IX_Events_StudentID2",
                table: "Events",
                column: "StudentID2");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_StudentID2",
                table: "Clubs",
                column: "StudentID2");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Users_StudentID2",
                table: "Clubs",
                column: "StudentID2",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_StudentID2",
                table: "Events",
                column: "StudentID2",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Clubs_ClubID1",
                table: "Users",
                column: "ClubID1",
                principalTable: "Clubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Clubs_ClubID2",
                table: "Users",
                column: "ClubID2",
                principalTable: "Clubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
