using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AuthAPI.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ) :base (options)

        {
            
        }
    }
}


