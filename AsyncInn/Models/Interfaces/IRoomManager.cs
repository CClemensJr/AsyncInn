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
        Task<Room> GetRoomDetails(int id);
        Task<IEnumerable<Room>> GetAllRooms();

        // Update a Room
        void EditRoomDetails(Room room);

        // Delete a Room
        void DeleteRoom(int id);
    }
}
