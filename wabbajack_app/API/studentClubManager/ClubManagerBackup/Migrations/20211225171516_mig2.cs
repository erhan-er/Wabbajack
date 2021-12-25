using Microsoft.EntityFrameworkCore.Migrations;

namespace ClubManagerBackup.Migrations
{
   public partial class mig2 : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.RenameColumn(
             name: "UserID",
             table: "Events",
             newName: "UserId");


         migrationBuilder.AddColumn<string>(
             name: "ClubName",
             table: "Events",
             type: "nvarchar(max)",
             nullable: true);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropColumn(
             name: "ClubName",
             table: "Events");

         migrationBuilder.RenameColumn(
             name: "UserId",
             table: "Events",
             newName: "UserID");

         migrationBuilder.RenameColumn(
             name: "EventCost",
             table: "Events",
             newName: "Cost");
      }
   }
}
