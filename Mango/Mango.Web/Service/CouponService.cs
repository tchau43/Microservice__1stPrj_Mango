using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.POST,
                Data = couponDto,
                Url = CouponAPIBase + "/api/CouponAPI/"
            });
        }

        public async Task<ResponseDto?> DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.DELETE,
                Url = CouponAPIBase + "/api/CouponAPI/" + id
            });
        }

        public async Task<ResponseDto?> GetAllCouponAsync()
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = CouponAPIBase + "/api/CouponAPI/"
            });
        }

        public async Task<ResponseDto?> GetCouponByCodeAsync(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = CouponAPIBase + "/api/CouponAPI/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = CouponAPIBase + "/api/CouponAPI/" + id
            });
        }

        public async Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.PUT,
                Data = couponDto,
                Url = CouponAPIBase + "/api/CouponAPI/"
            });
        }

        //public async Task<List<CouponDto>?> CreateCouponAsync(CouponDto couponDto)
        //{
        //    var response = await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.POST,
        //        Data = couponDto,
        //        Url = CouponAPIBase + "/api/CouponAPI/"
        //    });
        //    if (response is OkObjectResult okResult && okResult.Value is ResponseDto responseDto && responseDto.IsSuccess)
        //    {
        //        var result = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(responseDto.Result));
        //        return result; // Return the list of coupons
        //    }
        //    return new List<CouponDto>();
        //}

        //public async Task<IActionResult> DeleteCouponAsync(int id)
        //{
        //    var response = await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.DELETE,
        //        Url = CouponAPIBase + "/api/CouponAPI/" + id
        //    });

        //    return response;
        //}

        //public async Task<List<CouponDto>> GetAllCouponAsync()
        //{
        //    var result = new List<CouponDto>();
        //    var response = await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.GET,
        //        Url = CouponAPIBase + "/api/CouponAPI"
        //    });

        //    if (response is OkObjectResult okResult && okResult.Value is ResponseDto responseDto && responseDto.IsSuccess)
        //    {
        //        result = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(responseDto.Result));
        //        return result; // Return the list of coupons
        //    }

        //    return new List<CouponDto>(); // Return an empty list if something goes wrong
        //}

        //public async Task<List<CouponDto>?> GetCouponByCodeAsync(string couponCode)
        //{
        //    var result = new List<CouponDto>();
        //    var response = await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.GET,
        //        Url = CouponAPIBase + "/api/CouponAPI/GetByCode" + couponCode
        //    });

        //    if (response is OkObjectResult okResult && okResult.Value is ResponseDto responseDto && responseDto.IsSuccess)
        //    {
        //        result = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(responseDto.Result));
        //        return result; // Return the list of coupons
        //    }

        //    return new List<CouponDto>(); // Return an empty list if something goes wrong
        //}

        //public async Task<List<CouponDto>?> GetCouponByIdAsync(int id)
        //{
        //    var result = new List<CouponDto>();
        //    var response = await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.GET,
        //        Url = CouponAPIBase + "/api/CouponAPI" + id
        //    });

        //    if (response is OkObjectResult okResult && okResult.Value is ResponseDto responseDto && responseDto.IsSuccess)
        //    {
        //        result = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(responseDto.Result));
        //        return result; // Return the list of coupons
        //    }

        //    return new List<CouponDto>(); // Return an empty list if something goes wrong
        //}

        //public async Task<List<CouponDto>?> UpdateCouponAsync(CouponDto couponDto)
        //{
        //    var response = await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.PUT,
        //        Data = couponDto,
        //        Url = CouponAPIBase + "/api/CouponAPI/"
        //    });
        //    if (response is OkObjectResult okResult && okResult.Value is ResponseDto responseDto && responseDto.IsSuccess)
        //    {
        //        var result = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(responseDto.Result));
        //        return result; // Return the list of coupons
        //    }
        //    return new List<CouponDto>();
        //}

        //async Task<List<CouponDto>?> ICouponService.CreateCouponAsync(CouponDto couponDto)
        //{
        //    var response =  await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.POST,
        //        Data = couponDto,
        //        Url = CouponAPIBase + "/api/CouponAPI/"
        //    });
        //}

        //async Task<List<CouponDto>?> ICouponService.DeleteCouponAsync(int id)
        //{
        //    return await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.DELETE,
        //        Url = CouponAPIBase + "/api/CouponAPI/" + id
        //    });
        //}

        //async Task<List<CouponDto>?> ICouponService.GetAllCouponAsync()
        //{
        //    return await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.GET,
        //        Url = CouponAPIBase + "/api/CouponAPI"
        //    });
        //}

        //async Task<List<CouponDto>?> ICouponService.GetCouponByCodeAsync(string couponCode)
        //{
        //    return await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.GET,
        //        Url = CouponAPIBase + "/api/CouponAPI/GetByCode/" + couponCode
        //    });
        //}

        //async Task<List<CouponDto>?> ICouponService.GetCouponByIdAsync(int id)
        //{
        //    return await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.GET,
        //        Url = CouponAPIBase + "/api/CouponAPI/" + id
        //    });
        //}

        //async Task<List<CouponDto>?> ICouponService.UpdateCouponAsync(CouponDto couponDto)
        //{
        //    return await _baseService.SendAsync(new RequestDto()
        //    {
        //        ApiType = ApiType.PUT,
        //        Data = couponDto,
        //        Url = CouponAPIBase + "/api/CouponAPI/"
        //    });
        //}
    }
}
