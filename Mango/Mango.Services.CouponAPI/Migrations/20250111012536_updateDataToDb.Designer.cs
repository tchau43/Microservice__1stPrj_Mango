﻿// <auto-generated />
using Mango.Services.CouponAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mango.Services.CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250111012536_updateDataToDb")]
    partial class updateDataToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mango.Services.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "10OFF",
                            DiscountAmount = 10.0,
                            MinAmount = 20
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "20OFF",
                            DiscountAmount = 20.0,
                            MinAmount = 40
                        },
                        new
                        {
                            CouponId = 3,
                            CouponCode = "20SAVE",
                            DiscountAmount = 20.0,
                            MinAmount = 40
                        },
                        new
                        {
                            CouponId = 4,
                            CouponCode = "25OFF",
                            DiscountAmount = 25.0,
                            MinAmount = 50
                        },
                        new
                        {
                            CouponId = 5,
                            CouponCode = "30SAVE",
                            DiscountAmount = 30.0,
                            MinAmount = 60
                        },
                        new
                        {
                            CouponId = 6,
                            CouponCode = "35OFF",
                            DiscountAmount = 35.0,
                            MinAmount = 70
                        },
                        new
                        {
                            CouponId = 7,
                            CouponCode = "40SAVE",
                            DiscountAmount = 40.0,
                            MinAmount = 80
                        },
                        new
                        {
                            CouponId = 8,
                            CouponCode = "45OFF",
                            DiscountAmount = 45.0,
                            MinAmount = 90
                        },
                        new
                        {
                            CouponId = 9,
                            CouponCode = "50SAVE",
                            DiscountAmount = 50.0,
                            MinAmount = 100
                        },
                        new
                        {
                            CouponId = 10,
                            CouponCode = "55OFF",
                            DiscountAmount = 55.0,
                            MinAmount = 110
                        },
                        new
                        {
                            CouponId = 11,
                            CouponCode = "60SAVE",
                            DiscountAmount = 60.0,
                            MinAmount = 120
                        },
                        new
                        {
                            CouponId = 12,
                            CouponCode = "65OFF",
                            DiscountAmount = 65.0,
                            MinAmount = 130
                        },
                        new
                        {
                            CouponId = 13,
                            CouponCode = "70SAVE",
                            DiscountAmount = 70.0,
                            MinAmount = 140
                        },
                        new
                        {
                            CouponId = 14,
                            CouponCode = "75OFF",
                            DiscountAmount = 75.0,
                            MinAmount = 150
                        },
                        new
                        {
                            CouponId = 15,
                            CouponCode = "80SAVE",
                            DiscountAmount = 80.0,
                            MinAmount = 160
                        },
                        new
                        {
                            CouponId = 16,
                            CouponCode = "85OFF",
                            DiscountAmount = 85.0,
                            MinAmount = 170
                        },
                        new
                        {
                            CouponId = 17,
                            CouponCode = "90SAVE",
                            DiscountAmount = 90.0,
                            MinAmount = 180
                        },
                        new
                        {
                            CouponId = 18,
                            CouponCode = "95OFF",
                            DiscountAmount = 95.0,
                            MinAmount = 190
                        },
                        new
                        {
                            CouponId = 19,
                            CouponCode = "100SAVE",
                            DiscountAmount = 100.0,
                            MinAmount = 200
                        },
                        new
                        {
                            CouponId = 20,
                            CouponCode = "SAVE5",
                            DiscountAmount = 5.0,
                            MinAmount = 10
                        },
                        new
                        {
                            CouponId = 21,
                            CouponCode = "SAVE10",
                            DiscountAmount = 10.0,
                            MinAmount = 25
                        },
                        new
                        {
                            CouponId = 22,
                            CouponCode = "SAVE15",
                            DiscountAmount = 15.0,
                            MinAmount = 35
                        },
                        new
                        {
                            CouponId = 23,
                            CouponCode = "SAVE20",
                            DiscountAmount = 20.0,
                            MinAmount = 45
                        },
                        new
                        {
                            CouponId = 24,
                            CouponCode = "SAVE25",
                            DiscountAmount = 25.0,
                            MinAmount = 55
                        },
                        new
                        {
                            CouponId = 25,
                            CouponCode = "SAVE30",
                            DiscountAmount = 30.0,
                            MinAmount = 65
                        },
                        new
                        {
                            CouponId = 26,
                            CouponCode = "SAVE35",
                            DiscountAmount = 35.0,
                            MinAmount = 75
                        },
                        new
                        {
                            CouponId = 27,
                            CouponCode = "SAVE40",
                            DiscountAmount = 40.0,
                            MinAmount = 85
                        },
                        new
                        {
                            CouponId = 28,
                            CouponCode = "SAVE45",
                            DiscountAmount = 45.0,
                            MinAmount = 95
                        },
                        new
                        {
                            CouponId = 29,
                            CouponCode = "SAVE50",
                            DiscountAmount = 50.0,
                            MinAmount = 105
                        },
                        new
                        {
                            CouponId = 30,
                            CouponCode = "FREESHIP",
                            DiscountAmount = 0.0,
                            MinAmount = 50
                        },
                        new
                        {
                            CouponId = 31,
                            CouponCode = "WELCOME10",
                            DiscountAmount = 10.0,
                            MinAmount = 20
                        },
                        new
                        {
                            CouponId = 32,
                            CouponCode = "SUMMER15",
                            DiscountAmount = 15.0,
                            MinAmount = 25
                        },
                        new
                        {
                            CouponId = 33,
                            CouponCode = "FALL20",
                            DiscountAmount = 20.0,
                            MinAmount = 30
                        },
                        new
                        {
                            CouponId = 34,
                            CouponCode = "WINTER25",
                            DiscountAmount = 25.0,
                            MinAmount = 35
                        },
                        new
                        {
                            CouponId = 35,
                            CouponCode = "SPRING30",
                            DiscountAmount = 30.0,
                            MinAmount = 40
                        },
                        new
                        {
                            CouponId = 36,
                            CouponCode = "HOLIDAY35",
                            DiscountAmount = 35.0,
                            MinAmount = 45
                        },
                        new
                        {
                            CouponId = 37,
                            CouponCode = "BLACKFRIDAY40",
                            DiscountAmount = 40.0,
                            MinAmount = 50
                        },
                        new
                        {
                            CouponId = 38,
                            CouponCode = "CYBERMONDAY45",
                            DiscountAmount = 45.0,
                            MinAmount = 55
                        },
                        new
                        {
                            CouponId = 39,
                            CouponCode = "NEWYEAR50",
                            DiscountAmount = 50.0,
                            MinAmount = 60
                        },
                        new
                        {
                            CouponId = 40,
                            CouponCode = "FLASHSALE5",
                            DiscountAmount = 5.0,
                            MinAmount = 15
                        },
                        new
                        {
                            CouponId = 41,
                            CouponCode = "FLASHSALE10",
                            DiscountAmount = 10.0,
                            MinAmount = 20
                        },
                        new
                        {
                            CouponId = 42,
                            CouponCode = "FLASHSALE15",
                            DiscountAmount = 15.0,
                            MinAmount = 25
                        },
                        new
                        {
                            CouponId = 43,
                            CouponCode = "FLASHSALE20",
                            DiscountAmount = 20.0,
                            MinAmount = 30
                        },
                        new
                        {
                            CouponId = 44,
                            CouponCode = "FLASHSALE25",
                            DiscountAmount = 25.0,
                            MinAmount = 35
                        },
                        new
                        {
                            CouponId = 45,
                            CouponCode = "VIP10",
                            DiscountAmount = 10.0,
                            MinAmount = 50
                        },
                        new
                        {
                            CouponId = 46,
                            CouponCode = "VIP20",
                            DiscountAmount = 20.0,
                            MinAmount = 100
                        },
                        new
                        {
                            CouponId = 47,
                            CouponCode = "VIP30",
                            DiscountAmount = 30.0,
                            MinAmount = 150
                        },
                        new
                        {
                            CouponId = 48,
                            CouponCode = "LOYALTY5",
                            DiscountAmount = 5.0,
                            MinAmount = 10
                        },
                        new
                        {
                            CouponId = 49,
                            CouponCode = "LOYALTY10",
                            DiscountAmount = 10.0,
                            MinAmount = 20
                        },
                        new
                        {
                            CouponId = 50,
                            CouponCode = "LOYALTY15",
                            DiscountAmount = 15.0,
                            MinAmount = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
