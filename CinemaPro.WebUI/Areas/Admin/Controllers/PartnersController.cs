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
    public class PartnersController : Controller
    {
        private readonly CinemaDbContext _context;

        public PartnersController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Partners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Partners.ToListAsync());
        }

        // GET: Admin/Partners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // GET: Admin/Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Partners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Logo")] Partner partner, IFormFile LogoImage)
        {
            if (ModelState.IsValid)
            {
                var ext = Path.GetExtension(LogoImage.FileName);
                string purePath = $"part-{Guid.NewGuid()}{ext}";
                string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                {
                    LogoImage.CopyTo(fs);

                }
                partner.Logo = purePath;
                _context.Add(partner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }

        // GET: Admin/Partners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners.FindAsync(id);
            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        // POST: Admin/Partners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Logo,LogoTemp")] Partner partner, IFormFile LogoImage)
        {
            if (id != partner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string path = _context.Partners.AsNoTracking().FirstOrDefault(p => p.Id == id)?.Logo;
                    if (LogoImage != null)
                    {
                        string ext = Path.GetExtension(LogoImage.FileName);
                        string purePath = $"cast-{Guid.NewGuid()}{ext}";
                        string fileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", purePath);
                        using (var fs = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write))
                        {
                            LogoImage.CopyTo(fs);

                        }
                        partner.Logo = purePath;

                    }
                    else if (!string.IsNullOrWhiteSpace(partner.LogoTemp))
                    {
                        partner.Logo = partner.LogoTemp;
                    }
                    _context.Update(partner);
                    await _context.SaveChangesAsync();

                    if (!string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(partner.LogoTemp))
                    {
                        System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", path));
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartnerExists(partner.Id))
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
            return View(partner);
        }

        // GET: Admin/Partners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partner = await _context.Partners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // POST: Admin/Partners/Delete/5
        [HttpPost, ActionName("Delete")]
       //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
             var partner = await _context.Partners.FirstOrDefaultAsync(m=>m.Id==id);
            _context.Partners.Remove(partner);
            await _context.SaveChangesAsync();
            System.IO.File.Delete(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", partner.Logo));
            return Json(new
            {
                error = false,
                message = "ok"
            });
            // return RedirectToAction(nameof(Index));
        }

        private bool PartnerExists(int id)
        {
            return _context.Partners.Any(e => e.Id == id);
        }
    }
}
