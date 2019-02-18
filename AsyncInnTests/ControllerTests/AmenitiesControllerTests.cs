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

        [Fact]
        public async void CanRead()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>
                ().UseInMemoryDatabase("ReadAmenities").Options;

            using (AsyncInnDbContext _table = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.ID = 1;
                amenity.Name = "Trampoline";

                AmenitiesManagementService service = new AmenitiesManagementService(_table);

                await service.AddAmenity(amenity);

                Assert.Equal(1, amenity.ID);

            }
        }

        [Fact]
        public async void CanUpdate()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>
                ().UseInMemoryDatabase("UpdateAmenities").Options;

            using (AsyncInnDbContext _table = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.ID = 1;
                amenity.Name = "Trampoline";

                AmenitiesManagementService service = new AmenitiesManagementService(_table);

                await service.AddAmenity(amenity);

                amenity.Name = "Trombonoline";

                await service.UpdateAmenity(amenity);

                Assert.Equal("Trombonoline", amenity.Name);

            }
        }

        [Fact]
        public async void CanDestroy()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>
                ().UseInMemoryDatabase("DeleteAmenities").Options;

            using (AsyncInnDbContext _table = new AsyncInnDbContext(options))
            {
                Amenities amenity = new Amenities();
                amenity.ID = 1;
                amenity.Name = "Trampoline";

                AmenitiesManagementService service = new AmenitiesManagementService(_table);

                await service.AddAmenity(amenity);
                await service.DeleteAmenity(amenity.ID);

                var deletedAmenity = await _table.Amenities.FirstOrDefaultAsync(da => da.ID == amenity.ID);

                Assert.Null(deletedAmenity);
            }
        }
    }
}
