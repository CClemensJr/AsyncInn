using System;
using System.Collections.Generic;
using System.Text;
using AsyncInn.Models;
using Xunit;

namespace AsyncInnTests.HotelModelTests
{
    public class GetterTests
    {
        [Fact]
        public void CanGetID()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanGetName()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanGetAddress()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanGetPhoneNumber()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanGetNumberOfRooms()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }
    }

    public class SetterTests
    {
        [Fact]
        public void CanSetID()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanSetName()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanSetAddress()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanSetPhoneNumber()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanSetNumberOfRooms()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";

            Assert.Equal(25, hotel.ID);
        }
    }
}
