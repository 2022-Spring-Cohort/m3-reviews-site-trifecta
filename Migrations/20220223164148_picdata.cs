using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class picdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Picture", "ReleaseDate" },
                values: new object[] { "https://th.bing.com/th/id/OIP.KaKM93VZeh0ZQH0ylnub2gHaHa?pid=ImgDet&rs=1", new DateTime(2022, 2, 23, 11, 41, 47, 802, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Picture", "ReleaseDate" },
                values: new object[] { "https://th.bing.com/th/id/R.708c4252d828ae9a7f2eb797f7577b30?rik=4b1OYH%2bB6nrH2g&pid=ImgRaw&r=0", new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Picture", "ReleaseDate" },
                values: new object[] { "https://th.bing.com/th/id/OIP.oMxlQYNUc6msuFWHGQOglgHaHc?pid=ImgDet&rs=1", new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Picture", "ReleaseDate" },
                values: new object[] { "https://touchit.sk/wp-content/uploads/2021/05/google_pixel_6_6_pro_duo_nowat.jpg", new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 23, 11, 41, 47, 811, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 23, 11, 41, 47, 811, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 23, 11, 41, 47, 811, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 439, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReviewDate",
                value: new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(5605));
        }
    }
}
