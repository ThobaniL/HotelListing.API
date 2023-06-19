using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 1, Name="Sandals Resort and Spar", Address = "Negril", Rating = 4.5, CountryId = 1},
                new Hotel { Id = 2, Name = "Comfort Suites", Address = "Geoge Town", Rating = 4.3, CountryId = 3 },
                new Hotel { Id = 3, Name = "Grand Palldium", Address = "Nassua", Rating = 4, CountryId = 2 });
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM",
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS",
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Island",
                    ShortName = "CI",
                });
        }
    }
}
