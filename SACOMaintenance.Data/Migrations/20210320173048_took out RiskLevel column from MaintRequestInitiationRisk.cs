using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class tookoutRiskLevelcolumnfromMaintRequestInitiationRisk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RiskLevel",
                table: "MaintRequestInitiationRisk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RiskLevel",
                table: "MaintRequestInitiationRisk",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
