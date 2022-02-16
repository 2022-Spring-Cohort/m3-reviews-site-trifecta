using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class reviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ProductId", "Rating", "ReviewDate", "Title", "UserName" },
                values: new object[,]
                {
                    { 1, "I love it.", 1, 5, new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(2688), "Great.", "Lisa" },
                    { 2, "I love it.", 2, 5, new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(5393), "Great.", "Norm" },
                    { 3, "I love it.", 3, 5, new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(5574), "Great.", "Chaz" },
                    { 5, "I love it.", 1, 5, new DateTime(2022, 2, 15, 16, 36, 42, 449, DateTimeKind.Local).AddTicks(5605), "Great.", "Donna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 14, 19, 11, 33, 866, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 14, 19, 11, 33, 873, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 14, 19, 11, 33, 873, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 14, 19, 11, 33, 873, DateTimeKind.Local).AddTicks(2474));
        }
    }
}
