using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace template_csharp_reviews_site.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OSVer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Model", "OSVer", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Samsung", "Galaxy", "Android 10", 800.0, new DateTime(2022, 2, 14, 19, 11, 33, 866, DateTimeKind.Local).AddTicks(8763) },
                    { 2, "Apple", "iPhone 13 Pro Max", "iOS", 1099.0, new DateTime(2022, 2, 14, 19, 11, 33, 873, DateTimeKind.Local).AddTicks(2285) },
                    { 3, "Motorola", "Razr", "Android 9", 499.0, new DateTime(2022, 2, 14, 19, 11, 33, 873, DateTimeKind.Local).AddTicks(2447) },
                    { 4, "GooglePhone", "Pixel 6 Pro", "Android 12", 599.0, new DateTime(2022, 2, 14, 19, 11, 33, 873, DateTimeKind.Local).AddTicks(2474) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
