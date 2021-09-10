using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedMachineTypemodeltoEquipmentandalistofEquipmentinMachineTypemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Equipment_MachineTypeId",
                table: "Equipment",
                column: "MachineTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_MachineTypes_MachineTypeId",
                table: "Equipment",
                column: "MachineTypeId",
                principalTable: "MachineTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_MachineTypes_MachineTypeId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_MachineTypeId",
                table: "Equipment");
        }
    }
}
