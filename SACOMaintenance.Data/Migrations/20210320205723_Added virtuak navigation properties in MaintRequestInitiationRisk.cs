using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedvirtuaknavigationpropertiesinMaintRequestInitiationRisk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "RiskId",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MaintRequestInitiationRiskId",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MaintRequestInitiationId1",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RiskRiskId",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RisksId",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk",
                column: "MaintRequestInitiationRiskId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationRisk_MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk",
                column: "MaintRequestInitiationId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationRisk_MaintRequestInitiationId1",
                table: "MaintRequestInitiationRisk",
                column: "MaintRequestInitiationId1");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationRisk_RisksId",
                table: "MaintRequestInitiationRisk",
                column: "RisksId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk",
                column: "MaintRequestInitiationId",
                principalTable: "MaintRequestInitiations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId1",
                table: "MaintRequestInitiationRisk",
                column: "MaintRequestInitiationId1",
                principalTable: "MaintRequestInitiations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RiskId",
                table: "MaintRequestInitiationRisk",
                column: "RiskId",
                principalTable: "Risks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RisksId",
                table: "MaintRequestInitiationRisk",
                column: "RisksId",
                principalTable: "Risks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId1",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RiskId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiationRisk_Risks_RisksId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaintRequestInitiationRisk",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiationRisk_MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiationRisk_MaintRequestInitiationId1",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiationRisk_RisksId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "MaintRequestInitiationRiskId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "MaintRequestInitiationId1",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "RiskRiskId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "RisksId",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.AlterColumn<int>(
                name: "RiskId",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
