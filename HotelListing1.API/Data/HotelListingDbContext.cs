using Microsoft.EntityFrameworkCore;

namespace HotelListing1.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet <Hotel> Hotels { get; set; }
        public DbSet <Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id =1,
                    Name ="Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name ="Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman",
                    ShortName= "CY"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals",
                    Address = "Nagril",
                    CountryId = 1,
                    Rating = 4.5
                }, 
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 4.3
                },
                 new Hotel
                 {
                     Id = 3,
                     Name = "Grand Palladium",
                     Address = "Nassua",
                     CountryId = 2,
                     Rating = 4
                 }

            );
        }
    }
}
