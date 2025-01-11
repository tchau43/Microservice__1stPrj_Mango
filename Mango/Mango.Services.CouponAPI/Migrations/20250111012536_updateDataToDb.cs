using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateDataToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<double>(type: "float", nullable: false),
                    MinAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.CouponId);
                });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "CouponId", "CouponCode", "DiscountAmount", "MinAmount" },
                values: new object[,]
                {
                    { 1, "10OFF", 10.0, 20 },
                    { 2, "20OFF", 20.0, 40 },
                    { 3, "20SAVE", 20.0, 40 },
                    { 4, "25OFF", 25.0, 50 },
                    { 5, "30SAVE", 30.0, 60 },
                    { 6, "35OFF", 35.0, 70 },
                    { 7, "40SAVE", 40.0, 80 },
                    { 8, "45OFF", 45.0, 90 },
                    { 9, "50SAVE", 50.0, 100 },
                    { 10, "55OFF", 55.0, 110 },
                    { 11, "60SAVE", 60.0, 120 },
                    { 12, "65OFF", 65.0, 130 },
                    { 13, "70SAVE", 70.0, 140 },
                    { 14, "75OFF", 75.0, 150 },
                    { 15, "80SAVE", 80.0, 160 },
                    { 16, "85OFF", 85.0, 170 },
                    { 17, "90SAVE", 90.0, 180 },
                    { 18, "95OFF", 95.0, 190 },
                    { 19, "100SAVE", 100.0, 200 },
                    { 20, "SAVE5", 5.0, 10 },
                    { 21, "SAVE10", 10.0, 25 },
                    { 22, "SAVE15", 15.0, 35 },
                    { 23, "SAVE20", 20.0, 45 },
                    { 24, "SAVE25", 25.0, 55 },
                    { 25, "SAVE30", 30.0, 65 },
                    { 26, "SAVE35", 35.0, 75 },
                    { 27, "SAVE40", 40.0, 85 },
                    { 28, "SAVE45", 45.0, 95 },
                    { 29, "SAVE50", 50.0, 105 },
                    { 30, "FREESHIP", 0.0, 50 },
                    { 31, "WELCOME10", 10.0, 20 },
                    { 32, "SUMMER15", 15.0, 25 },
                    { 33, "FALL20", 20.0, 30 },
                    { 34, "WINTER25", 25.0, 35 },
                    { 35, "SPRING30", 30.0, 40 },
                    { 36, "HOLIDAY35", 35.0, 45 },
                    { 37, "BLACKFRIDAY40", 40.0, 50 },
                    { 38, "CYBERMONDAY45", 45.0, 55 },
                    { 39, "NEWYEAR50", 50.0, 60 },
                    { 40, "FLASHSALE5", 5.0, 15 },
                    { 41, "FLASHSALE10", 10.0, 20 },
                    { 42, "FLASHSALE15", 15.0, 25 },
                    { 43, "FLASHSALE20", 20.0, 30 },
                    { 44, "FLASHSALE25", 25.0, 35 },
                    { 45, "VIP10", 10.0, 50 },
                    { 46, "VIP20", 20.0, 100 },
                    { 47, "VIP30", 30.0, 150 },
                    { 48, "LOYALTY5", 5.0, 10 },
                    { 49, "LOYALTY10", 10.0, 20 },
                    { 50, "LOYALTY15", 15.0, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupons");
        }
    }
}
