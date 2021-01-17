using CinemaPro.Domain.DataContext;
using CinemaPro.Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CinemaPro.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        readonly CinemaDbContext db;
        public HomeController(CinemaDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var model = new HomeViewModel();
            DateTime upcomedate = DateTime.Now.AddDays(5);
            DateTime relesedate = DateTime.Now.AddDays(1);

            model.MovieTit = db.Moviedetails.Where(m => m.Startdate > DateTime.Now).Take(2).ToList();
            //model.MovieUpcome = db.Moviedetails.Include(m => m.Mcats).Where(m => m.Startdate > upcomedate).ToList();
            model.MovieRelesed = db.Moviedetails.Where(m => m.Startdate.Date == DateTime.Now.Date && m.Startdate.Month == DateTime.Now.Month && m.Startdate.Year == DateTime.Now.Year ||
            m.Startdate.Date == relesedate.Date && m.Startdate.Month == relesedate.Month && m.Startdate.Year == relesedate.Year).Take(5).ToList();

            //model.MovieRelesed = db.Moviedetails.ToList();

            model.Mcats = db.Mcats.Include(m => m.Category).Include(m => m.Moviedetail).ToList();
            model.Movietrailer = db.Moviedetails.Include(m => m.Mcats).Where(m => m.Startdate > upcomedate).FirstOrDefault();
            model.Partner = db.Partners.ToList();

            //int catid = db.Mcats.Where(m => m.Moviedetail_id == item.id).Cat_id;
            //db.Categories.Where(c => c.Id = catid).
            return View(model);
        }

        public IActionResult Contact()
        {
            var model = new ContactViewModel();
            model.Contact = db.Contacts.FirstOrDefault();
            model.Contactus = db.Contactuses.FirstOrDefault();
            model.Socialmedia = db.Socialmedias.ToList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel contactView)
        {
            var model = new ContactViewModel();
            model.Contact = db.Contacts.FirstOrDefault();
            model.Contactus = db.Contactuses.FirstOrDefault();
            model.Socialmedia = db.Socialmedias.ToList();



            if (ModelState.IsValid)
            {
                db.Contactuses.Add(contactView.Contactus);
                db.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = $"Sorğunuz qəbul olundu.Tezliklə sizə dönəcəyik";
                

            }

            return View(model);
            
        }



    }
}
