using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Searches_SearchClubSearchID",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Searches_SearchEventSearchID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Searches_SearchEventSearchID1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Searches_SearchStudentSearchID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "EventStudent");

            migrationBuilder.RenameColumn(
                name: "SearchStudentSearchID",
                table: "Users",
                newName: "SearchStudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SearchStudentSearchID",
                table: "Users",
                newName: "IX_Users_SearchStudentID");

            migrationBuilder.RenameColumn(
                name: "SocialMediaAccountID",
                table: "SocialMediaAccounts",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SearchID",
                table: "Searches",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PlaceID",
                table: "Places",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "NotificationID",
                table: "Notifications",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SearchEventSearchID1",
                table: "Events",
                newName: "StudentID2");

            migrationBuilder.RenameColumn(
                name: "SearchEventSearchID",
                table: "Events",
                newName: "StudentID1");

            migrationBuilder.RenameIndex(
                name: "IX_Events_SearchEventSearchID1",
                table: "Events",
                newName: "IX_Events_StudentID2");

            migrationBuilder.RenameIndex(
                name: "IX_Events_SearchEventSearchID",
                table: "Events",
                newName: "IX_Events_StudentID1");

            migrationBuilder.RenameColumn(
                name: "SearchClubSearchID",
                table: "Clubs",
                newName: "SearchClubID");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_SearchClubSearchID",
                table: "Clubs",
                newName: "IX_Clubs_SearchClubID");

            migrationBuilder.RenameColumn(
                name: "ClubRoleID",
                table: "ClubRole",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "EventID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SearchEventID",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SearchEventID1",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EventID",
                table: "Users",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SearchEventID",
                table: "Events",
                column: "SearchEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SearchEventID1",
                table: "Events",
                column: "SearchEventID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Searches_SearchClubID",
                table: "Clubs",
                column: "SearchClubID",
                principalTable: "Searches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Searches_SearchEventID",
                table: "Events",
                column: "SearchEventID",
                principalTable: "Searches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Searches_SearchEventID1",
                table: "Events",
                column: "SearchEventID1",
                principalTable: "Searches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_StudentID1",
                table: "Events",
                column: "StudentID1",
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
                name: "FK_Users_Events_EventID",
                table: "Users",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Searches_SearchStudentID",
                table: "Users",
                column: "SearchStudentID",
                principalTable: "Searches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Searches_SearchClubID",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Searches_SearchEventID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Searches_SearchEventID1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_StudentID1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_StudentID2",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Events_EventID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Searches_SearchStudentID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EventID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Events_SearchEventID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SearchEventID1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SearchEventID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SearchEventID1",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "SearchStudentID",
                table: "Users",
                newName: "SearchStudentSearchID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SearchStudentID",
                table: "Users",
                newName: "IX_Users_SearchStudentSearchID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "SocialMediaAccounts",
                newName: "SocialMediaAccountID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Searches",
                newName: "SearchID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Places",
                newName: "PlaceID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Notifications",
                newName: "NotificationID");

            migrationBuilder.RenameColumn(
                name: "StudentID2",
                table: "Events",
                newName: "SearchEventSearchID1");

            migrationBuilder.RenameColumn(
                name: "StudentID1",
                table: "Events",
                newName: "SearchEventSearchID");

            migrationBuilder.RenameIndex(
                name: "IX_Events_StudentID2",
                table: "Events",
                newName: "IX_Events_SearchEventSearchID1");

            migrationBuilder.RenameIndex(
                name: "IX_Events_StudentID1",
                table: "Events",
                newName: "IX_Events_SearchEventSearchID");

            migrationBuilder.RenameColumn(
                name: "SearchClubID",
                table: "Clubs",
                newName: "SearchClubSearchID");

            migrationBuilder.RenameIndex(
                name: "IX_Clubs_SearchClubID",
                table: "Clubs",
                newName: "IX_Clubs_SearchClubSearchID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ClubRole",
                newName: "ClubRoleID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.CreateTable(
                name: "EventStudent",
                columns: table => new
                {
                    OldEventsID = table.Column<int>(type: "int", nullable: false),
                    ParticipantsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStudent", x => new { x.OldEventsID, x.ParticipantsID });
                    table.ForeignKey(
                        name: "FK_EventStudent_Events_OldEventsID",
                        column: x => x.OldEventsID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventStudent_Users_ParticipantsID",
                        column: x => x.ParticipantsID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventStudent_ParticipantsID",
                table: "EventStudent",
                column: "ParticipantsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Searches_SearchClubSearchID",
                table: "Clubs",
                column: "SearchClubSearchID",
                principalTable: "Searches",
                principalColumn: "SearchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Searches_SearchEventSearchID",
                table: "Events",
                column: "SearchEventSearchID",
                principalTable: "Searches",
                principalColumn: "SearchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Searches_SearchEventSearchID1",
                table: "Events",
                column: "SearchEventSearchID1",
                principalTable: "Searches",
                principalColumn: "SearchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Searches_SearchStudentSearchID",
                table: "Users",
                column: "SearchStudentSearchID",
                principalTable: "Searches",
                principalColumn: "SearchID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
