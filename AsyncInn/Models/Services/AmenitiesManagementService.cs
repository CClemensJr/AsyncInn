﻿using AsyncInn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class AmenitiesManagementService : IAmenitiesManager
    {
        public Task AddAmenity(Amenities amenities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAmenity(int id)
        {
            throw new NotImplementedException();
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