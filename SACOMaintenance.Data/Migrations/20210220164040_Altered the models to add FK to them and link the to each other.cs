using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AlteredthemodelstoaddFKtothemandlinkthetoeachother : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaintReqiestId",
                table: "RequestDailyRegisters",
                newName: "PlantMaintRequestId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "MaintRequestInitiations",
                newName: "StatusId");

            migrationBuilder.AddColumn<int>(
                name: "PlantRequestId",
                table: "RequestDailyRegisters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaintRequestInitiationId",
                table: "PlantRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AssignedTo",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaintRequestInitiationId",
                table: "GeneralRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Equipment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "Areas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FactoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FactoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FactoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "FactoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "FactoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "FactoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                column: "FactoryId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                column: "FactoryId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_RequestDailyRegisters_PlantRequestId",
                table: "RequestDailyRegisters",
                column: "PlantRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PlantRequests_MaintRequestInitiationId",
                table: "PlantRequests",
                column: "MaintRequestInitiationId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiations_AreaId",
                table: "MaintRequestInitiations",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiations_CompanyId",
                table: "MaintRequestInitiations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiations_FactoryId",
                table: "MaintRequestInitiations",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiations_StatusId",
                table: "MaintRequestInitiations",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralRequests_MaintRequestInitiationId",
                table: "GeneralRequests",
                column: "MaintRequestInitiationId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_AreaId",
                table: "Equipment",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_FactoryId",
                table: "Areas",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Factories_FactoryId",
                table: "Areas",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Areas_AreaId",
                table: "Equipment",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralRequests_MaintRequestInitiations_MaintRequestInitiationId",
                table: "GeneralRequests",
                column: "MaintRequestInitiationId",
                principalTable: "MaintRequestInitiations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Areas_AreaId",
                table: "MaintRequestInitiations",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Companies_CompanyId",
                table: "MaintRequestInitiations",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Factories_FactoryId",
                table: "MaintRequestInitiations",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Statuses_StatusId",
                table: "MaintRequestInitiations",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlantRequests_MaintRequestInitiations_MaintRequestInitiationId",
                table: "PlantRequests",
                column: "MaintRequestInitiationId",
                principalTable: "MaintRequestInitiations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestDailyRegisters_PlantRequests_PlantRequestId",
                table: "RequestDailyRegisters",
                column: "PlantRequestId",
                principalTable: "PlantRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Factories_FactoryId",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Areas_AreaId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_GeneralRequests_MaintRequestInitiations_MaintRequestInitiationId",
                table: "GeneralRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Areas_AreaId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Companies_CompanyId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Factories_FactoryId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Statuses_StatusId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_PlantRequests_MaintRequestInitiations_MaintRequestInitiationId",
                table: "PlantRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestDailyRegisters_PlantRequests_PlantRequestId",
                table: "RequestDailyRegisters");

            migrationBuilder.DropIndex(
                name: "IX_RequestDailyRegisters_PlantRequestId",
                table: "RequestDailyRegisters");

            migrationBuilder.DropIndex(
                name: "IX_PlantRequests_MaintRequestInitiationId",
                table: "PlantRequests");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiations_AreaId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiations_CompanyId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiations_FactoryId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiations_StatusId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropIndex(
                name: "IX_GeneralRequests_MaintRequestInitiationId",
                table: "GeneralRequests");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_AreaId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Areas_FactoryId",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "PlantRequestId",
                table: "RequestDailyRegisters");

            migrationBuilder.DropColumn(
                name: "MaintRequestInitiationId",
                table: "PlantRequests");

            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "MaintRequestInitiations");

            migrationBuilder.DropColumn(
                name: "MaintRequestInitiationId",
                table: "GeneralRequests");

            migrationBuilder.RenameColumn(
                name: "PlantMaintRequestId",
                table: "RequestDailyRegisters",
                newName: "MaintReqiestId");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "MaintRequestInitiations",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AreaId",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FactoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "FactoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "FactoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "FactoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "FactoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "FactoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                column: "FactoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                column: "FactoryId",
                value: 0);
        }
    }
}
