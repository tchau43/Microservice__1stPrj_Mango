using Mango.Web.Models;
using Mango.Web.Service.IService;
using static Mango.Web.Utility.SD;

namespace Mango.Web.Service
{
    public class ProductService : IProductService
    {
        private readonly IBaseService _baseService;

        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateProductAsync(ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.POST,
                Data = productDto,
                Url = ProductAPIBase + "/api/ProductAPI/"
            });
        }

        public async Task<ResponseDto?> DeleteProductAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.DELETE,
                Url = ProductAPIBase + "/api/ProductAPI/" + id
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = ProductAPIBase + "/api/ProductAPI/" + id
            });
        }

        public async Task<ResponseDto?> GetProductByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllProductAsync()
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.GET,
                Url = ProductAPIBase + "/api/ProductAPI/"
            });
        }

        public async Task<ResponseDto?> UpdateProductAsync(int id, ProductDto productDto)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = ApiType.PUT,
                Data = productDto,
                Url = ProductAPIBase + "/api/ProductAPI/" + id
            });
        }
    }
}
