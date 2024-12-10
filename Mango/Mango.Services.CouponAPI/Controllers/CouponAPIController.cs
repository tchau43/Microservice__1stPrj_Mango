using AutoMapper;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    //[Route("api/asd")]
    [ApiController]
    //[Authorize]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public CouponAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _responseDto = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
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
        //[Route("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Coupon objList = _db.Coupons.First(c => c.CouponId == id);
                _responseDto.Result = objList;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message;
            }
            return Ok(_responseDto);
        }
        [HttpGet("GetByCode/{code}")]
        public IActionResult GetByCode(string code)
        {
            try
            {
                Coupon objList = _db.Coupons.First(c => c.CouponCode.ToLower() == code.ToLower());
                _responseDto.Result = objList;
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
        public IActionResult Post(CouponDto model)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(model);
                _db.Coupons.Add(obj);
                _db.SaveChanges();

                _responseDto.Result = obj;
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
        public IActionResult Put(int id, CouponDto model)
        {
            if (id != model.CouponId)
            {
                return BadRequest(new { Message = "Coupon ID mismatch." });
            }
            try
            {
                var result = _db.Coupons.SingleOrDefault(c => c.CouponId == id);
                //_mapper.Map<CouponDto>(result);
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
                Coupon result = _db.Coupons.SingleOrDefault(c => c.CouponId == id);
                if (result != null)
                {
                    _db.Remove(result);
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
