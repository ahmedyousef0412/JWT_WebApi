using JwtToken_WebApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace JwtToken_WebApi.Data
{
	public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
       
    }
}
