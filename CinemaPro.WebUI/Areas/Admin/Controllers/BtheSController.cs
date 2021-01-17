using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaPro.Domain.Entity;
using System.IO;
using Microsoft.AspNetCore.Http;
using CinemaPro.Domain.DataContext;

namespace CinemaPro.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BtheSController : Controller
    {
        private readonly CinemaDbContext _context;

        public BtheSController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BtheS
        public async Task<IActionResult> Index()
        {
            var cinemaDbContext = _context.BtheSes.Include(b => b.Moviedetail);
            return View(await cinemaDbContext.ToListAsync());
        }

        // GET: Admin/BtheS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btheS = await _context.BtheSes
                .Include(b => b.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btheS == null)
            {
                return NotFound();
            }

            return View(btheS);
        }

        // GET: Admin/BtheS/Create
        public IActionResult Create()
        {
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name");
            return View();
        }

        // POST: Admin/BtheS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Video_Photo,MoviedetailId")] BtheS btheS, IFormFile movieImage)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(movieImage.FileName);
                string purePath = $"BtheS-{Guid.NewGuid()}{ext}";
                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    movieImage.CopyTo(fs);

                }
                btheS.Video_Photo = purePath;
                _context.Add(btheS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", btheS.MoviedetailId);
            return View(btheS);
        }

        // GET: Admin/BtheS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btheS = await _context.BtheSes.FindAsync(id);
            if (btheS == null)
            {
                return NotFound();
            }
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", btheS.MoviedetailId);
            return View(btheS);
        }

        // POST: Admin/BtheS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Video_Photo,MoviedetailId,ImagePathTemp")] BtheS btheS, IFormFile movieImage)
        {
            if (id != btheS.Id)
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
                        string purePath = $"BtheS-{Guid.NewGuid()}{ext}";
                        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                        using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            movieImage.CopyTo(fs);

                        }
                        btheS.Video_Photo = purePath;

                    }
                    else if (!string.IsNullOrWhiteSpace(btheS.ImagePathTemp))
                    {
                        btheS.Video_Photo = btheS.ImagePathTemp;
                    }
                    _context.Update(btheS);
                    await _context.SaveChangesAsync();
                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(btheS.ImagePathTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BtheSExists(btheS.Id))
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
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", btheS.MoviedetailId);
            return View(btheS);
        }

        // GET: Admin/BtheS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var btheS = await _context.BtheSes
                .Include(b => b.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (btheS == null)
            {
                return NotFound();
            }

            return View(btheS);
        }

        // POST: Admin/BtheS/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var btheS = await _context.BtheSes.FindAsync(id);
            _context.BtheSes.Remove(btheS);
            await _context.SaveChangesAsync();
            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", btheS.Video_Photo));
            return Json(new
            {
                error = false,
                message = "ok"
            });
            //return RedirectToAction(nameof(Index));
        }

        private bool BtheSExists(int id)
        {
            return _context.BtheSes.Any(e => e.Id == id);
        }
    }
}
