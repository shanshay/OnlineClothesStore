using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineClothesStore.Migrations
{
    public partial class FixFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleItemParameters",
                columns: table => new
                {
                    SaleItemParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleItemId = table.Column<int>(type: "int", nullable: false),
                    ParameterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItemParameters", x => x.SaleItemParameterId);
                    table.ForeignKey(
                        name: "FK_SaleItemParameters_Parameters_ParameterId",
                        column: x => x.ParameterId,
                        principalTable: "Parameters",
                        principalColumn: "ParameterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItemParameters_SaleItems_SaleItemId",
                        column: x => x.SaleItemId,
                        principalTable: "SaleItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItemPrices",
                columns: table => new
                {
                    SaleItemPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleItemId = table.Column<int>(type: "int", nullable: false),
                    PriceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItemPrices", x => x.SaleItemPriceId);
                    table.ForeignKey(
                        name: "FK_SaleItemPrices_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "PriceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItemPrices_SaleItems_SaleItemId",
                        column: x => x.SaleItemId,
                        principalTable: "SaleItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItemSizes",
                columns: table => new
                {
                    SaleItemSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaleItemId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItemSizes", x => x.SaleItemSizeId);
                    table.ForeignKey(
                        name: "FK_SaleItemSizes_SaleItems_SaleItemId",
                        column: x => x.SaleItemId,
                        principalTable: "SaleItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItemSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemParameters_ParameterId",
                table: "SaleItemParameters",
                column: "ParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemParameters_SaleItemId",
                table: "SaleItemParameters",
                column: "SaleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemPrices_PriceId",
                table: "SaleItemPrices",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemPrices_SaleItemId",
                table: "SaleItemPrices",
                column: "SaleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemSizes_SaleItemId",
                table: "SaleItemSizes",
                column: "SaleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItemSizes_SizeId",
                table: "SaleItemSizes",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleItemParameters");

            migrationBuilder.DropTable(
                name: "SaleItemPrices");

            migrationBuilder.DropTable(
                name: "SaleItemSizes");
        }
    }
}
