using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedaOKtotheAuthroizationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorizationRequests_AspNetUsers_UserId",
                table: "AuthorizationRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorizationRequests",
                table: "AuthorizationRequests");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AuthorizationRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AuthorizationRequests",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorizationRequests",
                table: "AuthorizationRequests",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizationRequests_MaintRequestInitiationId",
                table: "AuthorizationRequests",
                column: "MaintRequestInitiationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationRequests_AspNetUsers_UserId",
                table: "AuthorizationRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorizationRequests_AspNetUsers_UserId",
                table: "AuthorizationRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthorizationRequests",
                table: "AuthorizationRequests");

            migrationBuilder.DropIndex(
                name: "IX_AuthorizationRequests_MaintRequestInitiationId",
                table: "AuthorizationRequests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AuthorizationRequests");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AuthorizationRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthorizationRequests",
                table: "AuthorizationRequests",
                columns: new[] { "MaintRequestInitiationId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorizationRequests_AspNetUsers_UserId",
                table: "AuthorizationRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
