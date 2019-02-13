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
        /// <returns></returns>
        public async Task AddNewHotel(Hotel hotel)
        {
            _table.Hotels.Add(hotel);

            await _table.SaveChangesAsync();
        }

        public async Task DeleteHotel(int id)
        {
            Hotel hotel = await _table.Hotels.FindAsync(id);

            if (hotel != null)
            {
                _table.Remove(hotel);

            }
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
