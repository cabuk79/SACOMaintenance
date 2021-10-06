using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class AddedImageLocationfieldtotheIsolationmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLocation",
                table: "Isolations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLocation",
                table: "Isolations");
        }
    }
}
