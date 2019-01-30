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

        public AmenitiesManagementService(AsyncInnDbContext table)
        {
            _table = table;
        }

        public Task AddAmenities(Amenities amenities)
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> GetAllAmenities(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Amenities>> GetAmenities()
        {
            throw new NotImplementedException();
        }


        public void UpdateAmenity(Amenities amenities)
        {
            throw new NotImplementedException();
        }

        public void DeleteAmenity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
