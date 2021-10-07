using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class ChangedRequestedByIdtoUserIdandaddedUsernavigationinMaintRequestInitationmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestedById",
                table: "MaintRequestInitiations");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "MaintRequestInitiations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MaintRequestInitiations");

            migrationBuilder.AddColumn<int>(
                name: "RequestedById",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
