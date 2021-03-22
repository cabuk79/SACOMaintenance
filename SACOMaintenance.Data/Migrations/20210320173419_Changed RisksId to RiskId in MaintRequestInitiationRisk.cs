using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class ChangedRisksIdtoRiskIdinMaintRequestInitiationRisk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "RisksId",
                table: "MaintRequestInitiationRisk",
                newName: "RiskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk",
                columns: new[] { "MaintRequestInitiationId", "RiskId" });

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationRisk_RiskId",
                table: "MaintRequestInitiationRisk",
                column: "RiskId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RiskId",
                table: "MaintRequestInitiationRisk",
                column: "RiskId",
                principalTable: "Risks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RiskId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiationRisk_RiskId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.RenameColumn(
                name: "RiskId",
                table: "MaintRequestInitiationRisk",
                newName: "RisksId");

            migrationBuilder.AddColumn<int>(
                name: "RisksId1",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
