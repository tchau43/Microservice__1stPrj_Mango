using Mango.Services.AuthAPI.Data;
using Mango.Services.AuthAPI.Models;
using Mango.Services.AuthAPI.Models.Dto;
using Mango.Services.AuthAPI.Service.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(AppDbContext db, IJwtTokenGenerator jwtTokenGenerator, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _jwtTokenGenerator = jwtTokenGenerator;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<bool> AssignRole(string email, string roleName)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.Email == email);
            if (user != null)
            {
                if (!await _roleManager.RoleExistsAsync(roleName))
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
                await _userManager.AddToRoleAsync(user, roleName);
                return true;
            }
            return false;
        }
		public async Task<IEnumerable<string>> GetRoles(string email)
		{
			var user = await _userManager.FindByEmailAsync(email);
			return await _userManager.GetRolesAsync(user);
		}

		public async Task<bool> RemoveRoleFromUser(string email, string role)
		{
			var user = await _userManager.FindByEmailAsync(email);
			if (user == null || !await _roleManager.RoleExistsAsync(role))
			{
				return false; // User or role doesn't exist
			}
			var result = await _userManager.RemoveFromRoleAsync(user, role);
			return result.Succeeded;
		}

		public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(c => c.UserName == loginRequestDto.UserName);
            bool isValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);
            if (user == null || isValid == false)
            {
                return new LoginResponseDto() { User = null, Token = "" };
            }

            var roles = await _userManager.GetRolesAsync(user);
            var token = _jwtTokenGenerator.GenerateToken(user, roles);

            UserDto userDto = new()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber
            };

            LoginResponseDto loginResponseDto = new LoginResponseDto()
            {
                User = userDto,
                Token = token
            };

            return loginResponseDto;
        }

        public async Task<string> Register(RegisterationRequestDto registerationRequestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registerationRequestDto.Email,
                Email = registerationRequestDto.Email,
                NormalizedEmail = registerationRequestDto.Email.ToUpper(),
                Name = registerationRequestDto.Name,
                PhoneNumber = registerationRequestDto.PhoneNumber,
            };
            try
            {
                var result = await _userManager.CreateAsync(user, registerationRequestDto.Password);
                if (result.Succeeded)
                {
                    var userToReturn = _db.ApplicationUsers.First(c => c.UserName == registerationRequestDto.Email);

                    UserDto userDto = new()
                    {
                        Email = userToReturn.Email,
                        Name = userToReturn.Name,
                        Id = userToReturn.Id,
                        PhoneNumber = userToReturn.PhoneNumber
                    };
                    return "";
                }
                else
                    return result.Errors.FirstOrDefault().Description;
            }
            catch (Exception ex)
            {

            }
            return "Error Encountered";
        }

		//public async Task<UserDto> Register(RegisterationRequestDto registerationRequestDto)
		//{
		//    ApplicationUser user = new()
		//    {
		//        UserName = registerationRequestDto.Email,
		//        Email = registerationRequestDto.Email,
		//        NormalizedEmail = registerationRequestDto.Email.ToUpper(),
		//        Name = registerationRequestDto.Name,
		//        PhoneNumber = registerationRequestDto.PhoneNumber,
		//    };
		//    try
		//    {
		//        var result = await _userManager.CreateAsync(user, registerationRequestDto.Password);
		//        if (result.Succeeded)
		//        {
		//            var userToReturn = _db.ApplicationUsers.First(c => c.UserName == registerationRequestDto.Email);

		//            UserDto userDto = new()
		//            {
		//                Email = userToReturn.Email,
		//                Name = userToReturn.Name,
		//                Id = userToReturn.Id,
		//                PhoneNumber = userToReturn.PhoneNumber
		//            };
		//            return userDto;
		//        }
		//    }
		//    catch (Exception ex)
		//    {

		//    }
		//    return new UserDto();
		//}




		// Admin-specific methods

		public async Task<IEnumerable<UserDto>> GetAllUsers()
		{
			var users = await _userManager.Users.ToListAsync();
			return users.Select(user => new UserDto
			{
				Id = user.Id,
				Name = user.Name,
				Email = user.Email,
				PhoneNumber = user.PhoneNumber
			});
		}

		public async Task<UserDto> GetUserById(string userId)
		{
			var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == userId);
			if (user == null)
				return null;

			return new UserDto
			{
				Id = user.Id,
				Name = user.Name,
				Email = user.Email,
				PhoneNumber = user.PhoneNumber
			};
		}

		public async Task<bool> UpdateUser(string userId, UpdateUserDto updateUserDto)
		{
			var user = await _userManager.FindByIdAsync(userId);
			if (user == null)
				return false;

			user.Name = updateUserDto.Name;
			user.Email = updateUserDto.Email;
			user.UserName = updateUserDto.Email; // Assuming username is the email
			user.PhoneNumber = updateUserDto.PhoneNumber;

			var result = await _userManager.UpdateAsync(user);
			return result.Succeeded;
		}

		public async Task<bool> DeleteUser(string userId)
		{
			var user = await _userManager.FindByIdAsync(userId);
			if (user == null)
				return false;

			var result = await _userManager.DeleteAsync(user);
			return result.Succeeded;
		}
	}
}
