using AutoMapper;
using Mango.Services.ProductAPI.Data;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
	//[Authorize]
    public class ProductAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;
        private readonly ResponseDto _responseDto;

        public ProductAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _responseDto = new ResponseDto();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<Product> objList = _db.Products.ToList();
                _responseDto.Result = objList;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return Ok(_responseDto);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Product product = _db.Products.FirstOrDefault(x => x.ProductId == id);
                _responseDto.Result = product;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return Ok(_responseDto);
        }

        [HttpGet("GetByName/{name}")]
        public IActionResult Get(string name)
        {
            try
            {
                Product product = _db.Products.FirstOrDefault(x => x.ProductName.ToLower() == name.ToLower());
                _responseDto.Result = product;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return Ok(_responseDto);
        }

        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        public IActionResult Post(ProductDto model)
        {
            try
            {
                Product product = _mapper.Map<Product>(model);
                _db.Products.Add(product);
                _db.SaveChanges();

                _responseDto.Result = product;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return Ok(_responseDto);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "ADMIN")]
        public IActionResult Put(ProductDto model)
        {
            //if (id != model.ProductId) return BadRequest(new {Message = "Product ID do not match"});
            try
            {
                var result = _db.Products.FirstOrDefault(c => c.ProductId == model.ProductId);
                if (result != null)
                {
                    _mapper.Map(model, result);
                    _db.SaveChanges();
                }
                _responseDto.Result = result;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return Ok(_responseDto);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "ADMIN")]
        public IActionResult Delete(int id)
        {
            try
            {
                var product = _db.Products.FirstOrDefault(c => c.ProductId == id);
                if(product != null)
                {
                    _db.Products.Remove(product);
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return Ok(_responseDto);
        }
    }
}
