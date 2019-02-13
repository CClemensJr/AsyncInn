using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        // Create a Hotel
        Task AddNewHotel(Hotel hotel);

        // Get a Hotel/Hotels
        Task<Hotel> GetHotelDetails(int id);
        Task<IEnumerable<Hotel>> GetAllHotels();

        // Update a Hotel
        void EditHotelDetails(Hotel hotel);

        // Delete a Hotel
        void DeleteHotel(int id);
    }
}
