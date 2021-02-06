using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{

    //Changed the primary key in the MaintRequestInitations from GUID to int so had to drop the join tables and re create them code in UP added manually by Craig Brunton
    public partial class ChangedMaintRequestInitiationIdkeyfromGUIDtoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
               name: "MaintRequestInitiationPPE");

            migrationBuilder.DropTable(
                name: "MaintRequestInitiationRisk");

            migrationBuilder.DropTable(
                name: "MaintRequestInitiations");

           



            migrationBuilder.CreateTable(
                name: "MaintRequestInitiations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "uniqueidentifier", nullable: false),
                    DateRaised = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    RequestedById = table.Column<int>(type: "int", nullable: false),
                    RequestDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintRequestInitiations", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "MaintRequestInitiationPPE",
                columns: table => new
                {
                    MaintRequestInitiationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    MaintRequestInitiationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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





            //migrationBuilder.AlterColumn<int>(
            //    name: "MaintRequestInitiationId",
            //    table: "MaintRequestInitiationRisk",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(Guid),
            //    oldType: "uniqueidentifier");

            //migrationBuilder.AlterColumn<int>(
            //    name: "MaintRequestInitiationsId",
            //    table: "MaintRequestInitiationPPE",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(Guid),
            //    oldType: "uniqueidentifier");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "MaintRequestInitiations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaintRequestInitiationId",
                table: "MaintRequestInitiationRisk",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "MaintRequestInitiationsId",
                table: "MaintRequestInitiationPPE",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
