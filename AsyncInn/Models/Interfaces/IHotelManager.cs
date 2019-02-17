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

        // Get a Hotel
        Task<Hotel> GetHotel(int id);

        // Get all Hotels
        Task<IEnumerable<Hotel>> GetAllHotels();

        // Search for Hotels
        Task<IEnumerable<Hotel>> SearchHotels();

        // Update a Hotel
        Task EditHotelDetails(Hotel hotel);

        // Delete a Hotel
        Task DeleteHotel(int id);
    }
}
