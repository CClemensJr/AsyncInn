using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomManagerService : IRoomManager
    {
        private AsyncInnDbContext _table { get; }

        public RoomManagerService(AsyncInnDbContext room)
        {
            _table = room;
        }

        public Task AddNewRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditRoomDetails(Room room)
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
