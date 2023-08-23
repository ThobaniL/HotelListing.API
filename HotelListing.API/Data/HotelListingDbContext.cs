using HotelListing.API.Data.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: IdentityDbContext<ApiUser>
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
        }        
    }

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            // Seed Roles
            List<IdentityRole> roles = new List<IdentityRole>()
        {
            new IdentityRole { Id = "1001", Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
            new IdentityRole { Id = "1003", Name = "User", NormalizedName = "USER" }
        };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
