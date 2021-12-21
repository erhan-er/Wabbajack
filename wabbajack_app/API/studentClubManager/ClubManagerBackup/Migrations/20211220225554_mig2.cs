using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_Searches_SearchClubID",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Clubs_SocialMediaAccounts_SocialMediaAccountID",
                table: "Clubs");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Searches_SearchEventID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Searches_SearchEventID1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Searches_SearchStudentID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Searches");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropIndex(
                name: "IX_Users_SearchStudentID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Events_SearchEventID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_SearchEventID1",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_SearchClubID",
                table: "Clubs");

            migrationBuilder.DropIndex(
                name: "IX_Clubs_SocialMediaAccountID",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "SearchStudentID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SearchEventID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SearchEventID1",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "SearchClubID",
                table: "Clubs");

            migrationBuilder.DropColumn(
                name: "SocialMediaAccountID",
                table: "Clubs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SearchStudentID",
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

            migrationBuilder.AddColumn<int>(
                name: "SearchClubID",
                table: "Clubs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaAccountID",
                table: "Clubs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Searches",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SearchBar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Searches", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelegramLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsappLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_SearchStudentID",
                table: "Users",
                column: "SearchStudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SearchEventID",
                table: "Events",
                column: "SearchEventID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SearchEventID1",
                table: "Events",
                column: "SearchEventID1");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SearchClubID",
                table: "Clubs",
                column: "SearchClubID");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_SocialMediaAccountID",
                table: "Clubs",
                column: "SocialMediaAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_Searches_SearchClubID",
                table: "Clubs",
                column: "SearchClubID",
                principalTable: "Searches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clubs_SocialMediaAccounts_SocialMediaAccountID",
                table: "Clubs",
                column: "SocialMediaAccountID",
                principalTable: "SocialMediaAccounts",
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
                name: "FK_Users_Searches_SearchStudentID",
                table: "Users",
                column: "SearchStudentID",
                principalTable: "Searches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
