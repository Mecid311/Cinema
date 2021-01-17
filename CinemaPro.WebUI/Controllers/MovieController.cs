using CinemaPro.Domain.DataContext;
using CinemaPro.Domain.Entity;
using CinemaPro.Domain.ViewModel;
using CinemaPro.WebUI.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace CinemaPro.WebUI.Controllers
{
    [AllowAnonymous]
    public class MovieController : Controller
    {
        readonly CinemaDbContext db;
        public MovieController(CinemaDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            DateTime upcomedate = DateTime.Now.AddDays(7);
            DateTime relesedate = DateTime.Now.AddDays(1);

            model.MovieTit = db.Moviedetails.Where(m => m.Startdate > DateTime.Now).Take(2).ToList();
            model.MovieUpcome = db.Moviedetails.Include(m => m.Mcats).Include(m => m.Director).ToList();

            model.Categories = db.Categories.Include(c => c.Mcats).ToList();
           

            return View(model);
        }
        public IActionResult Single(int? id, int? directorid)
        {
            var model = new HomeViewModel();

            model.Movietrailer = db.Moviedetails.Include(m => m.Director).Include(m => m.Mformats).FirstOrDefault(m => m.Id == id);
            model.Mcasts = db.Mcasts.Include(c => c.Cast).Where(c => c.MoviedetailId == id).ToList();
            model.Categories = db.Categories.Include(c => c.Mcats).Where(c => c.Id == id).ToList();
            model.BtheS = db.BtheSes.Where(b => b.MoviedetailId == id).ToList();
            model.MovieUpcome = db.Moviedetails.Include(m => m.Director).Where(m => m.DirectorId == directorid).ToList();
            model.Mformats = db.Mformats.Include(m => m.Format).Where(m => m.MoviedetailId == id).ToList();
            return View(model);
        }

        public IActionResult Getmovies(int? catid)
        {

            IQueryable<Moviedetail> query = db.Moviedetails.Include(m => m.Mcats)
                    .ThenInclude(mc => mc.Category)
                    .Include(m => m.Director);

            if (catid != 0)
            {
                query = query.Where(m => m.Mcats.Any(mc => mc.CategoryId == catid));

            }

            return Ok(query.ToList());

            
        }

        public IActionResult Search(string text)
        {
           
            IQueryable<Moviedetail> query = db.Moviedetails.Include(m => m.Mcats)
                   .ThenInclude(mc => mc.Category)
                   .Include(m => m.Director);
            if (!string.IsNullOrEmpty(text))
            {
                query = query.Where(m => m.Name.Contains(text));
            }

            return Ok(query.AsNoTracking().ToList());
        }

        public IActionResult MovieBooking(int id)
        {
            var model = new ExtraViewModel();
            model.Extras = db.Extras.ToList();
            model.Movieid = id;
            return View(model);
        }
        public IActionResult MovieSeat(int id,int MovieId)
        {
            var model = new SeatViewModel();
            model.SeatC1 = db.Seats.Where(a=>a.Column==1 && a.Row=="C").ToList();
            model.SeatC2 = db.Seats.Where(a => a.Column == 2 && a.Row == "C").ToList();
            model.SeatC3 = db.Seats.Where(a => a.Column == 3 && a.Row == "C").ToList();
            model.SeatB1 = db.Seats.Where(a => a.Column == 1 && a.Row == "B").ToList();
            model.SeatB2 = db.Seats.Where(a => a.Column == 2 && a.Row == "B").ToList();
            model.SeatB3 = db.Seats.Where(a => a.Column == 3 && a.Row == "B").ToList();
            model.SeatA1 = db.Seats.Where(a => a.Column == 1 && a.Row == "A").ToList();
            model.SeatA2 = db.Seats.Where(a => a.Column == 2 && a.Row == "A").ToList();
            model.SeatA3 = db.Seats.Where(a => a.Column == 3 && a.Row == "A").ToList();
            model.Tickets = db.Tickets.ToList();

            model.ExtraId = id;
            model.MovieId = MovieId;
            return View(model);
        }
        public IActionResult MovieType(int seatid,int movieid,int extraid)
        {
            var model = new TypeViewModel();
            model.Moviedetail = db.Moviedetails.Include(m=>m.Language).FirstOrDefault(m => m.Id == movieid);
            model.Extra = db.Extras.FirstOrDefault(m => m.Id == extraid);
            model.Seat = db.Seats.FirstOrDefault(m => m.Id == seatid);
            model.Totalamount = Convert.ToInt32(db.Moviedetails.Include(m => m.Language)
                .FirstOrDefault(m => m.Id == movieid).Price) + Convert.ToInt32(db.Extras.FirstOrDefault(m => m.Id == extraid).Cost);
            model.Cat = db.Mcats.Include(m => m.Moviedetail).Include(m => m.Category).FirstOrDefault(m => m.MoviedetailId == movieid).Category.Name;
            model.Format= db.Mformats.Include(m => m.Moviedetail).Include(m => m.Format).FirstOrDefault(m => m.MoviedetailId == movieid).Format.Name;
            var ticket = new Ticket();
            ticket.ExtraId = extraid;
            ticket.MoviedetailId = movieid;
            ticket.SeatId = seatid;
            ticket.Totalamount = model.Totalamount.ToString();
            db.Tickets.Add(ticket);
            db.SaveChanges();
            model.Ticketid = db.Tickets.FirstOrDefault(t => t.ExtraId == extraid && t.MoviedetailId == movieid && t.SeatId == seatid).Id;
            return View(model);
        }

        //public IActionResult MoviePay(int id)
        //{
        //    var model = db.Tickets.Find(id);
        //    return View(model);
        //}



        public IActionResult Confirmation(int id)
        {
            var model = db.Tickets.Find(id);
            Random rnd = new Random();
            int ticketclientcode = rnd.Next(10000, 20000000);
            model.Clientcode = ticketclientcode.ToString();
            db.SaveChanges();
            return View(model);
        }
    }
}
