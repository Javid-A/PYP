using Microsoft.AspNetCore.Identity;

namespace PYP_JWT.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
    }
}
