using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class Removedmaintreqtoauthrequestsnavigations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorizationRequests_MaintRequestInitiations_MaintRequestInitiationsId",
                table: "AuthorizationRequests");

            migrationBuilder.DropIndex(
                name: "IX_AuthorizationRequests_MaintRequestInitiationsId",
                table: "AuthorizationRequests");

            migrationBuilder.DropColumn(
                name: "MaintRequestInitiationsId",
                table: "AuthorizationRequests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaintRequestInitiationsId",
                table: "AuthorizationRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationRequests_MaintRequestInitiationsId",
                table: "AuthorizationRequests",
                column: "MaintRequestInitiationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationRequests_MaintRequestInitiations_MaintRequestInitiationsId",
                table: "AuthorizationRequests",
                column: "MaintRequestInitiationsId",
                principalTable: "MaintRequestInitiations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
