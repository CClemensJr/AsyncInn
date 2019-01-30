using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        // Create Amenities
        Task AddAmenities(Amenities amenities);

        // Get Amenities
        Task<Amenities> GetAmenities(int id);
        Task<IEnumerable<Amenities>> GetAllAmenities();

        // Updated Amenities
        void UpdateAmenity(Amenities amenities);

        // Delete Amenities
        void DeleteAmenities(int id);
    }
}
