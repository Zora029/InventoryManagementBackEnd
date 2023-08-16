using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockAPI.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseInitialisation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyRankResults");

            migrationBuilder.CreateTable(
                name: "MostsOrdered",
                columns: table => new
                {
                    product_name = table.Column<string>(type: "TEXT", nullable: false),
                    ordered_quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TopThreeCommands",
                columns: table => new
                {
                    product_name = table.Column<string>(type: "TEXT", nullable: false),
                    commanded_quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    product_description = table.Column<string>(type: "TEXT", nullable: false),
                    product_image = table.Column<string>(type: "TEXT", nullable: false),
                    command_number = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TopThreeOrders",
                columns: table => new
                {
                    product_name = table.Column<string>(type: "TEXT", nullable: false),
                    ordered_quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    product_description = table.Column<string>(type: "TEXT", nullable: false),
                    product_image = table.Column<string>(type: "TEXT", nullable: false),
                    order_number = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MostsOrdered");

            migrationBuilder.DropTable(
                name: "TopThreeCommands");

            migrationBuilder.DropTable(
                name: "TopThreeOrders");

            migrationBuilder.CreateTable(
                name: "MonthlyRankResults",
                columns: table => new
                {
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalSorties = table.Column<int>(type: "INTEGER", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    design = table.Column<string>(type: "TEXT", nullable: false),
                    image = table.Column<string>(type: "TEXT", nullable: false),
                    num_produit = table.Column<string>(type: "TEXT", nullable: false),
                    quantite = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                });
        }
    }
}
