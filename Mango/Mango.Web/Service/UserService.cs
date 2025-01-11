// Mango.Web.Service/UserService.cs
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;
using System.Threading.Tasks;

namespace Mango.Web.Service
{
	public class UserService : IUserService
	{
		private readonly IBaseService _baseService;

		public UserService(IBaseService baseService)
		{
			_baseService = baseService;
		}

		public async Task<ResponseDto?> GetAllUsersAsync()
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = SD.ApiType.GET,
				Url = SD.AuthAPIBase + "/api/UserAPI" // Ensure correct endpoint
			});
		}

		public async Task<ResponseDto?> GetUserByIdAsync(string userId)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = SD.ApiType.GET,
				Url = SD.AuthAPIBase + "/api/UserAPI/" + userId // Correct endpoint
			});
		}

		public async Task<ResponseDto?> CreateUserAsync(RegisterationRequestDto userDto)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = SD.ApiType.POST,
				Data = userDto,
				Url = SD.AuthAPIBase + "/api/AuthAPI/Register"
			});
		}

		public async Task<ResponseDto?> UpdateUserAsync(string userId, RegisterationRequestDto userDto)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = SD.ApiType.PUT,
				Data = userDto,
				Url = SD.AuthAPIBase + "/api/UserAPI/" + userId // Correct endpoint
			});
		}

		public async Task<ResponseDto?> DeleteUserAsync(string userId)
		{
			return await _baseService.SendAsync(new RequestDto
			{
				ApiType = SD.ApiType.DELETE,
				Url = SD.AuthAPIBase + "/api/UserAPI/" + userId // Correct endpoint
			});
		}
	}
}
