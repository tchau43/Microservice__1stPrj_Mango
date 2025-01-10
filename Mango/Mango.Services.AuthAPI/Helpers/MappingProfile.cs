using AutoMapper;
using Mango.Services.AuthAPI.Models;
using Mango.Services.AuthAPI.Models.Dto;

namespace Mango.Services.AuthAPI.Helpers
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<ApplicationUser, UserDto>().ReverseMap();
			CreateMap<RegisterationRequestDto, ApplicationUser>().ReverseMap();
			CreateMap<UpdateUserDto, ApplicationUser>().ReverseMap();
			// Add other mappings as needed
		}
	}
}
