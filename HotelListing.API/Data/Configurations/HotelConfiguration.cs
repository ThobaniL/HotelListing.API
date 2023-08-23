using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new Hotel { Id = 1, Name = "Sandals Resort and Spar", Address = "Negril", Rating = 4.5, CountryId = 1 },
                new Hotel { Id = 2, Name = "Comfort Suites", Address = "Geoge Town", Rating = 4.3, CountryId = 3 },
                new Hotel { Id = 3, Name = "Grand Palldium", Address = "Nassua", Rating = 4, CountryId = 2 });
        }
    }
}
