using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedPrioritesmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers");

            migrationBuilder.AlterColumn<int>(
                name: "PostCodeId",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Priorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorites", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiations_PriorityId",
                table: "MaintRequestInitiations",
                column: "PriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Priorites_PriorityId",
                table: "MaintRequestInitiations",
                column: "PriorityId",
                principalTable: "Priorites",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Priorites_PriorityId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers");

            migrationBuilder.DropTable(
                name: "Priorites");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiations_PriorityId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "MaintRequestInitiations");

            migrationBuilder.AlterColumn<int>(
                name: "PostCodeId",
                table: "Suppliers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_PostCodeTowns_PostCodeId",
                table: "Suppliers",
                column: "PostCodeId",
                principalTable: "PostCodeTowns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
