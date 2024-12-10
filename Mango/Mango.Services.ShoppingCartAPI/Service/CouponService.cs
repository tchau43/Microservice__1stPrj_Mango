using Mango.Services.ShoppingCartAPI.Models.Dto;
using Mango.Services.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;
using System.Net.Http;

namespace Mango.Services.ShoppingCartAPI.Service
{
	public class CouponService : ICouponService
	{
		private readonly IHttpClientFactory _httppClientFactory;

		public CouponService(IHttpClientFactory httppClientFactory)
		{
			_httppClientFactory = httppClientFactory;
		}

		public async Task<CouponDto> GetCoupon(string couponCode)
		{
			var client = _httppClientFactory.CreateClient("Coupon");//Name of client must have the same name with the declared onw in program.cs
			var response = await client.GetAsync($"/api/CouponAPI/GetByCode/{couponCode}");
			var apiContent = await response.Content.ReadAsStringAsync();
			var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
			if (resp.IsSuccess && resp.IsSuccess)
			{
				return JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(resp.Result));
			}
			return new CouponDto();
		}
	}
}
