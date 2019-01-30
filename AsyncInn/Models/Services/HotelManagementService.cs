using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
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
        /// <returns></returns>
        public async Task AddNewHotel(Hotel hotel)
        {
            _hotel.Hotels.Add(hotel);

            await _hotel.SaveChangesAsync();
        }

        public void DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        public void EditHotelDetails(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hotel>> GetAllHotelDetails()
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetHotelDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
