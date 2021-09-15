using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class ChangedinsuppliermodelPsotCodetoPostCodeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostcodeId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "PostcodeId",
                table: "Suppliers",
                newName: "PostCodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Suppliers_PostcodeId",
                table: "Suppliers",
                newName: "IX_Suppliers_PostCodeId");

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
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers");

            migrationBuilder.RenameColumn(
                name: "PostCodeId",
                table: "Suppliers",
                newName: "PostcodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Suppliers_PostCodeId",
                table: "Suppliers",
                newName: "IX_Suppliers_PostcodeId");

            migrationBuilder.AddColumn<int>(
                name: "PostCode",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostcodeId",
                table: "Suppliers",
                column: "PostcodeId",
                principalTable: "PostCodeTowns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
