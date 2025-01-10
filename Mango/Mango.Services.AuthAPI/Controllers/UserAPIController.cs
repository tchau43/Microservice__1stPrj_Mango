using Mango.Services.AuthAPI.Models.Dto;
using Mango.Services.AuthAPI.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.AuthAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize(Roles = "ADMIN")]
	public class UserAPIController : ControllerBase
	{
		private readonly IAuthService _authService;
		protected ResponseDto _response;

		public UserAPIController(IAuthService authService)
		{
			_authService = authService;
			_response = new ResponseDto();
		}

		// GET: api/UserAPI
		[HttpGet]
		public async Task<IActionResult> GetAllUsers()
		{
			try
			{
				var users = await _authService.GetAllUsers();
				_response.Result = users;
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return Ok(_response);
		}

		// GET: api/UserAPI/{id}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetUserById(string id)
		{
			try
			{
				var user = await _authService.GetUserById(id);
				if (user == null)
				{
					_response.IsSuccess = false;
					_response.Message = "User not found.";
					return NotFound(_response);
				}
				_response.Result = user;
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return Ok(_response);
		}

		// PUT: api/UserAPI/{id}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateUser(string id, [FromBody] UpdateUserDto updateUserDto)
		{
			try
			{
				var result = await _authService.UpdateUser(id, updateUserDto);
				if (!result)
				{
					_response.IsSuccess = false;
					_response.Message = "User update failed or user not found.";
					return BadRequest(_response);
				}
				_response.Result = "User updated successfully.";
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return Ok(_response);
		}

		// DELETE: api/UserAPI/{id}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUser(string id)
		{
			try
			{
				var result = await _authService.DeleteUser(id);
				if (!result)
				{
					_response.IsSuccess = false;
					_response.Message = "User deletion failed or user not found.";
					return BadRequest(_response);
				}
				_response.Result = "User deleted successfully.";
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return Ok(_response);
		}

		// Optional: Assign Role to User
		// POST: api/UserAPI/{id}/assign-role
		[HttpPost("{id}/assign-role")]
		public async Task<IActionResult> AssignRoleToUser(string id, [FromBody] AssignRoleDto assignRoleDto)
		{
			try
			{
				var user = await _authService.GetUserById(id);
				if (user == null)
				{
					_response.IsSuccess = false;
					_response.Message = "User not found.";
					return NotFound(_response);
				}

				// Ensure to remove old roles first
				var currentRoles = await _authService.GetRoles(user.Email); // Assuming a method to get roles
				foreach (var role in currentRoles)
				{
					await _authService.RemoveRoleFromUser(user.Email, role); // Assuming a method to remove roles
				}

				// Assign new role
				var assignRoleSuccessful = await _authService.AssignRole(user.Email, assignRoleDto.Role.ToUpper());
				if (!assignRoleSuccessful)
				{
					_response.IsSuccess = false;
					_response.Message = "Role assignment failed.";
					return BadRequest(_response);
				}

				_response.Result = "Role assigned successfully.";
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return Ok(_response);
		}

	}
}
