// Mango.Web.Controllers/UserController.cs
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Mango.Web.Controllers
{
	[Authorize(Roles = SD.RoleAdmin)]
	public class UserController : Controller
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		// GET: User/UserIndex
		public async Task<IActionResult> UserIndex()
		{
			var userList = new List<UserDto>();
			var response = await _userService.GetAllUsersAsync();
			if (response != null && response.IsSuccess)
			{
				userList = JsonConvert.DeserializeObject<List<UserDto>>(Convert.ToString(response.Result));
			}
			else
			{
				TempData["Error"] = response?.Message;
			}
			return View(userList);
		}

		// GET: User/CreateUser
		public IActionResult CreateUser()
		{
			return View();
		}

		// POST: User/CreateUser
		[HttpPost]
		public async Task<IActionResult> CreateUser(RegisterationRequestDto userDto)
		{
			if (ModelState.IsValid)
			{
				var response = await _userService.CreateUserAsync(userDto);
				if (response != null && response.IsSuccess)
				{
					// Optionally assign role if not handled in backend
					TempData["Success"] = "User created successfully";
					return RedirectToAction(nameof(UserIndex));
				}
				else
				{
					TempData["Error"] = response?.Message;
				}
			}
			return View(userDto);
		}

		// GET: User/EditUser/{userId}
		public async Task<IActionResult> EditUser(string userId)
		{
			if (string.IsNullOrEmpty(userId))
				return NotFound();

			var response = await _userService.GetUserByIdAsync(userId);
			if (response != null && response.IsSuccess)
			{
				var userDto = JsonConvert.DeserializeObject<RegisterationRequestDto>(Convert.ToString(response.Result));
				return View(userDto);
			}
			TempData["Error"] = response?.Message;
			return NotFound();
		}

		// POST: User/EditUser/{userId}
		[HttpPost]
		public async Task<IActionResult> EditUser(string userId, RegisterationRequestDto userDto)
		{
			if (userId != userDto.Email) // Adjust based on your identification logic
				return NotFound();

			if (ModelState.IsValid)
			{
				var response = await _userService.UpdateUserAsync(userId, userDto);
				if (response != null && response.IsSuccess)
				{
					TempData["Success"] = "User updated successfully";
					return RedirectToAction(nameof(UserIndex));
				}
				else
				{
					TempData["Error"] = response?.Message;
				}
			}
			return View(userDto);
		}

		// GET: User/DeleteUser/{userId}
		public async Task<IActionResult> DeleteUser(string userId)
		{
			if (string.IsNullOrEmpty(userId))
				return NotFound();

			var response = await _userService.GetUserByIdAsync(userId);
			if (response != null && response.IsSuccess)
			{
				var userDto = JsonConvert.DeserializeObject<UserDto>(Convert.ToString(response.Result));
				return View(userDto);
			}
			TempData["Error"] = response?.Message;
			return NotFound();
		}

		// POST: User/DeleteUser/{userId}
		[HttpPost]
		public async Task<IActionResult> DeleteUser(UserDto userDto)
		{
			var response = await _userService.DeleteUserAsync(userDto.Id);
			if (response != null && response.IsSuccess)
			{
				TempData["Success"] = "User deleted successfully";
				return RedirectToAction(nameof(UserIndex));
			}
			else
			{
				TempData["Error"] = response?.Message;
			}
			return View(userDto);
		}
	}
}
