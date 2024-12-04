using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductImageUrl { get; set; }
		//public string? ProductImageLocalPath { get; set; }

		//[MaxFileSize(1)]
		//[AllowedExtensions(new string[] { ".jpg", ".png" })]
		//public IFormFile? ProductImage { get; set; }
    }
}
