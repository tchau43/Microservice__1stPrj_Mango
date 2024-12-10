using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Service
{
    public class CartService : ICartService
	{
        private readonly IBaseService _baseService;

        public CartService(IBaseService baseService)
        {
            _baseService = baseService;
        }

		public async Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = ApiType.POST,
				Data = cartDto,
				Url = CartAPIBase + "/api/CartAPI/ApplyCoupon"
			});
		}

		public async Task<ResponseDto?> GetCartByUserIdAsync(string userId)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = ApiType.GET,
				Url = CartAPIBase + "/api/CartAPI/GetCart/" + userId
			});
		}

		public async Task<ResponseDto?> RemoveFromCartAsync(int cartDetailsId)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = ApiType.POST,
				Data = cartDetailsId,
				Url = CartAPIBase + "/api/CartAPI/RemoveCart"
			});
		}

		public async Task<ResponseDto?> UpsertCartAsync(CartDto cartDto)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = ApiType.POST,
				Data = cartDto,
				Url = CartAPIBase + "/api/CartAPI/CartUpsert/"
			});
		}
	}
}
