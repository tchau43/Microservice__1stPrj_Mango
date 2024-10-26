using Mango.Web.Models;
using Mango.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;

        public CouponController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        public async Task<IActionResult> CouponIndex()
        {
            var couponList = new List<CouponDto>();
            var response = await _couponService.GetAllCouponAsync();
            if (response != null && response.IsSuccess)
            {
                couponList = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["Error"] = response?.Message;
            }
            return View(couponList); // Directly pass the list to the view
        }

        public async Task<IActionResult> CreateCoupon()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoupon(CouponDto couponDto)
        {
            if (ModelState.IsValid)
            {
                //var couponList = new List<CouponDto>();
                var response = await _couponService.CreateCouponAsync(couponDto);
                if (response != null && response.IsSuccess)
                {
                    TempData["Success"] = "Coupon created successfully";
                    //couponList = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result));
                    return RedirectToAction("CouponIndex");
                }
                else
                {
                    TempData["Error"] = response?.Message;
                }
            }
            return View(couponDto);
        }

        public async Task<IActionResult> DeleteCoupon(int id)
        {
            if (ModelState.IsValid)
            {
                //var couponList = new List<CouponDto>();
                var response = await _couponService.GetCouponByIdAsync(id);
                if (response != null && response.IsSuccess)
                {
                    var result = JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(response.Result));
                    return View(result);
                }
                else
                {
                    TempData["Error"] = response?.Message;
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCoupon(CouponDto coupon)
        {
            //var couponList = new List<CouponDto>();
            var response = await _couponService.DeleteCouponAsync(coupon.CouponId);
            if (response != null && response.IsSuccess)
            {
                TempData["Success"] = "Coupon deleted successfully";
                return RedirectToAction("CouponIndex");
            }
            else
            {
                TempData["Error"] = response?.Message;
            }
            return View(coupon);
        }
    }
}

