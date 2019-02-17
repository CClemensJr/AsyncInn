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

        Task<IEnumerable<Amenities>> GetAllAmenities();

        // Updated Amenities
        Task UpdateAmenity(Amenities amenities);

        // Delete Amenities
        Task DeleteAmenity(int id);
    }
}
