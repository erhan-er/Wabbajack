using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    PlaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.PlaceID);
                });

            migrationBuilder.CreateTable(
                name: "Searches",
                columns: table => new
                {
                    SearchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchBar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Searches", x => x.SearchID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    SocialMediaAccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WhatsappLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelegramLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.SocialMediaAccountID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClubID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    PlaceID = table.Column<int>(type: "int", nullable: true),
                    NotificationID = table.Column<int>(type: "int", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventCost = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ClubBoardMemberID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SearchEventSearchID = table.Column<int>(type: "int", nullable: true),
                    SearchEventSearchID1 = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Events_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Places_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "Places",
                        principalColumn: "PlaceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Searches_SearchEventSearchID",
                        column: x => x.SearchEventSearchID,
                        principalTable: "Searches",
                        principalColumn: "SearchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Searches_SearchEventSearchID1",
                        column: x => x.SearchEventSearchID1,
                        principalTable: "Searches",
                        principalColumn: "SearchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClubRole",
                columns: table => new
                {
                    ClubRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClubID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubRole", x => x.ClubRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClubID = table.Column<int>(type: "int", nullable: true),
                    ClubID1 = table.Column<int>(type: "int", nullable: true),
                    ClubID2 = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleOfMember = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminID = table.Column<int>(type: "int", nullable: true),
                    SearchStudentSearchID = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Searches_SearchStudentSearchID",
                        column: x => x.SearchStudentSearchID,
                        principalTable: "Searches",
                        principalColumn: "SearchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClubDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialMediaAccountID = table.Column<int>(type: "int", nullable: true),
                    ClubPresidentID = table.Column<int>(type: "int", nullable: true),
                    ClubBudget = table.Column<int>(type: "int", nullable: false),
                    SearchClubSearchID = table.Column<int>(type: "int", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    StudentID1 = table.Column<int>(type: "int", nullable: true),
                    StudentID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clubs_Searches_SearchClubSearchID",
                        column: x => x.SearchClubSearchID,
                        principalTable: "Searches",
                        principalColumn: "SearchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clubs_SocialMediaAccounts_SocialMediaAccountID",
                        column: x => x.SocialMediaAccountID,
                        principalTable: "SocialMediaAccounts",
                        principalColumn: "SocialMediaAccountID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clubs_Users_ClubPresidentID",
                        column: x => x.ClubPresidentID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clubs_Users_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clubs_Users_StudentID1",
                        column: x => x.StudentID1,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clubs_Users_StudentID2",
                        column: x => x.StudentID2,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notificationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubRole_ClubID",
                table: "ClubRole",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_ClubPresidentID",
                table: "Clubs",
                column: "ClubPresidentID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SearchClubSearchID",
                table: "Clubs",
                column: "SearchClubSearchID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SocialMediaAccountID",
                table: "Clubs",
                column: "SocialMediaAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_StudentID",
                table: "Clubs",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_StudentID1",
                table: "Clubs",
                column: "StudentID1");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_StudentID2",
                table: "Clubs",
                column: "StudentID2");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AdminID",
                table: "Events",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryID",
                table: "Events",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClubBoardMemberID",
                table: "Events",
                column: "ClubBoardMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClubID",
                table: "Events",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_NotificationID",
                table: "Events",
                column: "NotificationID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PlaceID",
                table: "Events",
                column: "PlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SearchEventSearchID",
                table: "Events",
                column: "SearchEventSearchID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SearchEventSearchID1",
                table: "Events",
                column: "SearchEventSearchID1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_StudentID",
                table: "Events",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_EventStudent_ParticipantsID",
                table: "EventStudent",
                column: "ParticipantsID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_StudentID",
                table: "Notifications",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserID",
                table: "Notifications",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdminID",
                table: "Users",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClubID",
                table: "Users",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClubID1",
                table: "Users",
                column: "ClubID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClubID2",
                table: "Users",
                column: "ClubID2");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SearchStudentSearchID",
                table: "Users",
                column: "SearchStudentSearchID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StudentID",
                table: "Users",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Clubs_ClubID",
                table: "Events",
                column: "ClubID",
                principalTable: "Clubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Notifications_NotificationID",
                table: "Events",
                column: "NotificationID",
                principalTable: "Notifications",
                principalColumn: "NotificationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_AdminID",
                table: "Events",
                column: "AdminID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_ClubBoardMemberID",
                table: "Events",
                column: "ClubBoardMemberID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_StudentID",
                table: "Events",
                column: "StudentID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubRole_Clubs_ClubID",
                table: "ClubRole",
                column: "ClubID",
                principalTable: "Clubs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Clubs_ClubID",
                table: "Users",
                column: "ClubID",
                principalTable: "Clubs",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clubs_ClubID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clubs_ClubID1",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Clubs_ClubID2",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ClubRole");

            migrationBuilder.DropTable(
                name: "EventStudent");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Places");

            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Searches");
        }
    }
}
