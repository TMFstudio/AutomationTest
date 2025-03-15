using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductDataApi.Migrations
{
    /// <inheritdoc />
    public partial class initilize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Datetime", "Description", "Name", "Price", "ProductType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4226), "bla bla bla", "iphone11", 300m, 1 },
                    { 2, new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4236), "bla bla bla", "iphone13", 400m, 1 },
                    { 3, new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4237), "bla bla bla", "iphone14", 500m, 1 },
                    { 4, new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4238), "bla bla bla", "samsung s23", 500m, 3 },
                    { 5, new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4239), "bla bla bla", "samsung note12", 300m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
