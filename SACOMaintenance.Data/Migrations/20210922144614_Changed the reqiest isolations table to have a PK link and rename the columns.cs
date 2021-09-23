using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class ChangedthereqiestisolationstabletohaveaPKlinkandrenamethecolumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "IsolationMaintRequestInitiations");

            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiations",
                columns: table => new
                {
                    IsolationsId = table.Column<int>(type: "int", nullable: false),
                    maintReqInitationListId = table.Column<int>(type: "int", nullable: false),
                    //IsolationsId1 = table.Column<int>(type: "int", nullable: true),
                    //maintReqInitationListId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationMaintRequestInitiation", x => new { x.IsolationsId, x.maintReqInitationListId });
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

            //migrationBuilder.CreateIndex(
            //    name: "IX_IsolationMaintRequestInitiations_IsolationsId",
            //    table: "IsolationMaintRequestInitiations",
            //    column: "IsolationsId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IsolationMaintRequestInitiations_maintReqInitationListId",
            //    table: "IsolationMaintRequestInitiations",
            //    column: "maintReqInitationListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsolationMaintRequestInitiations");
        }
    }
}
