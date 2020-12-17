using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class PropertyTableInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Space = table.Column<int>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Rooms = table.Column<int>(nullable: false),
                    Bedrooms = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false),
                    FurnishType = table.Column<string>(nullable: true),
                    Bathrooms = table.Column<int>(nullable: false),
                    Balcony = table.Column<string>(nullable: true),
                    Orientation = table.Column<string>(nullable: true),
                    AC = table.Column<bool>(nullable: false),
                    SteamHeating = table.Column<bool>(nullable: false),
                    Elevator = table.Column<bool>(nullable: false),
                    NewBuilding = table.Column<bool>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Deposit = table.Column<int>(nullable: false),
                    Brokerage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
