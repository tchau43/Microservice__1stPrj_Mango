﻿using Mango.Web.Models;
using Mango.Web.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Mango.Web.Controllers
{
	public class CartController : Controller
	{
		private readonly ICartService _cartService;

		public CartController(ICartService cartService)
		{
			_cartService = cartService;
		}
		[Authorize]
		public async Task<IActionResult> CartIndex()
		{
			return View(await LoadCartDtoBasedOnLoggedInUser());
		}

		public async Task<IActionResult> Remove(int cartDetailsId)
		{
			var userId = User.Claims.Where(u => u.Type == JwtRegisteredClaimNames.Sub)?.FirstOrDefault()?.Value;
			ResponseDto? response = await _cartService.RemoveFromCartAsync(cartDetailsId);
			if (response != null & response.IsSuccess)
			{
				TempData["success"] = "Cart updated successfully";
				return RedirectToAction(nameof(CartIndex));
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ApplyCoupon(CartDto cartDto)
		{
			var response = await _cartService.ApplyCouponAsync(cartDto);
			if (response != null && response.IsSuccess)
			{
				TempData["Success"] = "Coupon applied successfully";
				return RedirectToAction(nameof(CartIndex));
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> EmailCart(CartDto cartDto)
		{
			CartDto cart = await LoadCartDtoBasedOnLoggedInUser();
			cart.CartHeader.Email = User.Claims.Where(u => u.Type == JwtRegisteredClaimNames.Email)?.FirstOrDefault()?.Value;
			ResponseDto? response = await _cartService.EmailCart(cart);
			if (response != null & response.IsSuccess)
			{
				TempData["success"] = "Email will be processed and sent shortly.";
				return RedirectToAction(nameof(CartIndex));
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> RemoveCoupon(CartDto cartDto)
		{
			cartDto.CartHeader.CouponCode = "";
			var response = await _cartService.ApplyCouponAsync(cartDto);
			if (response != null && response.IsSuccess)
			{
				TempData["Success"] = "Coupon applied successfully";
				return RedirectToAction(nameof(CartIndex));
			}
			return View();
		}

		private async Task<CartDto> LoadCartDtoBasedOnLoggedInUser()
		{
			var userId = User.Claims.Where(c => c.Type == JwtRegisteredClaimNames.Sub)?.FirstOrDefault()?.Value;
			var response = await _cartService.GetCartByUserIdAsync(userId);
			if (response != null && response.IsSuccess)
			{
				CartDto cartDto = JsonConvert.DeserializeObject<CartDto>(Convert.ToString(response.Result));
				return cartDto;

			}
			return new CartDto();
		}

	}
}
