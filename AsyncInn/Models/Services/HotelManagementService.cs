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
        private AsyncInnDbContext _context { get; }

        public HotelManagementService(AsyncInnDbContext context)
        {

        }

        public Task AddNewHotel(Hotel hotel)
        {
            throw new NotImplementedException();
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
