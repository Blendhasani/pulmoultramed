using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using pulmoultramed.Models;

namespace pulmoultramed.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Logo> Logos { get; set; }
        public DbSet<Sherbimet> Sherbimet { get; set; }
        
        public DbSet<Rastet> Rastet { get; set; }
    }
}
