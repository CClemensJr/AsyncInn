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
    public class AmenitiesController : Controller
    {
        private readonly IAmenitiesManager _amenities;

        /// <summary>
        /// This is a custom constructor that facilitates dependency injection.
        /// </summary>
        /// <param name="amenities"></param>
        public AmenitiesController(IAmenitiesManager amenities)
        {
            _amenities = amenities;
        }


        /// <summary>
        /// This GET action returns all table data to the Index page
        /// </summary>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Index()
        {
            return View(await _amenities.GetAllAmenities());
        }


        /// <summary>
        /// This GET action takes an id and sends an object with that ID to the view if it exists in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Details(int id)
        {
            var amenities = await _amenities.GetAmenity(id);

            if (amenities == null)
            {
                return NotFound();
            }

            return View(amenities);
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
        public async Task<IActionResult> Create([Bind("ID,Name")] Amenities amenities)
        {
            if (ModelState.IsValid)
            {
                await _amenities.AddAmenity(amenities);

                return RedirectToAction(nameof(Index));
            }

            return View(amenities);
        }


        /// <summary>
        /// This GET action takes an id and returns the details page for the database object with the same ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The result of an action method</returns>
        public async Task<IActionResult> Edit(int id)
        {
            var amenities = await _amenities.GetAmenity(id);

            if (amenities == null)
            {
                return NotFound();
            }

            return View(amenities);
        }

        // POST: Amenities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Amenities amenities)
        {
            if (id != amenities.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amenities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmenitiesExists(amenities.ID))
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
            return View(amenities);
        }

        // GET: Amenities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var amenities = await _context.Amenities
                .FirstOrDefaultAsync(m => m.ID == id);
            if (amenities == null)
            {
                return NotFound();
            }

            return View(amenities);
        }

        // POST: Amenities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var amenities = await _context.Amenities.FindAsync(id);
            _context.Amenities.Remove(amenities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmenitiesExists(int id)
        {
            return _context.Amenities.Any(e => e.ID == id);
        }
    }
}
