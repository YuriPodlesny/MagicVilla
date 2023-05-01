using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/417140169.jpg?k=794dd7b184f101b8aa59e7260923931a1e25589de58b7ce011294797408be673&o=&hp=1",
                    Occupancy = 5,
                    Sqft = 550,
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Diamond Villa",
                    Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/200990168.jpg?k=efdbcb6b8000ed684476b3abb5eae43a36a8e10a0b3680026ce73af0cb83ee90&o=&hp=1",
                    Occupancy = 4,
                    Sqft = 250,
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Diamond Pool Villa",
                    Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/375779638.jpg?k=61801f9d0506627a342055c873c539af50b89c8706fc226eb02ea901fe124e38&o=&hp=1",
                    Occupancy = 2,
                    Sqft = 350,
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa
                {
                    Id = 4,
                    Name = "Wild Orchid Villa",
                    Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/375779625.jpg?k=9347d660e6fb93f528a74ee4f0789b2f80aed1a877820497923bdc74029fafa3&o=&hp=1",
                    Occupancy = 1,
                    Sqft = 150,
                    Amenity = "",
                    CreateDate = DateTime.Now
                },
                new Villa
                {
                    Id = 5,
                    Name = "Wild Orchid Villa",
                    Details = "Located in Havelock Island, 500 metres from Govind Nagar Beach, Royal Villa Beach Resort provides accommodation with a garden, free private parking and a restaurant. This 3-star hotel offers room service and a concierge service. The hotel features garden views and a children's playground.",
                    ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/177185852.jpg?k=653c282762e3dab1087205beb9ac90af00308f4f387c09986dcb8ed8c8a6260a&o=&hp=1",
                    Occupancy = 6,
                    Sqft = 550,
                    Amenity = "",
                    CreateDate = DateTime.Now
                });
        }
    }
}
