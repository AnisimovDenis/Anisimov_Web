using Microsoft.EntityFrameworkCore.Migrations;

namespace Anisimov.DAL.Migrations
{
    public partial class AddedProductSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sale",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sale",
                table: "Products");
        }
    }
}
