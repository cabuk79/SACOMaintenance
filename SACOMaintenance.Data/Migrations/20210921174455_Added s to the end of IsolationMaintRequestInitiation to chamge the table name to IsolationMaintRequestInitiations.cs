using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedstotheendofIsolationMaintRequestInitiationtochamgethetablenametoIsolationMaintRequestInitiations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsolationMaintRequestInitiation");

            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiations",
                columns: table => new
                {
                    IsolationsId = table.Column<int>(type: "int", nullable: false),
                    maintReqInitationListId = table.Column<int>(type: "int", nullable: false),
                    IsolationsId1 = table.Column<int>(type: "int", nullable: true),
                    maintReqInitationListId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_Isolations_IsolationsId1",
                        column: x => x.IsolationsId1,
                        principalTable: "Isolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_maintReqInitationListId1",
                        column: x => x.maintReqInitationListId1,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiations_IsolationsId1",
                table: "IsolationMaintRequestInitiations",
                column: "IsolationsId1");

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiations_maintReqInitationListId1",
                table: "IsolationMaintRequestInitiations",
                column: "maintReqInitationListId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsolationMaintRequestInitiations");

            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiation",
                columns: table => new
                {
                    IsolationsId = table.Column<int>(type: "int", nullable: false),
                    maintReqInitationListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationMaintRequestInitiation", x => new { x.IsolationsId, x.maintReqInitationListId });
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiation_Isolations_IsolationsId",
                        column: x => x.IsolationsId,
                        principalTable: "Isolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiation_MaintRequestInitiations_maintReqInitationListId",
                        column: x => x.maintReqInitationListId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiation_maintReqInitationListId",
                table: "IsolationMaintRequestInitiation",
                column: "maintReqInitationListId");
        }
    }
}
