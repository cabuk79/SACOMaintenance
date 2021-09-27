using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedtheMaintReqUptateNotesmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Closed",
                table: "MaintRequestInitiations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AvatarLocation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MaintReqUptateNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaintRequestInitiationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintReqUptateNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintReqUptateNotes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaintReqUptateNotes_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaintReqUptateNotes_MaintRequestInitiationId",
                table: "MaintReqUptateNotes",
                column: "MaintRequestInitiationId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintReqUptateNotes_UserId",
                table: "MaintReqUptateNotes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintReqUptateNotes");

            migrationBuilder.DropColumn(
                name: "Closed",
                table: "MaintRequestInitiations");

            migrationBuilder.DropColumn(
                name: "AvatarLocation",
                table: "AspNetUsers");
        }
    }
}
