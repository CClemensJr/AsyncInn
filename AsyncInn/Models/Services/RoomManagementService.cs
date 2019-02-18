using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomManagementService : IRoomManager
    {
        private AsyncInnDbContext _table { get; }

        /// <summary>
        /// A custom contructor that assigns a dbcontext to the property
        /// </summary>
        /// <param name="room"></param>
        public RoomManagementService(AsyncInnDbContext room)
        {
            _table = room;
        }


        /// <summary>
        /// The AddNewroom method takes in a room object and adds it to the database
        /// </summary>
        /// <param name="room"></param>
        /// <returns>A Task object</returns>
        public async Task AddNewRoom(Room room)
        {
            _table.Rooms.Add(room);

            await _table.SaveChangesAsync();
        }


        /// <summary>
        /// Thus method deletes a room from the database if it exists and then saves the changes
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object</returns>
        public async Task DeleteRoom(int id)
        {
            Room room = await _table.Rooms.FindAsync(id);
            var roomAmenities = from ra in _table.RoomAmenities
                                where ra.RoomID == room.ID
                                select ra;
            await roomAmenities.ToListAsync();

            if (room != null)
            {
                _table.Rooms.Remove(room);

                foreach (var amenity in roomAmenities)
                {
                    _table.Remove(amenity);
                }

                await _table.SaveChangesAsync();
            }
        }


        /// <summary>
        /// This method updates the details of a room if it exists in the database then saves the changes
        /// </summary>
        /// <param name="room"></param>
        /// <returns>A Task object</returns>
        public async Task EditRoomDetails(Room room)
        {
            if (await _table.Rooms.AsNoTracking().FirstOrDefaultAsync(r => r.ID == room.ID) != null)
            {
                _table.Rooms.Update(room);

                await _table.SaveChangesAsync();
            }
        }


        /// <summary>
        /// This method returns all of the rooms in the database
        /// </summary>
        /// <returns>A Task object carrying a list of room objects</returns>
        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _table.Rooms.ToListAsync();
        }


        /// <summary>
        /// This method provides the details of a specific room in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object containing a room</returns>
        public async Task<Room> GetRoom(int id)
        {
            return await _table.Rooms.FindAsync(id);
        }

        /// <summary>
        /// This method takes a search string, queries the db, then returns a list of all object with names that contain the search string
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>A list of room objects</returns>
        public async Task<IEnumerable<Room>> SearchRooms(string searchString)
        {
            var rooms = from r in _table.Rooms
                         where r.Name.Contains(searchString)
                         select r;

            return await rooms.ToListAsync();
        }


        /// <summary>
        /// This method takes an id and returns the number of Room Amenities associated with that id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An integer representing the number of amenities</returns>
        public int CountAmenities(int id)
        {
            int numberOfAmenities = _table.RoomAmenities.Where(ra => ra.RoomID == id).Count();

            return numberOfAmenities;
        }
    }
}
