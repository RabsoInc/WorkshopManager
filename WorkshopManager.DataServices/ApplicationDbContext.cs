using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WorkshopManager.Models.CustomerRelationshipManagement.BaseModels;
using WorkshopManager.Models.Identity.BaseModels;
using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.DataServices
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<ControllerViewMapping> ControllerViewMappings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<ReleaseNote> ReleaseNotes { get; set; }
    }
}