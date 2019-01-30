using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task AddAmenities(Amenities amenities)
        {
            _table.Amenities.Add(amenities);

            await _table.SaveChangesAsync();
        }

        public async Task<Amenities> GetAmenities(int id)
        {
            return await _table.Amenities.FirstOrDefaultAsync(a => a.ID == id);
        }

        public async Task<IEnumerable<Amenities>> GetAllAmenities()
        {
            return await _table.Amenities.ToListAsync();
        }


        public void UpdateAmenity(Amenities amenities)
        {
            throw new NotImplementedException();
        }

        public void DeleteAmenities(int id)
        {
            throw new NotImplementedException();
        }
    }
}
