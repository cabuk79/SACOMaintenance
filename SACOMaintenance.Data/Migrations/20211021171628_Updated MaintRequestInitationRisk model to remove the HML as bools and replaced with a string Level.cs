using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class UpdatedMaintRequestInitationRiskmodeltoremovetheHMLasboolsandreplacedwithastringLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "H",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "L",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.DropColumn(
                name: "M",
                table: "MaintRequestInitiationRisk");

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "MaintRequestInitiationRisk",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "MaintRequestInitiationRisk");

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
        }
    }
}
