using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JwtToken_WebApi.Models
{
	public class ApplicationUser:IdentityUser
	{
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

		[MaxLength(50)]
		public string LastName { get; set; } = null!;	
    }
}
