using AuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.Context
{
    public class JWTContext : DbContext
    {
        public JWTContext(DbContextOptions<JWTContext> options ) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }  
        public DbSet<Role> Roles { get; set; }  
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }  

    }
}
