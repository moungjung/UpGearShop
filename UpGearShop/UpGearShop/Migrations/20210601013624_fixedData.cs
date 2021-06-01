using Microsoft.EntityFrameworkCore.Migrations;

namespace UpGearShop.Migrations
{
    public partial class fixedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "imageURL",
                value: "/images/products-images/yeezys.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "imageURL",
                value: "/images/products-images/yeezys2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "imageURL",
                value: "/images/products-images/yeezys3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "imageURL",
                value: "/images/products-images/yeezys");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "imageURL",
                value: "/images/products-images/yeezys2");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "imageURL",
                value: "/images/products-images/yeezys3");
        }
    }
}
