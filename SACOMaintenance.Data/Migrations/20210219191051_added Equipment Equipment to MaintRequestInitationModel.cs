using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class addedEquipmentEquipmenttoMaintRequestInitationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiations_EquipmentId",
                table: "MaintRequestInitiations",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Equipment_EquipmentId",
                table: "MaintRequestInitiations",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Equipment_EquipmentId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiations_EquipmentId",
                table: "MaintRequestInitiations");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
