using AuthApp.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthApp
{
    public class UserContext : IdentityDbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> users;
    }
}
