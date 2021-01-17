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
    public class CastsController : Controller
    {
        private readonly CinemaDbContext _context;

        public CastsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Casts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Casts.ToListAsync());
        }

        // GET: Admin/Casts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cast = await _context.Casts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cast == null)
            {
                return NotFound();
            }

            return View(cast);
        }

        // GET: Admin/Casts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Casts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fullname,Rolename,Image")] Cast cast, IFormFile movieImage)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(movieImage.FileName);
                string purePath = $"cast-{Guid.NewGuid()}{ext}";
                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    movieImage.CopyTo(fs);

                }
                cast.Image = purePath;
                _context.Add(cast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cast);
        }

        // GET: Admin/Casts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cast = await _context.Casts.FindAsync(id);
            if (cast == null)
            {
                return NotFound();
            }
            return View(cast);
        }

        // POST: Admin/Casts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fullname,Rolename,Image,ImagePathTemp")] Cast cast, IFormFile movieImage)
        {
            if (id != cast.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string path = _context.Casts.AsNoTracking().FirstOrDefault(p => p.Id == id)?.Image;
                    if (movieImage != null)
                    {
                        string ext = Path.GetExtension(movieImage.FileName);
                        string purePath = $"cast-{Guid.NewGuid()}{ext}";
                        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                        using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            movieImage.CopyTo(fs);

                        }
                        cast.Image = purePath;

                    }
                    else if (!string.IsNullOrWhiteSpace(cast.ImagePathTemp))
                    {
                        cast.Image = cast.ImagePathTemp;
                    }
                    _context.Update(cast);
                    await _context.SaveChangesAsync();

                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(cast.ImagePathTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CastExists(cast.Id))
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
            return View(cast);
        }

        // GET: Admin/Casts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cast = await _context.Casts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cast == null)
            {
                return NotFound();
            }

            return View(cast);
        }

        // POST: Admin/Casts/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cast = await _context.Casts.FindAsync(id);
            _context.Casts.Remove(cast);
            await _context.SaveChangesAsync();
            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", cast.Image));
            return Json(new
            {
                error = false,
                message = "ok"
            });
           // return RedirectToAction(nameof(Index));
        }

        private bool CastExists(int id)
        {
            return _context.Casts.Any(e => e.Id == id);
        }
    }
}
