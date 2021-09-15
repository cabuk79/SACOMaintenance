using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedPsotCodemodelandupdatedSuppliermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressLineOne",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLineTwo",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneralEmailAddress",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostCode",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLineOne",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "AddressLineTwo",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "GeneralEmailAddress",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Suppliers");
        }
    }
}
