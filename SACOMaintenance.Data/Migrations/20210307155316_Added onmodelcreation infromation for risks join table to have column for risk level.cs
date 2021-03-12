using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class Addedonmodelcreationinfromationforrisksjointabletohavecolumnforrisklevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RisksId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiationRisk_RisksId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.AddColumn<int>(
                name: "RisksId1",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RiskLevel",
                table: "MaintRequestInitiationRisk",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk",
                columns: new[] { "MaintRequestInitiationId", "RisksId1" });

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationRisk_RisksId1",
                table: "MaintRequestInitiationRisk",
                column: "RisksId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RisksId1",
                table: "MaintRequestInitiationRisk",
                column: "RisksId1",
                principalTable: "Risks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RisksId1",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiationRisk_RisksId1",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "RisksId1",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "RiskLevel",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk",
                columns: new[] { "MaintRequestInitiationId", "RisksId" });

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationRisk_RisksId",
                table: "MaintRequestInitiationRisk",
                column: "RisksId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RisksId",
                table: "MaintRequestInitiationRisk",
                column: "RisksId",
                principalTable: "Risks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
