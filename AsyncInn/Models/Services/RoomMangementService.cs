using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomMangementService : IRoomManager
    {
        private AsyncInnDbContext _room { get; }

        public RoomMangementService (AsyncInnDbContext room)
        {
            _room = room;
        }

        public Task AddNewRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoomDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Room>> GetAllRooms()
        {
            throw new NotImplementedException();
        }

        public void EditRoomDetails(Room room)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }
    }
}
