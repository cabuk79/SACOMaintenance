using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedDpeartmentIdtoMaintReqmodelandListofmaintregsnavpropertytoDeparmentmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "MaintRequestInitiations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiations_DepartmentId",
                table: "MaintRequestInitiations",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintRequestInitiations_Departments_DepartmentId",
                table: "MaintRequestInitiations",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MaintRequestInitiations_Departments_DepartmentId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropIndex(
                name: "IX_MaintRequestInitiations_DepartmentId",
                table: "MaintRequestInitiations");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "MaintRequestInitiations");
        }
    }
}
