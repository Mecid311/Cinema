using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaPro.Domain.DataContext;
using CinemaPro.Domain.Entity;

namespace CinemaPro.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialmediasController : Controller
    {
        private readonly CinemaDbContext _context;

        public SocialmediasController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Socialmedias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Socialmedias.ToListAsync());
        }

        // GET: Admin/Socialmedias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialmedia = await _context.Socialmedias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialmedia == null)
            {
                return NotFound();
            }

            return View(socialmedia);
        }

        // GET: Admin/Socialmedias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Socialmedias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Link,Logo")] Socialmedia socialmedia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socialmedia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socialmedia);
        }

        // GET: Admin/Socialmedias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialmedia = await _context.Socialmedias.FindAsync(id);
            if (socialmedia == null)
            {
                return NotFound();
            }
            return View(socialmedia);
        }

        // POST: Admin/Socialmedias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Link,Logo")] Socialmedia socialmedia)
        {
            if (id != socialmedia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socialmedia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialmediaExists(socialmedia.Id))
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
            return View(socialmedia);
        }

        // GET: Admin/Socialmedias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialmedia = await _context.Socialmedias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialmedia == null)
            {
                return NotFound();
            }

            return View(socialmedia);
        }

        // POST: Admin/Socialmedias/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socialmedia = await _context.Socialmedias.FindAsync(id);
            _context.Socialmedias.Remove(socialmedia);
            await _context.SaveChangesAsync();
            return Json(new
            {
                error = false,
                message = "ok"
            });
        }

        private bool SocialmediaExists(int id)
        {
            return _context.Socialmedias.Any(e => e.Id == id);
        }
    }
}
