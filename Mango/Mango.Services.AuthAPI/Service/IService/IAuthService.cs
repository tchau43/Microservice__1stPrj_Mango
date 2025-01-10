using Mango.Services.AuthAPI.Models.Dto;

namespace Mango.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegisterationRequestDto requestDto);
        Task<LoginResponseDto> Login(LoginRequestDto requestDto);
        Task<bool> AssignRole(string email, string roleName);


		// Admin-specific methods
		Task<IEnumerable<UserDto>> GetAllUsers();
		Task<UserDto> GetUserById(string userId);
		Task<bool> UpdateUser(string userId, UpdateUserDto updateUserDto);
		Task<bool> DeleteUser(string userId);
		Task<IEnumerable<string>> GetRoles(string email);  // To fetch current roles of the user
		Task<bool> RemoveRoleFromUser(string email, string role);
	}
}
