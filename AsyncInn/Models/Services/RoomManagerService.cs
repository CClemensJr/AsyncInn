﻿using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task EditRoomDetails(Room room)
        {
            if (await _table.Rooms.FirstOrDefaultAsync(r => r.ID == room.ID) != null)
            {
                _table.Rooms.Update(room);

                await _table.SaveChangesAsync();
            }
        }


        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _table.Rooms.ToListAsync();
        }


        public async Task<Room> GetRoomDetails(int id)
        {
            return await _table.Rooms.FindAsync(id);
        }
    }
}