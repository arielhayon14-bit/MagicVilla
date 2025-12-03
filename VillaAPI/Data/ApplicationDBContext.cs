using VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace VillaAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "This is the Royal Villa",
                    Rate = 200.0,
                    Sqft = 550,
                    Occupancy = 4,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01),
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "This is the Premium Pool Villa",
                    Rate = 300.0,
                    Sqft = 550,
                    Occupancy = 4,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01),
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "This is the Luxury Pool Villa",
                    Rate = 400.0,
                    Sqft = 750,
                    Occupancy = 4,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01),
                },
                new Villa
                {
                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "This is the Diamond Villa",
                    Rate = 550.0,
                    Sqft = 900,
                    Occupancy = 4,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01),
                },
                new Villa
                {
                    Id = 5,
                    Name = "Diamond Pool Villa",
                    Details = "This is the Diamond Pool Villa",
                    Rate = 600.0,
                    Sqft = 1100,
                    Occupancy = 4,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = new DateTime(2023, 01, 01),
                }
            );
        }


    }
}

  