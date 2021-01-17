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
    public class ExtrasController : Controller
    {
        private readonly CinemaDbContext _context;

        public ExtrasController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Extras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Extras.ToListAsync());
        }

        // GET: Admin/Extras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extra = await _context.Extras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extra == null)
            {
                return NotFound();
            }

            return View(extra);
        }

        // GET: Admin/Extras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Extras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Packet,Cost,Desc,Image")] Extra extra, IFormFile movieImage)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(movieImage.FileName);
                string purePath = $"extra-{Guid.NewGuid()}{ext}";
                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    movieImage.CopyTo(fs);

                }
                extra.Image = purePath;
                _context.Add(extra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(extra);
        }

        // GET: Admin/Extras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extra = await _context.Extras.FindAsync(id);
            if (extra == null)
            {
                return NotFound();
            }
            return View(extra);
        }

        // POST: Admin/Extras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Packet,Cost,Desc,Image,ImageTemp")] Extra extra, IFormFile movieImage)
        {
            if (id != extra.Id)
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
                        extra.Image = purePath;

                    }
                    else if (!string.IsNullOrWhiteSpace(extra.ImageTemp))
                    {
                        extra.Image = extra.ImageTemp;
                    }
                    _context.Update(extra);
                    await _context.SaveChangesAsync();
                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(extra.ImageTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtraExists(extra.Id))
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
            return View(extra);
        }

        // GET: Admin/Extras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extra = await _context.Extras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extra == null)
            {
                return NotFound();
            }

            return View(extra);
        }

        // POST: Admin/Extras/Delete/5
        [HttpPost, ActionName("Delete")]
      //  [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var extra = await _context.Extras.FindAsync(id);
            _context.Extras.Remove(extra);
            await _context.SaveChangesAsync();
            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", extra.Image));
            return Json(new
            {
                error = false,
                message = "ok"
            });
          //  return RedirectToAction(nameof(Index));
        }

        private bool ExtraExists(int id)
        {
            return _context.Extras.Any(e => e.Id == id);
        }
    }
}
