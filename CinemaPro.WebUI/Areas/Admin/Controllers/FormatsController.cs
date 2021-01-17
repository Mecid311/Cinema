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
    public class FormatsController : Controller
    {
        private readonly CinemaDbContext _context;

        public FormatsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Formats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formats.ToListAsync());
        }

        // GET: Admin/Formats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var format = await _context.Formats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (format == null)
            {
                return NotFound();
            }

            return View(format);
        }

        // GET: Admin/Formats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Formats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Format format)
        {
            if (ModelState.IsValid)
            {
                _context.Add(format);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(format);
        }

        // GET: Admin/Formats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var format = await _context.Formats.FindAsync(id);
            if (format == null)
            {
                return NotFound();
            }
            return View(format);
        }

        // POST: Admin/Formats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Format format)
        {
            if (id != format.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(format);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormatExists(format.Id))
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
            return View(format);
        }

        // GET: Admin/Formats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var format = await _context.Formats
                .FirstOrDefaultAsync(m => m.Id == id);
            if (format == null)
            {
                return NotFound();
            }

            return View(format);
        }

        // POST: Admin/Formats/Delete/5
        [HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var format = await _context.Formats.FindAsync(id);
            _context.Formats.Remove(format);
            await _context.SaveChangesAsync();
           
            return Json(new
            {
                error = false,
                message = "ok"
            });
           // return RedirectToAction(nameof(Index));
        }

        private bool FormatExists(int id)
        {
            return _context.Formats.Any(e => e.Id == id);
        }
    }
}
