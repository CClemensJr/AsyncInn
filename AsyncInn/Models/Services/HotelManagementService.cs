using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelManagementService : IHotelManager
    {
        private AsyncInnDbContext _table { get; }

        /// <summary>
        /// A custom contructor that assigns a dbcontext to the property
        /// </summary>
        /// <param name="hotel"></param>
        public HotelManagementService(AsyncInnDbContext hotel)
        {
            _table = hotel;
        }


        /// <summary>
        /// The AddNewHotel method takes in a Hotel object and adds it to the database
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns>A Task object</returns>
        public async Task AddNewHotel(Hotel hotel)
        {
            _table.Hotels.Add(hotel);

            await _table.SaveChangesAsync();
        }

        /// <summary>
        /// Thus method deletes a hotel from the database if it exists and then saves the changes
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object</returns>
        public async Task DeleteHotel(int id)
        {
            Hotel hotel = await _table.Hotels.FindAsync(id);

            if (hotel != null)
            {
                _table.Remove(hotel);

                await _table.SaveChangesAsync();
            }
        }

        /// <summary>
        /// This method updates the details of a Hotel if it exists in the database then saves the changes
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns>A Task object</returns>
        public async Task EditHotelDetails(Hotel hotel)
        {
            if (await _table.Hotels.FirstOrDefaultAsync(h => h.ID == hotel.ID) != null)
            {
                _table.Hotels.Update(hotel);

                await _table.SaveChangesAsync();
            }
        }

        /// <summary>
        /// This method returns all of the Hotels in the database
        /// </summary>
        /// <returns>A Task object carrying a list of Hotel objects</returns>
        public async Task<IEnumerable<Hotel>> GetAllHotels()
        {
            return await _table.Hotels.ToListAsync();
        }

        /// <summary>
        /// This method provides the details of a specific hotel in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object containing a Hotel</returns>
        public async Task<Hotel> GetHotel(int id)
        {
            return await _table.Hotels.FindAsync(id);
        }
    }
}
