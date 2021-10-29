using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class ChangedthenavigationpropertyintheAuthroizationRequestmodelfromListtovirtualMaintRequestInitation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorizationRequestMaintRequestInitiation");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AuthorizationRequestMaintRequestInitiation",
                columns: table => new
                {
                    AuthorizationRequestId = table.Column<int>(type: "int", nullable: false),
                    MaintRequestInitiationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizationRequestMaintRequestInitiation", x => new { x.AuthorizationRequestId, x.MaintRequestInitiationId });
                    table.ForeignKey(
                        name: "FK_AuthorizationRequestMaintRequestInitiation_AuthorizationRequests_AuthorizationRequestId",
                        column: x => x.AuthorizationRequestId,
                        principalTable: "AuthorizationRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorizationRequestMaintRequestInitiation_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationRequestMaintRequestInitiation_MaintRequestInitiationId",
                table: "AuthorizationRequestMaintRequestInitiation",
                column: "MaintRequestInitiationId");
        }
    }
}
