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
    public class HotelsController : Controller
    {
        private readonly IHotelManager _hotel;

        /// <summary>
        /// This custom constructor takes an interface object and assigns it to the property
        /// </summary>
        /// <param name="hotel"></param>
        public HotelsController(IHotelManager hotel)
        {
            _hotel = hotel;
        }


        /// <summary>
        /// This GET action returns all table data to the Index page
        /// </summary>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Index()
        {
            return View(await _hotel.GetAllHotels());
        }

        /// <summary>
        /// This GET action takes an id and sends an object with that ID to the view if it exists in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Details(int id)
        {
            var hotel = await _hotel.GetHotelDetails(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
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
        /// <param name="hotel"></param>
        /// <returns>The result of an action method</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Address,Phone")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                await _hotel.AddNewHotel(hotel);

                return RedirectToAction(nameof(Index));
            }

            return View(hotel);
        }

        /// <summary>
        /// This GET action takes an id and returns the details page for the database object with the same ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Edit(int id)
        {
            var hotel = await _hotel.EditHotelDetails(_hotel.GetHotelDetails(id).Result);

            if (hotel == null)
            {
                return NotFound();
            }

            

            return View(hotel);
        }

        // POST: Hotels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Address,Phone")] Hotel hotel)
        {
            if (id != hotel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(hotel.ID))
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
            return View(hotel);
        }

        // GET: Hotels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelExists(int id)
        {
            return _context.Hotels.Any(e => e.ID == id);
        }
    }
}
