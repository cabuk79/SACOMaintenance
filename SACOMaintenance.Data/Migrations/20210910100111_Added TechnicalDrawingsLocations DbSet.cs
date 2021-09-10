using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedTechnicalDrawingsLocationsDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalDrawingsLocation_Parts_PartId",
                table: "TechnicalDrawingsLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TechnicalDrawingsLocation",
                table: "TechnicalDrawingsLocation");

            migrationBuilder.RenameTable(
                name: "TechnicalDrawingsLocation",
                newName: "TechnicalDrawingsLocations");

            migrationBuilder.RenameIndex(
                name: "IX_TechnicalDrawingsLocation_PartId",
                table: "TechnicalDrawingsLocations",
                newName: "IX_TechnicalDrawingsLocations_PartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechnicalDrawingsLocations",
                table: "TechnicalDrawingsLocations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalDrawingsLocations_Parts_PartId",
                table: "TechnicalDrawingsLocations",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalDrawingsLocations_Parts_PartId",
                table: "TechnicalDrawingsLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TechnicalDrawingsLocations",
                table: "TechnicalDrawingsLocations");

            migrationBuilder.RenameTable(
                name: "TechnicalDrawingsLocations",
                newName: "TechnicalDrawingsLocation");

            migrationBuilder.RenameIndex(
                name: "IX_TechnicalDrawingsLocations_PartId",
                table: "TechnicalDrawingsLocation",
                newName: "IX_TechnicalDrawingsLocation_PartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TechnicalDrawingsLocation",
                table: "TechnicalDrawingsLocation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalDrawingsLocation_Parts_PartId",
                table: "TechnicalDrawingsLocation",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
