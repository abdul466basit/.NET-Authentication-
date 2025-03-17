using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Data
{
    public class ApplicationUser : IdentityUser // email and pwd inherited from identity User
    {
        public string Name { get; set; }

    }
}
