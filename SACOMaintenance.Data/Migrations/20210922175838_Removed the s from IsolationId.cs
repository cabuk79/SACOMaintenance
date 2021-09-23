using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class RemovedthesfromIsolationId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiations",
                columns: table => new
                {
                    IsolationsId = table.Column<int>(type: "int", nullable: false),
                    maintReqInitationListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationMaintRequestInitiations", x => new { x.IsolationsId, x.maintReqInitationListId });
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_Isolations_IsolationsId",
                        column: x => x.IsolationsId,
                        principalTable: "Isolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_maintReqInitationListId",
                        column: x => x.maintReqInitationListId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiations_maintReqInitationListId",
                table: "IsolationMaintRequestInitiations",
                column: "maintReqInitationListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsolationMaintRequestInitiations");

        }
    }
}
