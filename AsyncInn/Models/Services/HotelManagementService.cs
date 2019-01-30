using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelManagementService : IHotelManager
    {
        private AsyncInnDbContext _hotel { get; }

        public HotelManagementService(AsyncInnDbContext hotel)
        {
            _hotel = hotel;
        }

        /// <summary>
        /// The AddNewHotel method takes in a Hotel object and adds it to the database
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns>Returns a task</returns>
        public async Task AddNewHotel(Hotel hotel)
        {
            _hotel.Hotels.Add(hotel);

            await _hotel.SaveChangesAsync();
        }


        /// <summary>
        /// The GetHotelDetails method takes in an id and returns the details for the hotel with the associated ID
        /// </summary>
        /// <returns>Returns a task</returns>
        public async Task<Hotel> GetHotelDetails(int id)
        {
            return await _hotel.Hotels.FirstOrDefaultAsync(h => h.ID == id);
        }


        /// <summary>
        /// The GetAllHotelDetail methods returns all hotels
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Hotel>> GetAllHotels()
        {
            return await _hotel.Hotels.ToListAsync();
        }

        /// <summary>
        /// The EditHotelDetails method takes a hotel object, modifies it, then saves it to the database
        /// </summary>
        /// <param name="hotel"></param>
        public void EditHotelDetails(Hotel hotel)
        {
            _hotel.Update(hotel);
             _hotel.SaveChangesAsync();
        }


        /// <summary>
        /// The DeleteHotel method takes in a Hotel ID and deletes the record from the database
        /// </summary>
        /// <param name="id"></param>
        public void DeleteHotel(int id)
        {
            // Create a hotel object if there is a Hotel ID that matches the incoming ID
            Hotel hotel = _hotel.Hotels.FirstOrDefault(h => h.ID == id);
            // Remove the hotel object from the database
            _hotel.Hotels.Remove(hotel);
            // Save the changes to the database
            _hotel.SaveChanges();
        }

    }
}
