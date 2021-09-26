using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class Workedonandremovedthefieldsthatarenullableetc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Factories_FactoryId",
                table: "Areas");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Areas_AreaId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Areas_AreaId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Companies_CompanyId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Equipment_EquipmentId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Factories_FactoryId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Priorites_PriorityId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Parts_PartId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "CompantName",
                table: "Companies",
                newName: "CompanyName");

            migrationBuilder.AlterColumn<int>(
                name: "PostCodeId",
                table: "Suppliers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PartId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "EquipmentId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Factories_FactoryId",
                table: "Areas",
                column: "FactoryId",
                principalTable: "Factories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Areas_AreaId",
                table: "Equipment",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Areas_AreaId",
                table: "MaintRequestInitiations",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Companies_CompanyId",
                table: "MaintRequestInitiations",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Equipment_EquipmentId",
                table: "MaintRequestInitiations",
                column: "EquipmentId",
                principalTable: "Equipment",
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
                name: "FK_MaintRequestInitiations_Priorites_PriorityId",
                table: "MaintRequestInitiations",
                column: "PriorityId",
                principalTable: "Priorites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Parts_PartId",
                table: "OrderItems",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers",
                column: "PostCodeId",
                principalTable: "PostCodeTowns",
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
                name: "FK_MaintRequestInitiations_Areas_AreaId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Companies_CompanyId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Equipment_EquipmentId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Factories_FactoryId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Priorites_PriorityId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Parts_PartId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Companies",
                newName: "CompantName");

            migrationBuilder.AlterColumn<int>(
                name: "PostCodeId",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PartId",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PriorityId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
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
                name: "FK_MaintRequestInitiations_Equipment_EquipmentId",
                table: "MaintRequestInitiations",
                column: "EquipmentId",
                principalTable: "Equipment",
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
                name: "FK_MaintRequestInitiations_Priorites_PriorityId",
                table: "MaintRequestInitiations",
                column: "PriorityId",
                principalTable: "Priorites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Parts_PartId",
                table: "OrderItems",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers",
                column: "PostCodeId",
                principalTable: "PostCodeTowns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
