using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AsyncInn.Models;

namespace AsyncInnTests.RoomModelTests
{
    public class GetterTests
    {
        [Fact]
        public void CanGetHotelID()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            Assert.Equal(25, hotel.ID);
        }

        [Fact]
        public void CanGetRoomNumber()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            Assert.Equal("Trampoline Inn", hotel.Name);
        }

        [Fact]
        public void CanGetRoomID()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            Assert.Equal("555 Test Ave, Test Town, NJ 98900", hotel.Address);
        }

        [Fact]
        public void CanGetRate()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            Assert.Equal("555-555-5555", hotel.Phone);
        }

        [Fact]
        public void CanGetNumberOfRooms()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            Assert.Equal(5, hotel.NumberOfRooms);
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
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            hotel.ID = 26;

            Assert.Equal(26, hotel.ID);
        }

        [Fact]
        public void CanSetName()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            hotel.Name = "Trabrotron Inn";

            Assert.Equal("Trabrotron Inn", hotel.Name);
        }

        [Fact]
        public void CanSetAddress()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            hotel.Address = "111 Test Ave, Test Town, NJ 98900";

            Assert.Equal("111 Test Ave, Test Town, NJ 98900", hotel.Address);
        }

        [Fact]
        public void CanSetPhoneNumber()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            hotel.Phone = "555-555-6666";

            Assert.Equal("555-555-6666", hotel.Phone);
        }

        [Fact]
        public void CanSetNumberOfRooms()
        {
            Hotel hotel = new Hotel();
            hotel.ID = 25;
            hotel.Name = "Trampoline Inn";
            hotel.Address = "555 Test Ave, Test Town, NJ 98900";
            hotel.Phone = "555-555-5555";
            hotel.NumberOfRooms = 5;

            hotel.NumberOfRooms = 15;

            Assert.Equal(15, hotel.NumberOfRooms);
        }
    }
}
