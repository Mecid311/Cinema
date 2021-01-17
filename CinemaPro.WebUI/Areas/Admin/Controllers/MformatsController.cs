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
    public class MformatsController : Controller
    {
        private readonly CinemaDbContext _context;

        public MformatsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Mformats
        public async Task<IActionResult> Index()
        {
            var cinemaDbContext = _context.Mformats.Include(m => m.Format).Include(m => m.Moviedetail);
            return View(await cinemaDbContext.ToListAsync());
        }

        // GET: Admin/Mformats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mformat = await _context.Mformats
                .Include(m => m.Format)
                .Include(m => m.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mformat == null)
            {
                return NotFound();
            }

            return View(mformat);
        }

        // GET: Admin/Mformats/Create
        public IActionResult Create()
        {
            ViewData["FormatId"] = new SelectList(_context.Formats, "Id", "Name");
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name");
            return View();
        }

        // POST: Admin/Mformats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MoviedetailId,FormatId")] Mformat mformat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mformat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FormatId"] = new SelectList(_context.Formats, "Id", "Name", mformat.FormatId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mformat.MoviedetailId);
            return View(mformat);
        }

        // GET: Admin/Mformats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mformat = await _context.Mformats.FindAsync(id);
            if (mformat == null)
            {
                return NotFound();
            }
            ViewData["FormatId"] = new SelectList(_context.Formats, "Id", "Name", mformat.FormatId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mformat.MoviedetailId);
            return View(mformat);
        }

        // POST: Admin/Mformats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MoviedetailId,FormatId")] Mformat mformat)
        {
            if (id != mformat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mformat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MformatExists(mformat.Id))
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
            ViewData["FormatId"] = new SelectList(_context.Formats, "Id", "Name", mformat.FormatId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mformat.MoviedetailId);
            return View(mformat);
        }

        // GET: Admin/Mformats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mformat = await _context.Mformats
                .Include(m => m.Format)
                .Include(m => m.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mformat == null)
            {
                return NotFound();
            }

            return View(mformat);
        }

        // POST: Admin/Mformats/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mformat = await _context.Mformats.FindAsync(id);
            _context.Mformats.Remove(mformat);
            await _context.SaveChangesAsync();
            return Json(new
            {
                error = false,
                message = "ok"
            });
            //return RedirectToAction(nameof(Index));
        }

        private bool MformatExists(int id)
        {
            return _context.Mformats.Any(e => e.Id == id);
        }
    }
}
