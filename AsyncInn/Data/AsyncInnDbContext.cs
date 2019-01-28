using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(hr => new { hr.HotelID, hr.RoomNumber });
            modelBuilder.Entity<RoomAmenities>().HasKey(ra => new { ra.AmenitiesID, ra.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { ID = 1, Name = "Hotel Landria", Address = "123 N 82nd Ave, Sporkland, MI 53401", Phone = "555-555-5555" },
                new Hotel { ID = 2, Name = "Hotel Alfansa", Address = "124 N 94th Ave, Avertine, WA 98002", Phone = "555-555-5555" },
                new Hotel { ID = 3, Name = "Hotel Valdabash", Address = "1 N 15th Ave, Phoenix, AZ 85307", Phone = "555-555-5555" },
                new Hotel { ID = 4, Name = "Hotel Flatlinaz", Address = "12000 N 142nd St, Yorktown, VA 24501", Phone = "555-555-5555" },
                new Hotel { ID = 5, Name = "Hotel Bizzle", Address = "456 S 78910 Ave, Beachtown, CA 24512", Phone = "555-555-5555" }
            );


        }

        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
    }
}
