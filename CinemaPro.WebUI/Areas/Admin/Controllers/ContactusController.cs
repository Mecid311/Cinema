using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaPro.Domain.DataContext;
using CinemaPro.Domain.Entity;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Net;

namespace CinemaPro.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactusController : Controller
    {
        private readonly CinemaDbContext _context;
        readonly IConfiguration conf;

        public ContactusController(CinemaDbContext context, IConfiguration conf)
        {
            _context = context;
            this.conf = conf;
        }

        // GET: Admin/Contactus
        public async Task<IActionResult> Index(int? typeId)
        {
            var query = _context.Contactuses.AsQueryable();
            if (typeId.HasValue && typeId.Value == 1)
            {
                query = query.Where(c => c.Answer == null);
            }
            return View(await query.ToListAsync());
        }

        // GET: Admin/Contactus/Answer/5
        public async Task<IActionResult> Answer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactus = await _context.Contactuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactus == null)
            {
                return NotFound();
            }
            if (contactus.Answer != null)
            {
                return BadRequest();
            }

            return View(contactus);
        }

        // GET: Admin/Contactus/Answer/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Answer(int id, [Bind("Id,Answer")] Contactus contact)
        {
            try
            {
                if (id != contact.Id)
                {
                    return BadRequest();
                }
                var contactus = await _context.Contactuses
                .FirstOrDefaultAsync(m => m.Id == id);
                if (contactus == null)
                {
                    return NotFound();
                }
             
                if (contactus.Answer != null)
                {
                    return BadRequest();
                }

                contactus.Answer = contact.Answer;
                var host = conf.GetValue<string>("emailAccount:smtpServer");
                var port = conf.GetValue<int>("emailAccount:smtpPort");
                var userName = conf.GetValue<string>("emailAccount:UserName");
                var password = conf.GetValue<string>("emailAccount:password");
                var cc = conf.GetValue<string>("emailAccount:cc").
                    Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);


                SmtpClient client = new SmtpClient(host, port);
                client.Credentials = new NetworkCredential(userName, password);
                client.EnableSsl = true;
                
                MailMessage message = new MailMessage(userName, contactus.Mail);


                foreach (var mailAddress in cc)
                {
                    message.CC.Add(mailAddress);
                }
                message.Subject = "CinemaPro.WebUI";
                message.Body = contactus.Answer;
                message.IsBodyHtml = true;

                client.Send(message);

                _context.Entry(contactus).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                TempData["message"] = "Cavablandırıldı";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                throw;
            }


            
        }


        private bool ContactusExists(int id)
        {
            return _context.Contactuses.Any(e => e.Id == id);
        }
    }
}
