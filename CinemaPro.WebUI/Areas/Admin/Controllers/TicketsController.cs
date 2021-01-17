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
    public class TicketsController : Controller
    {
        private readonly CinemaDbContext _context;

        public TicketsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Tickets
        public async Task<IActionResult> Index()
        {
            var cinemaDbContext = _context.Tickets.Include(t => t.Extra).Include(t => t.Moviedetail).Include(t => t.Seat);
            return View(await cinemaDbContext.ToListAsync());
        }

       

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
