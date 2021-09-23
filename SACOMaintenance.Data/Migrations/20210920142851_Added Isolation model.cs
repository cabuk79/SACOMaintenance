using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedIsolationmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Isolations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isolations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IsolationMaintRequestInitiation",
                columns: table => new
                {
                    IsolationsId = table.Column<int>(type: "int", nullable: false),
                    maintReqInitationListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsolationMaintRequestInitiation", x => new { x.IsolationsId, x.maintReqInitationListId });
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiation_Isolations_IsolationsId",
                        column: x => x.IsolationsId,
                        principalTable: "Isolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IsolationMaintRequestInitiation_MaintRequestInitiations_maintReqInitationListId",
                        column: x => x.maintReqInitationListId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IsolationMaintRequestInitiation_maintReqInitationListId",
                table: "IsolationMaintRequestInitiation",
                column: "maintReqInitationListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsolationMaintRequestInitiation");

            migrationBuilder.DropTable(
                name: "Isolations");
        }
    }
}
