using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkshopManager.Models.Identity.BaseModels;
using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.DataServices
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
        }

        public DbSet<SystemAttribute> SystemAttributes { get; set; }
    }
}