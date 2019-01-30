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
        private AsyncInnDbContext _table { get; }

        public RoomMangementService (AsyncInnDbContext table)
        {
            _table = table;
        }

        public async Task AddNewRoom(Room room)
        {
            _table.Rooms.Add(room);
            await _table.SaveChangesAsync();

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
