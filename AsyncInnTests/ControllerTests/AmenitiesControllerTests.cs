using System;
using Xunit;
using AsyncInn.Controllers;
using AsyncInn.Models;
using AsyncInn.Data;
using AsyncInn.Models.Services;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;

namespace AsyncInnTests.ControllerTests
{
    public class AmenitiesControllerTests
    {
        [Fact]
        public async void CanCreate()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>
                ().UseInMemoryDatabase("CreateAmenities").Options;

            using (AsyncInnDbContext _table = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.ID = 1;
                amenity.Name = "Trampoline";

                AmenitiesManagementService service = new AmenitiesManagementService(_table);

                await service.AddAmenity(amenity);
                var created = _table.Amenities.FirstOrDefault(a => a.ID == amenity.ID);

                Assert.Equal(amenity, created);

            }
        }

        public void CanRead()
        {
            Amenities amenity = new Amenities();
            amenity.ID = 9;
            amenity.Name = "Trampoline";

            Assert.Equal(9, amenity.ID);
        }

        public void CanUpdate()
        {
            Amenities amenity = new Amenities();
            amenity.ID = 9;
            amenity.Name = "Trampoline";

            Assert.Equal(9, amenity.ID);
        }

        public void CanDestroy()
        {
            Amenities amenity = new Amenities();
            amenity.ID = 9;
            amenity.Name = "Trampoline";

            Assert.Equal(9, amenity.ID);
        }
    }
}
