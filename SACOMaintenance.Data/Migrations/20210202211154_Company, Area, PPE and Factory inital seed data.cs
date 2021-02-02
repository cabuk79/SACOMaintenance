using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class CompanyAreaPPEandFactoryinitalseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "AreaName" },
                values: new object[,]
                {
                    { 1, "Warehouse" },
                    { 2, "Plant" },
                    { 3, "Press Shop" },
                    { 4, "Tool Room" },
                    { 5, "Assembly" },
                    { 6, "Offices F3" },
                    { 7, "FL Production" },
                    { 8, "GTL Production" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompantName" },
                values: new object[,]
                {
                    { 1, "SACO" },
                    { 2, "Nekem" },
                    { 3, "FL" }
                });

            migrationBuilder.InsertData(
                table: "PPE",
                columns: new[] { "Id", "Description", "PPEName" },
                values: new object[,]
                {
                    { 1, "General gloves", "Gloves" },
                    { 2, "Hard covered saftey glasses", "Saftey Glasses" },
                    { 3, "Steel toe capped", "Saftery Boots" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PPE",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PPE",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PPE",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
