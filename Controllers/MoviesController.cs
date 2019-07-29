using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sample.MovieCatalogue.Data;
using Sample.MovieCatalogue.Data.Models;

namespace Sample.MovieCatalogue.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieCatalogueDbContext _context;

        public MoviesController(MovieCatalogueDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

         // GET: AddMovie
        [HttpGet]
        public ActionResult AddMovie()
        {
            var movie = new Movie();
            return View(movie);
        }

        // POST: AddMovie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
