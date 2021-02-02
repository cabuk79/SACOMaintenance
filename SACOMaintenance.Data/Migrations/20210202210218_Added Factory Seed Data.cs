using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedFactorySeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Factories",
                columns: new[] { "Id", "FactoryName" },
                values: new object[] { 1, "F1" });

            migrationBuilder.InsertData(
                table: "Factories",
                columns: new[] { "Id", "FactoryName" },
                values: new object[] { 2, "F2" });

            migrationBuilder.InsertData(
                table: "Factories",
                columns: new[] { "Id", "FactoryName" },
                values: new object[] { 3, "F3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Factories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Factories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Factories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
