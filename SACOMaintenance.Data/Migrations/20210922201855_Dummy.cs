using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class Dummy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiations",
                columns: table => new
                {
                    IsolationId = table.Column<int>(type: "int", nullable: false),
                    MaintReqInitationListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationMaintRequestInitiations", x => new { x.IsolationId, x.MaintReqInitationListId });
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_Isolations_IsolationId",
                        column: x => x.IsolationId,
                        principalTable: "Isolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_MaintReqInitationListId",
                        column: x => x.MaintReqInitationListId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiations_MaintReqInitationListId",
                table: "IsolationMaintRequestInitiations",
                column: "MaintReqInitationListId");


            //migrationBuilder.DropForeignKey(
            //    name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_MaintReqInitationListId",
            //    table: "IsolationMaintRequestInitiations");

            //migrationBuilder.RenameColumn(
            //    name: "maintReqInitationListId",
            //    table: "IsolationMaintRequestInitiations",
            //    newName: "MaintReqInitationListId");

            //migrationBuilder.RenameColumn(
            //    name: "MaintReqInitationListId",
            //    table: "IsolationMaintRequestInitiations",
            //    newName: "MaintRequestInitiationId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_IsolationMaintRequestInitiations_MaintReqInitationListId",
            //    table: "IsolationMaintRequestInitiations",
            //    newName: "IX_IsolationMaintRequestInitiations_MaintRequestInitiationId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_MaintRequestInitiationId",
            //    table: "IsolationMaintRequestInitiations",
            //    column: "MaintRequestInitiationId",
            //    principalTable: "MaintRequestInitiations",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_MaintRequestInitiationId",
            //    table: "IsolationMaintRequestInitiations");

            //migrationBuilder.RenameColumn(
            //    name: "MaintReqInitationListId",
            //    table: "IsolationMaintRequestInitiations",
            //    newName: "maintReqInitationListId");

            //migrationBuilder.RenameColumn(
            //    name: "MaintRequestInitiationId",
            //    table: "IsolationMaintRequestInitiations",
            //    newName: "MaintReqInitationListId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_IsolationMaintRequestInitiations_MaintRequestInitiationId",
            //    table: "IsolationMaintRequestInitiations",
            //    newName: "IX_IsolationMaintRequestInitiations_MaintReqInitationListId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_IsolationMaintRequestInitiations_MaintRequestInitiations_MaintReqInitationListId",
            //    table: "IsolationMaintRequestInitiations",
            //    column: "MaintReqInitationListId",
            //    principalTable: "MaintRequestInitiations",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
