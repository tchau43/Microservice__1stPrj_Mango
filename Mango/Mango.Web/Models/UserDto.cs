// Mango.Web.Models/UserDto.cs
namespace Mango.Web.Models
{
	public class UserDto
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Role { get; set; } // Added Role property
	}
}
