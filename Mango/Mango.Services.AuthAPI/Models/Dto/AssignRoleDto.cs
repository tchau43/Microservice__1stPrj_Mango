using System.ComponentModel.DataAnnotations;

namespace Mango.Services.AuthAPI.Models.Dto
{
	public class AssignRoleDto
	{
		[Required]
		public string Email { get; set; }

		[Required]
		public string Role { get; set; }
	}
}
