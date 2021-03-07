using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class changedislocationsinplantRequestfrominttobool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<bool>(
                name: "IsolationNitricAcid",
                table: "PlantRequests",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsolatedSulphuricAcid",
                table: "PlantRequests",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsolatedSodiumHydroxide",
                table: "PlantRequests",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsolatedPhosphoricAcid",
                table: "PlantRequests",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsolationNitricAcid",
                table: "PlantRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsolatedSulphuricAcid",
                table: "PlantRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsolatedSodiumHydroxide",
                table: "PlantRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "IsolatedPhosphoricAcid",
                table: "PlantRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "AreaName", "CommentsNotes", "FactoryId" },
                values: new object[,]
                {
                    { 1, "Warehouse", null, null },
                    { 2, "Plant", null, null },
                    { 3, "Press Shop", null, null },
                    { 4, "Tool Room", null, null },
                    { 5, "Assembly", null, null },
                    { 6, "Offices F3", null, null },
                    { 7, "FL Production", null, null },
                    { 8, "GTL Production", null, null }
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
                table: "Factories",
                columns: new[] { "Id", "FactoryName" },
                values: new object[,]
                {
                    { 3, "F3" },
                    { 1, "F1" },
                    { 2, "F2" }
                });

            migrationBuilder.InsertData(
                table: "PPE",
                columns: new[] { "Id", "Description", "IconFileLocation", "MaintRequestType", "PPEName" },
                values: new object[,]
                {
                    { 1, "General gloves", null, null, "Gloves" },
                    { 2, "Hard covered saftey glasses", null, null, "Saftey Glasses" },
                    { 3, "Steel toe capped", null, null, "Saftery Boots" }
                });

            migrationBuilder.InsertData(
                table: "Risks",
                columns: new[] { "Id", "Description", "MaintRequestType", "RiskName" },
                values: new object[,]
                {
                    { 1, null, null, "Risk 1" },
                    { 2, null, null, "Risk 2" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 4, "Cancelled" },
                    { 1, "Open" },
                    { 2, "New" },
                    { 3, "Completed" },
                    { 5, "On Hold" }
                });
        }
    }
}
