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
            var hotel = await _hotel.GetHotel(id);

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
            var hotel = await _hotel.GetHotel(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }


        /// <summary>
        /// This POST method sends an object to the Edit method if the object exists then returns the user to the object details page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hotel"></param>
        /// <returns>The result of the action</returns>
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
                    await _hotel.EditHotelDetails(hotel);
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


        /// <summary>
        /// This GET action take an id then sends it to the get method. If the object exists, the browser returns the object view page
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object</returns>
        public async Task<IActionResult> Delete(int id)
        {
            var hotel = await _hotel.GetHotel(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
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
            await _hotel.DeleteHotel(id);

            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// This method takes an id, sends it to the get method, then returns true or false depending on if the id exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True or False</returns>
        private bool HotelExists(int id)
        {
            return _hotel.GetHotel(id) != null;
        }
    }
}
