using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaPro.Domain.DataContext;
using CinemaPro.Domain.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CinemaPro.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MoviedetailsController : Controller
    {
        private readonly CinemaDbContext _context;

        public MoviedetailsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Moviedetails
        public async Task<IActionResult> Index()
        {
            var cinemaDbContext = _context.Moviedetails.Include(m => m.Director).Include(m => m.Language);
            return View(await cinemaDbContext.ToListAsync());
        }

        // GET: Admin/Moviedetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moviedetail = await _context.Moviedetails
                .Include(m => m.Director)
                .Include(m => m.Language)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moviedetail == null)
            {
                return NotFound();
            }

            return View(moviedetail);
        }

        // GET: Admin/Moviedetails/Create
        public IActionResult Create()
        {
            ViewData["DirectorId"] = new SelectList(_context.Directors, "Id", "Name");
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Languages");
            return View();
        }

        // POST: Admin/Moviedetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Startdate,Enddate,Trailer,Image,TitleImage,Price,Desc,Country,Time,Agelimit,Subtitles,LanguageId,DirectorId")] Moviedetail moviedetail, IFormFile movieImage, IFormFile movieTitImage)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(movieImage.FileName);
                string purePath = $"movie-{Guid.NewGuid()}{ext}";
                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    movieImage.CopyTo(fs);

                }
                moviedetail.Image = purePath;

                var ext1 = Path.GetExtension(movieTitImage.FileName);
                string purePath1 = $"movie-{Guid.NewGuid()}{ext1}";
                string fileName1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath1);
                using (var fs = new FileStream(fileName1, FileMode.CreateNew, FileAccess.Write))
                {
                    movieTitImage.CopyTo(fs);

                }
                moviedetail.TitleImage = purePath1;

                _context.Add(moviedetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DirectorId"] = new SelectList(_context.Directors, "Id", "Name", moviedetail.DirectorId);
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Languages", moviedetail.LanguageId);
            return View(moviedetail);
        }

        // GET: Admin/Moviedetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moviedetail = await _context.Moviedetails.FindAsync(id);
            if (moviedetail == null)
            {
                return NotFound();
            }
            ViewData["DirectorId"] = new SelectList(_context.Directors, "Id", "Name", moviedetail.DirectorId);
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Languages", moviedetail.LanguageId);
            return View(moviedetail);
        }

        // POST: Admin/Moviedetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Startdate,Enddate,Trailer,Image,ImageTemp,TitleImage,TitleImageTemp,Price,Desc,Country,Time,Agelimit,Subtitles,LanguageId,DirectorId")] Moviedetail moviedetail, IFormFile movieImage, IFormFile movieTitImage)
        {
            if (id != moviedetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string path = _context.Moviedetails.AsNoTracking().FirstOrDefault(p => p.Id == id)?.Image;
                    string path1 = _context.Moviedetails.AsNoTracking().FirstOrDefault(p => p.Id == id)?.TitleImage;
                    if (movieImage != null )
                    {
                        string ext = Path.GetExtension(movieImage.FileName);
                        string purePath = $"movie-{Guid.NewGuid()}{ext}";
                        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                        using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            movieImage.CopyTo(fs);

                        }
                        moviedetail.Image = purePath;

                    }
                    else if (!string.IsNullOrWhiteSpace(moviedetail.ImageTemp))
                    {
                        moviedetail.Image = moviedetail.ImageTemp;
                    }
                    if (movieTitImage != null)
                    {
                        string ext1 = Path.GetExtension(movieTitImage.FileName);
                        string purePath1 = $"movie-{Guid.NewGuid()}{ext1}";
                        string fileName1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath1);
                        using (var fs = new FileStream(fileName1, FileMode.CreateNew, FileAccess.Write))
                        {
                            movieTitImage.CopyTo(fs);
                        }
                        moviedetail.TitleImage = purePath1;
                    }
                    else if (!string.IsNullOrWhiteSpace(moviedetail.TitleImageTemp))
                    {
                        moviedetail.TitleImage = moviedetail.TitleImageTemp;
                    }
                    _context.Update(moviedetail);
                    await _context.SaveChangesAsync();
                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(moviedetail.ImageTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }
                    else if (!string.IsNullOrWhiteSpace(path1) && string.IsNullOrWhiteSpace(moviedetail.TitleImageTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path1));
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoviedetailExists(moviedetail.Id))
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
            ViewData["DirectorId"] = new SelectList(_context.Directors, "Id", "Name", moviedetail.DirectorId);
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Languages", moviedetail.LanguageId);
            return View(moviedetail);
        }

        // GET: Admin/Moviedetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moviedetail = await _context.Moviedetails
                .Include(m => m.Director)
                .Include(m => m.Language)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moviedetail == null)
            {
                return NotFound();
            }

            return View(moviedetail);
        }

        // POST: Admin/Moviedetails/Delete/5
        [HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moviedetail = await _context.Moviedetails.FindAsync(id);
            _context.Moviedetails.Remove(moviedetail);
            await _context.SaveChangesAsync();
            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", moviedetail.Image));
            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", moviedetail.TitleImage));
            return Json(new
            {
                error = false,
                message = "ok"
            });
            //return RedirectToAction(nameof(Index));
        }

        private bool MoviedetailExists(int id)
        {
            return _context.Moviedetails.Any(e => e.Id == id);
        }
    }
}
