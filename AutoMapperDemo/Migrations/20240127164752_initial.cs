using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMapperDemoData.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductsComplex",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Depth = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Height = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Weight = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Width = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsComplex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSOwned",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Height = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Width = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Depth = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Dimension_Weight = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSOwned", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsComplex");

            migrationBuilder.DropTable(
                name: "ProductSOwned");
        }
    }
}
