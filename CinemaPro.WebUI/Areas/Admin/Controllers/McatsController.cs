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
    public class McatsController : Controller
    {
        private readonly CinemaDbContext _context;

        public McatsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Mcats
        public async Task<IActionResult> Index()
        {
            var cinemaDbContext = _context.Mcats.Include(m => m.Category).Include(m => m.Moviedetail);
            return View(await cinemaDbContext.ToListAsync());
        }

        // GET: Admin/Mcats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mcat = await _context.Mcats
                .Include(m => m.Category)
                .Include(m => m.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mcat == null)
            {
                return NotFound();
            }

            return View(mcat);
        }

        // GET: Admin/Mcats/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name");
            return View();
        }

        // POST: Admin/Mcats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,MoviedetailId")] Mcat mcat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mcat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", mcat.CategoryId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mcat.MoviedetailId);
            return View(mcat);
        }

        // GET: Admin/Mcats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mcat = await _context.Mcats.FindAsync(id);
            if (mcat == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", mcat.CategoryId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mcat.MoviedetailId);
            return View(mcat);
        }

        // POST: Admin/Mcats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,MoviedetailId")] Mcat mcat)
        {
            if (id != mcat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mcat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!McatExists(mcat.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", mcat.CategoryId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mcat.MoviedetailId);
            return View(mcat);
        }

        // GET: Admin/Mcats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mcat = await _context.Mcats
                .Include(m => m.Category)
                .Include(m => m.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mcat == null)
            {
                return NotFound();
            }

            return View(mcat);
        }

        // POST: Admin/Mcats/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mcat = await _context.Mcats.FindAsync(id);
            _context.Mcats.Remove(mcat);
            await _context.SaveChangesAsync();
           
            return Json(new
            {
                error = false,
                message = "ok"
            });
          //  return RedirectToAction(nameof(Index));
        }

        private bool McatExists(int id)
        {
            return _context.Mcats.Any(e => e.Id == id);
        }
    }
}
