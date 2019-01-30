using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Room> GetRoomDetails(int id)
        {
            return await _table.Rooms.FirstOrDefaultAsync(r => r.ID == id);
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _table.Rooms.ToListAsync();
        }

        public void EditRoomDetails(Room room)
        {
            _table.Update(room);
            _table.SaveChangesAsync();
        }

        public void DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }
    }
}
