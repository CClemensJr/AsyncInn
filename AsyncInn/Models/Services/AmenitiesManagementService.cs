using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class AmenitiesManagementService : IAmenitiesManager
    {
        private AsyncInnDbContext _table { get; }

        /// <summary>
        /// A custom contructor that assigns a dbcontext to the property
        /// </summary>
        /// <param name="amenity"></param>
        public AmenitiesManagementService(AsyncInnDbContext amenity)
        {
            _table = amenity;
        }



        /// <summary>
        /// This method takes in a room object and adds it to the database
        /// </summary>
        /// <param name="amenities"></param>
        /// <returns>A Task object</returns>
        public async Task AddAmenity(Amenities amenities)
        {
            await _table.Amenities.AddAsync(amenities);

            await _table.SaveChangesAsync();
        }


        /// <summary>
        /// This method deletes an amenity from the database if it exists and then saves the changes
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object</returns>
        public async Task DeleteAmenity(int id)
        {
            Amenities amenity = await _table.Amenities.FindAsync(id);

            if (amenity != null)
            {
                _table.Remove(amenity);

                await _table.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<Amenities>> GetAllAmenities()
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> GetAmenity(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAmenity(Amenities amenities)
        {
            throw new NotImplementedException();
        }
    }
}
