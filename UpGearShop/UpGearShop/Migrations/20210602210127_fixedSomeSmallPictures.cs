using Microsoft.EntityFrameworkCore.Migrations;

namespace UpGearShop.Migrations
{
    public partial class fixedSomeSmallPictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "imageURL",
                value: "/images/products-images/yeezys.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "imageURL",
                value: "/images/products-images/yeezys.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Bright Shoes");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "imageURL",
                value: "/images/products-images/yeezys.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "imageURL",
                value: "/images/products-images/dryGinHat.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "imageURL",
                value: "/images/products-images/uglyShoes.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Hunger");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "imageURL",
                value: "/images/products-images/yeezys3.jpg");
        }
    }
}
