using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id =1,
                    Name = "India",
                    ShortName = "IN"
                },
                new Country 
                {
                    Id =2,
                    Name = "United States",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Australia",
                    ShortName = "AU"
                }
             );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "India",
                    CountryId = 1,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Palldium",
                    Address = "Sydney",
                    CountryId = 3,
                    Rating = 4.3
                },
                 new Hotel
                 {
                     Id = 3,
                     Name = "Comfort Suites",
                     Address = "California",
                     CountryId = 2,
                     Rating = 4.5
                 }

             );
        }
    }
}
