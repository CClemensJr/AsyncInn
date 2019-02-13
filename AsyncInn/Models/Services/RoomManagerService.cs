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



        public async Task AddNewRoom(Room room)
        {
            _table.Rooms.Add(room);

            await _table.SaveChangesAsync();
        }

        public async Task DeleteRoom(int id)
        {
            Room room = await _table.Rooms.FindAsync(id);

            if (room != null)
            {
                _table.Rooms.Remove(room);

                await _table.SaveChangesAsync();
            }
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
