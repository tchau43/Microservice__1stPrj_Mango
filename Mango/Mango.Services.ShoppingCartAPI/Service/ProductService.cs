using Mango.Services.ShoppingCartAPI.Models.Dto;
using Mango.Services.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;
using System.Net.Http;

namespace Mango.Services.ShoppingCartAPI.Service
{
	public class ProductService : IProductService
	{
		private readonly IHttpClientFactory _httppClientFactory;

		public ProductService(IHttpClientFactory httppClientFactory)
		{
			_httppClientFactory = httppClientFactory;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public async Task<IEnumerable<ProductDto>> GetProducts()
		{
			var client = _httppClientFactory.CreateClient("Product");//Name of client must have the same name with the declared onw in program.cs
			var response = await client.GetAsync($"/api/ProductAPI");
			var apiContent = await response.Content.ReadAsStringAsync();
			var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
			if (resp.IsSuccess)
			{
				return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(Convert.ToString(resp.Result));
			}
			return new List<ProductDto>();
		}
	}
}
