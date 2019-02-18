using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        // Create Amenities
        Task AddAmenity(Amenities amenities);

        // Get Amenities
        Task<Amenities> GetAmenity(int id);

        // Get all Amenities
        Task<IEnumerable<Amenities>> GetAllAmenities();

        // Search for Hotels
        Task<IEnumerable<Amenities>> SearchAmenities(string searchString);

        // Updated Amenities
        Task UpdateAmenity(Amenities amenities);

        // Delete Amenities
        Task DeleteAmenity(int id);
    }
}
