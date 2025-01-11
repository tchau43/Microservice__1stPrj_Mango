using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "10OFF",
                DiscountAmount = 10,
                MinAmount = 20
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "20OFF",
                DiscountAmount = 20,
                MinAmount = 40
            });
            modelBuilder.Entity<Coupon>().HasData(
    new Coupon { CouponId = 3,  CouponCode = "20SAVE",  DiscountAmount = 20,  MinAmount = 40 },
    new Coupon { CouponId = 4,  CouponCode = "25OFF",   DiscountAmount = 25,  MinAmount = 50 },
    new Coupon { CouponId = 5,  CouponCode = "30SAVE",  DiscountAmount = 30,  MinAmount = 60 },
    new Coupon { CouponId = 6,  CouponCode = "35OFF",   DiscountAmount = 35,  MinAmount = 70 },
    new Coupon { CouponId = 7,  CouponCode = "40SAVE",  DiscountAmount = 40,  MinAmount = 80 },
    new Coupon { CouponId = 8,  CouponCode = "45OFF",   DiscountAmount = 45,  MinAmount = 90 },
    new Coupon { CouponId = 9,  CouponCode = "50SAVE",  DiscountAmount = 50,  MinAmount = 100 },
    new Coupon { CouponId = 10, CouponCode = "55OFF",   DiscountAmount = 55,  MinAmount = 110 },
    new Coupon { CouponId = 11, CouponCode = "60SAVE",  DiscountAmount = 60,  MinAmount = 120 },
    new Coupon { CouponId = 12, CouponCode = "65OFF",   DiscountAmount = 65,  MinAmount = 130 },
    new Coupon { CouponId = 13, CouponCode = "70SAVE",  DiscountAmount = 70,  MinAmount = 140 },
    new Coupon { CouponId = 14, CouponCode = "75OFF",   DiscountAmount = 75,  MinAmount = 150 },
    new Coupon { CouponId = 15, CouponCode = "80SAVE",  DiscountAmount = 80,  MinAmount = 160 },
    new Coupon { CouponId = 16, CouponCode = "85OFF",   DiscountAmount = 85,  MinAmount = 170 },
    new Coupon { CouponId = 17, CouponCode = "90SAVE",  DiscountAmount = 90,  MinAmount = 180 },
    new Coupon { CouponId = 18, CouponCode = "95OFF",   DiscountAmount = 95,  MinAmount = 190 },
    new Coupon { CouponId = 19, CouponCode = "100SAVE", DiscountAmount = 100, MinAmount = 200 },
    new Coupon { CouponId = 20, CouponCode = "SAVE5",   DiscountAmount = 5,   MinAmount = 10 },
    new Coupon { CouponId = 21, CouponCode = "SAVE10",  DiscountAmount = 10,  MinAmount = 25 },
    new Coupon { CouponId = 22, CouponCode = "SAVE15",  DiscountAmount = 15,  MinAmount = 35 },
    new Coupon { CouponId = 23, CouponCode = "SAVE20",  DiscountAmount = 20,  MinAmount = 45 },
    new Coupon { CouponId = 24, CouponCode = "SAVE25",  DiscountAmount = 25,  MinAmount = 55 },
    new Coupon { CouponId = 25, CouponCode = "SAVE30",  DiscountAmount = 30,  MinAmount = 65 },
    new Coupon { CouponId = 26, CouponCode = "SAVE35",  DiscountAmount = 35,  MinAmount = 75 },
    new Coupon { CouponId = 27, CouponCode = "SAVE40",  DiscountAmount = 40,  MinAmount = 85 },
    new Coupon { CouponId = 28, CouponCode = "SAVE45",  DiscountAmount = 45,  MinAmount = 95 },
    new Coupon { CouponId = 29, CouponCode = "SAVE50",  DiscountAmount = 50,  MinAmount = 105 },
    new Coupon { CouponId = 30, CouponCode = "FREESHIP", DiscountAmount = 0,  MinAmount = 50 },
    new Coupon { CouponId = 31, CouponCode = "WELCOME10", DiscountAmount = 10,  MinAmount = 20 },
    new Coupon { CouponId = 32, CouponCode = "SUMMER15", DiscountAmount = 15,  MinAmount = 25 },
    new Coupon { CouponId = 33, CouponCode = "FALL20",   DiscountAmount = 20,  MinAmount = 30 },
    new Coupon { CouponId = 34, CouponCode = "WINTER25", DiscountAmount = 25,  MinAmount = 35 },
    new Coupon { CouponId = 35, CouponCode = "SPRING30", DiscountAmount = 30,  MinAmount = 40 },
    new Coupon { CouponId = 36, CouponCode = "HOLIDAY35", DiscountAmount = 35,  MinAmount = 45 },
    new Coupon { CouponId = 37, CouponCode = "BLACKFRIDAY40", DiscountAmount = 40, MinAmount = 50 },
    new Coupon { CouponId = 38, CouponCode = "CYBERMONDAY45", DiscountAmount = 45, MinAmount = 55 },
    new Coupon { CouponId = 39, CouponCode = "NEWYEAR50", DiscountAmount = 50, MinAmount = 60 },
    new Coupon { CouponId = 40, CouponCode = "FLASHSALE5", DiscountAmount = 5,  MinAmount = 15 },
    new Coupon { CouponId = 41, CouponCode = "FLASHSALE10", DiscountAmount = 10, MinAmount = 20 },
    new Coupon { CouponId = 42, CouponCode = "FLASHSALE15", DiscountAmount = 15, MinAmount = 25 },
    new Coupon { CouponId = 43, CouponCode = "FLASHSALE20", DiscountAmount = 20, MinAmount = 30 },
    new Coupon { CouponId = 44, CouponCode = "FLASHSALE25", DiscountAmount = 25, MinAmount = 35 },
    new Coupon { CouponId = 45, CouponCode = "VIP10",      DiscountAmount = 10, MinAmount = 50 },
    new Coupon { CouponId = 46, CouponCode = "VIP20",      DiscountAmount = 20, MinAmount = 100 },
    new Coupon { CouponId = 47, CouponCode = "VIP30",      DiscountAmount = 30, MinAmount = 150 },
    new Coupon { CouponId = 48, CouponCode = "LOYALTY5",   DiscountAmount = 5,  MinAmount = 10 },
    new Coupon { CouponId = 49, CouponCode = "LOYALTY10",  DiscountAmount = 10, MinAmount = 20 },
    new Coupon { CouponId = 50, CouponCode = "LOYALTY15",  DiscountAmount = 15, MinAmount = 30 }
);

        }
    }
}
