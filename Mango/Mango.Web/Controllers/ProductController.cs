using Mango.Web.Models;
using Mango.Web.Service;
using Mango.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> ProductIndex()
        {
            var productList = new List<ProductDto>();
            var response = await _productService.GetAllProductAsync();
            if (response != null && response.IsSuccess)
            {
                productList = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["Error"] = response?.Message;
            }
            return View(productList);
        }

        public async Task<IActionResult> CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto productDto)
        {
            if(ModelState.IsValid)
            {
                var response = await _productService.CreateProductAsync(productDto);
                if (response != null && response.IsSuccess)
                {
                    TempData["Success"] = "Create Successfully";
                    return RedirectToAction("ProductIndex");
                }
                else
                {
                    TempData["Error"] = response?.Message;
                }
            }
            return View(productDto);
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var response = await _productService.GetProductByIdAsync(id);
            if (response != null && response.IsSuccess)
            {
                ProductDto? model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(ProductDto productDto)
        {
            var response = await _productService.DeleteProductAsync(productDto.ProductId);
            if (response != null && response.IsSuccess)
            {
                TempData["Success"] = "Delete Successfully";
                return RedirectToAction(nameof(ProductIndex));
            }
            else
            {
                TempData["Error"] = response?.Message;
            }
            return View(productDto);
        }

        public async Task<IActionResult> EditProduct(int id)
        {
            var response = await _productService.GetProductByIdAsync(id);
            if (response != null && response.IsSuccess)
            {
                ProductDto? model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductDto productDto)
        {
            var response = await _productService.UpdateProductAsync(productDto.ProductId, productDto);
            if (response != null && response.IsSuccess)
            {
                TempData["Success"] = "Update Successfully";
                return RedirectToAction(nameof(ProductIndex));
            }
            else
            {
                TempData["Error"] = response?.Message;
            }
            return View(productDto);
        }
    }
}
