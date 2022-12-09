using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AstonShop.Servises.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProductModelToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameProduct = table.Column<string>(name: "Name_Product", type: "text", nullable: false),
                    PriceProduct = table.Column<double>(name: "Price_Product", type: "double precision", nullable: false),
                    DescriptionProduct = table.Column<string>(name: "Description_Product", type: "text", nullable: false),
                    CategoryNameProduct = table.Column<string>(name: "CategoryName_Product", type: "text", nullable: false),
                    ImageUrlProduct = table.Column<string>(name: "ImageUrl_Product", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
