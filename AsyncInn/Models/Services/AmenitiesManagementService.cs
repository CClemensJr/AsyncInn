﻿using AsyncInn.Data;
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


        /// <summary>
        /// This method gets all amenities in the database
        /// </summary>
        /// <returns>A collection of Amenities</returns>
        public async Task<IEnumerable<Amenities>> GetAllAmenities()
        {
            return await _table.Amenities.ToListAsync();
        }


        /// <summary>
        /// This method gets a specified amenity if it exists in the table
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An amenity</returns>
        public async Task<Amenities> GetAmenity(int id)
        {
            Amenities amenity = await _table.Amenities.FirstOrDefaultAsync(a => a.ID == id);

            return amenity;
        }


        /// <summary>
        /// This method takes in an ameities object and updates it if it exists in the database
        /// </summary>
        /// <param name="amenities"></param>
        /// <returns>A Task object</returns>
        public async Task UpdateAmenity(Amenities amenities)
        {
            if (await _table.Amenities.AsNoTracking().FirstOrDefaultAsync(a => a.ID == amenities.ID) != null)
            {
                _table.Amenities.Update(amenities);

                await _table.SaveChangesAsync();
            }
        }

        /// <summary>
        /// This method takes a search string, queries the db, then returns a list of all object with names that contain the search string
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>A list of amenities objects</returns>
        public async Task<IEnumerable<Amenities>> SearchAmenities(string searchString)
        {
            var amenities = from a in _table.Amenities
                         where a.Name.Contains(searchString)
                         select a;

            return await amenities.ToListAsync();
        }
    }
}
