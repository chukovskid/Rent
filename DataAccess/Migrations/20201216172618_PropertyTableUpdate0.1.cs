using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class PropertyTableUpdate01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstateType",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "Properties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstateType",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Properties");
        }
    }
}
