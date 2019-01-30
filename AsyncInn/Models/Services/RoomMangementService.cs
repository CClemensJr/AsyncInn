using AsyncInn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomMangementService : IRoomManager
    {
        public Task AddNewRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public void EditRoomDetails(Room room)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Room>> GetAllRooms()
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
