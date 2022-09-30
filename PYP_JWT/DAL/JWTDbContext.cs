using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PYP_JWT.Models;

namespace PYP_JWT.DAL
{

    public class JWTDbContext : IdentityDbContext<AppUser>
    {
        public JWTDbContext(DbContextOptions<JWTDbContext> opt):base(opt)
        {

        }
    }
}
