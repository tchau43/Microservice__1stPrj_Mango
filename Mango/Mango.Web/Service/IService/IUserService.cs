// Mango.Web.Service.IService/IUserService.cs
using Mango.Web.Models;
using System.Threading.Tasks;

namespace Mango.Web.Service.IService
{
	public interface IUserService
	{
		Task<ResponseDto?> GetAllUsersAsync();
		Task<ResponseDto?> GetUserByIdAsync(string userId);
		Task<ResponseDto?> CreateUserAsync(RegisterationRequestDto userDto);
		Task<ResponseDto?> UpdateUserAsync(string userId, RegisterationRequestDto userDto);
		Task<ResponseDto?> DeleteUserAsync(string userId);
	}
}
