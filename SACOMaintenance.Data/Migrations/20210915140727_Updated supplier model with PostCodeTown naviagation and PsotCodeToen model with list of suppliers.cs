using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class UpdatedsuppliermodelwithPostCodeTownnaviagationandPsotCodeToenmodelwithlistofsuppliers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostcodeId",
                table: "Suppliers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PostCodeTowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitide = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCodeTowns", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_PostcodeId",
                table: "Suppliers",
                column: "PostcodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostcodeId",
                table: "Suppliers",
                column: "PostcodeId",
                principalTable: "PostCodeTowns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostcodeId",
                table: "Suppliers");

            migrationBuilder.DropTable(
                name: "PostCodeTowns");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_PostcodeId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PostcodeId",
                table: "Suppliers");
        }
    }
}
