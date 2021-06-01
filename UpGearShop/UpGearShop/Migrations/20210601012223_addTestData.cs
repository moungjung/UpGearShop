using Microsoft.EntityFrameworkCore.Migrations;

namespace UpGearShop.Migrations
{
    public partial class addTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageURL",
                table: "Products");
        }
    }
}
