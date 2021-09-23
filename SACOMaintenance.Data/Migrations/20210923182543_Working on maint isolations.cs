using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class Workingonmaintisolations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "IsolationMaintRequestInitiations");

            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiation",
                columns: table => new
                {
                    IsolationsId = table.Column<int>(type: "int", nullable: false),
                    MaintRequestInitiationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationMaintRequestInitiation", x => new { x.IsolationsId, x.MaintRequestInitiationId });
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiation_Isolations_IsolationsId",
                        column: x => x.IsolationsId,
                        principalTable: "Isolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiation_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiation_MaintRequestInitiationId",
                table: "IsolationMaintRequestInitiation",
                column: "MaintRequestInitiationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsolationMaintRequestInitiation");

            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiations",
                columns: table => new
                {
                    IsolationId = table.Column<int>(type: "int", nullable: false),
                    MaintRequestInitiationId = table.Column<int>(type: "int", nullable: false),
                    MaintReqInitationListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationMaintRequestInitiations", x => new { x.IsolationId, x.MaintRequestInitiationId });
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_Isolations_IsolationId",
                        column: x => x.IsolationId,
                        principalTable: "Isolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiations_MaintRequestInitiationId",
                table: "IsolationMaintRequestInitiations",
                column: "MaintRequestInitiationId");
        }
    }
}
