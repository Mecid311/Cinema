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
    public class McastsController : Controller
    {
        private readonly CinemaDbContext _context;

        public McastsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Mcasts
        public async Task<IActionResult> Index()
        {
            var cinemaDbContext = _context.Mcasts.Include(m => m.Cast).Include(m => m.Moviedetail);
            return View(await cinemaDbContext.ToListAsync());
        }

        // GET: Admin/Mcasts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mcast = await _context.Mcasts
                .Include(m => m.Cast)
                .Include(m => m.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mcast == null)
            {
                return NotFound();
            }

            return View(mcast);
        }

        // GET: Admin/Mcasts/Create
        public IActionResult Create()
        {
            ViewData["CastId"] = new SelectList(_context.Casts, "Id", "Fullname");
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name");
            return View();
        }

        // POST: Admin/Mcasts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MoviedetailId,CastId")] Mcast mcast)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mcast);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CastId"] = new SelectList(_context.Casts, "Id", "Fullname", mcast.CastId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mcast.MoviedetailId);
            return View(mcast);
        }

        // GET: Admin/Mcasts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mcast = await _context.Mcasts.FindAsync(id);
            if (mcast == null)
            {
                return NotFound();
            }
            ViewData["CastId"] = new SelectList(_context.Casts, "Id", "Fullname", mcast.CastId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mcast.MoviedetailId);
            return View(mcast);
        }

        // POST: Admin/Mcasts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MoviedetailId,CastId")] Mcast mcast)
        {
            if (id != mcast.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mcast);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!McastExists(mcast.Id))
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
            ViewData["CastId"] = new SelectList(_context.Casts, "Id", "Fullname", mcast.CastId);
            ViewData["MoviedetailId"] = new SelectList(_context.Moviedetails, "Id", "Name", mcast.MoviedetailId);
            return View(mcast);
        }

        // GET: Admin/Mcasts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mcast = await _context.Mcasts
                .Include(m => m.Cast)
                .Include(m => m.Moviedetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mcast == null)
            {
                return NotFound();
            }

            return View(mcast);
        }

        // POST: Admin/Mcasts/Delete/5
        [HttpPost, ActionName("Delete")]
      //  [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mcast = await _context.Mcasts.FindAsync(id);
            _context.Mcasts.Remove(mcast);
            await _context.SaveChangesAsync();
 
            return Json(new
            {
                error = false,
                message = "ok"
            });
            // return RedirectToAction(nameof(Index));
        }

        private bool McastExists(int id)
        {
            return _context.Mcasts.Any(e => e.Id == id);
        }
    }
}
