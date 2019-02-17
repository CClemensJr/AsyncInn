using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AsyncInn.Data;
using AsyncInn.Models;
using AsyncInn.Models.Interfaces;

namespace AsyncInn.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IRoomManager _room;

        /// <summary>
        /// This is a custom constructor that facilitates dependency injection.
        /// </summary>
        /// <param name="room"></param>
        public RoomsController(IRoomManager room)
        {
            _room = room;
        }


        /// <summary>
        /// This GET action returns all table data to the Index page
        /// </summary>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return View(await _room.SearchRooms(searchString);
            }

            return View(await _room.GetAllRooms());
        }


        /// <summary>
        /// This GET action takes an id and sends an object with that ID to the view if it exists in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Details(int id)
        {
            var room = await _room.GetRoom(id);

            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }


        /// <summary>
        /// This GET action renders the Create() view
        /// </summary>
        /// <returns>The result of an action method</returns>
        public IActionResult Create()
        {
            return View();
        }


        /// <summary>
        /// This POST action creates a new object if it is valid then renders object Details page
        /// </summary>
        /// <param name="room"></param>
        /// <returns>The result of an action method</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Layout")] Room room)
        {
            if (ModelState.IsValid)
            {
                await _room.AddNewRoom(room);

                return RedirectToAction(nameof(Index));
            }

            return View(room);
        }


        /// <summary>
        /// This GET action takes an id and returns the details page for the database object with the same ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Edit(int id)
        {
            var room = await _room.GetRoom(id);

            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }


        /// <summary>
        /// This POST method sends an object to the Edit method if the object exists then returns the user to the object details page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="room"></param>
        /// <returns>The result of the action</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Layout")] Room room)
        {
            if (id != room.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _room.EditRoomDetails(room);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(room);
        }


        /// <summary>
        /// This GET action take an id then sends it to the get method. If the object exists, the browser returns the object view page
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object</returns>
        public async Task<IActionResult> Delete(int id)
        {
            var room = await _room.GetRoom(id);

            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }


        /// <summary>
        /// This POST action takes and ID then sends it to the delete method. The browser then redirects to the index page.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _room.DeleteRoom(id);

            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// This method takes an id, sends it to the get method, then returns true or false depending on if the id exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True or False</returns>
        private bool RoomExists(int id)
        {
            return _room.GetRoom(id) != null;
        }
    }
}
