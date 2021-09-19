using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class ChangedtheMaintRequestInitiationIdtohavetheHMLasbooleans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintReqRisksLinked_MaintRequestInitiations_MaintRequestInitiationId",
                table: "MaintReqRisksLinked");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintReqRisksLinked_Risks_RiskId",
                table: "MaintReqRisksLinked");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintReqRisksLinked",
                table: "MaintReqRisksLinked");

            migrationBuilder.DropColumn(
                name: "RiskLevel",
                table: "MaintReqRisksLinked");

            migrationBuilder.RenameTable(
                name: "MaintReqRisksLinked",
                newName: "MaintRequestInitiationRisk");

            migrationBuilder.RenameIndex(
                name: "IX_MaintReqRisksLinked_RiskId",
                table: "MaintRequestInitiationRisk",
                newName: "IX_MaintRequestInitiationRisk_RiskId");

            migrationBuilder.AddColumn<bool>(
                name: "H",
                table: "MaintRequestInitiationRisk",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "L",
                table: "MaintRequestInitiationRisk",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "M",
                table: "MaintRequestInitiationRisk",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk",
                columns: new[] { "MaintRequestInitiationId", "RiskId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk",
                column: "MaintRequestInitiationId",
                principalTable: "MaintRequestInitiations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RiskId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "H",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "L",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "M",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.RenameTable(
                name: "MaintRequestInitiationRisk",
                newName: "MaintReqRisksLinked");

            migrationBuilder.RenameIndex(
                name: "IX_MaintRequestInitiationRisk_RiskId",
                table: "MaintReqRisksLinked",
                newName: "IX_MaintReqRisksLinked_RiskId");

            migrationBuilder.AddColumn<string>(
                name: "RiskLevel",
                table: "MaintReqRisksLinked",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintReqRisksLinked",
                table: "MaintReqRisksLinked",
                columns: new[] { "MaintRequestInitiationId", "RiskId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MaintReqRisksLinked_MaintRequestInitiations_MaintRequestInitiationId",
                table: "MaintReqRisksLinked",
                column: "MaintRequestInitiationId",
                principalTable: "MaintRequestInitiations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintReqRisksLinked_Risks_RiskId",
                table: "MaintReqRisksLinked",
                column: "RiskId",
                principalTable: "Risks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
