using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddednewStatustableaddedpropertiesintoUserclassandaddedStatusseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("MaintRequestInitiationPPE");
            migrationBuilder.DropTable("MaintRequestInitiationRisk");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintRequestInitiationUser",
                columns: table => new
                {
                    MaintRequestInitiationId = table.Column<int>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintRequestInitiationUser", x => new { x.MaintRequestInitiationId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationUser_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "New" },
                    { 3, "Completed" },
                    { 4, "Cancelled" },
                    { 5, "On Hold" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationUser_UsersId",
                table: "MaintRequestInitiationUser",
                column: "UsersId");

            migrationBuilder.CreateTable(
               name: "MaintRequestInitiationPPE",
               columns: table => new
               {
                   MaintRequestInitiationsId = table.Column<int>(type: "uniqueidentifier", nullable: false),
                   PPEEquipmentId = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_MaintRequestInitiationPPE", x => new { x.MaintRequestInitiationsId, x.PPEEquipmentId });
                   table.ForeignKey(
                       name: "FK_MaintRequestInitiationPPE_MaintRequestInitiations_MaintRequestInitiationsId",
                       column: x => x.MaintRequestInitiationsId,
                       principalTable: "MaintRequestInitiations",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
                   table.ForeignKey(
                       name: "FK_MaintRequestInitiationPPE_PPE_PPEEquipmentId",
                       column: x => x.PPEEquipmentId,
                       principalTable: "PPE",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Cascade);
               });

            migrationBuilder.CreateTable(
                name: "MaintRequestInitiationRisk",
                columns: table => new
                {
                    MaintRequestInitiationId = table.Column<int>(type: "uniqueidentifier", nullable: false),
                    RisksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintRequestInitiationRisk", x => new { x.MaintRequestInitiationId, x.RisksId });
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationRisk_Risks_RisksId",
                        column: x => x.RisksId,
                        principalTable: "Risks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintRequestInitiationUser");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MaintRequestInitiations");
        }
    }
}
