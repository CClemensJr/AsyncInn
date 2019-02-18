using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoomManager
    {
        // Create a Room
        Task AddNewRoom(Room room);

        // Get a Room
        Task<Room> GetRoom(int id);
        
        // Get all Rooms
        Task<IEnumerable<Room>> GetAllRooms();

        // Search for Rooms
        Task<IEnumerable<Room>> SearchRooms(string searchString);

        // Update a Room
        Task EditRoomDetails(Room room);

        // Delete a Room
        Task DeleteRoom(int id);
    }
}
