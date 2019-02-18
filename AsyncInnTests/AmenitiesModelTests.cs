using AsyncInn.Models;
using System;
using Xunit;

namespace AsyncInnTests.AmenitiesModelTests
{
    public class GetterTests
    {
        [Fact]
        public void CanGetID()
        {
            Amenities amenity = new Amenities();
            amenity.ID = 9;
            amenity.Name = "Trampoline";

            Assert.Equal(9, amenity.ID);
        }

        [Fact]
        public void CanGetName()
        {
            Amenities amenity = new Amenities();
            amenity.ID = 9;
            amenity.Name = "Trampoline";

            Assert.Equal("Trampoline", amenity.Name);
        }
    }

    public class SetterTests
    {
        [Fact]
        public void CanSetID()
        {
            Amenities amenity = new Amenities();
            amenity.ID = 9;
            amenity.Name = "Trampoline";

            amenity.ID = 10;

            Assert.Equal(10, amenity.ID);
        }

        [Fact]
        public void CanSetName()
        {
            Amenities amenity = new Amenities();
            amenity.ID = 9;
            amenity.Name = "Trampoline";

            amenity.Name = "Trambrotron";

            Assert.Equal("Trambrotron", amenity.Name);
        }
    }
}
