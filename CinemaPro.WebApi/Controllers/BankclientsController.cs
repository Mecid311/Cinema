using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaPro.Domain.DataContext;
using CinemaPro.Domain.Entity;

namespace CinemaPro.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankclientsController : ControllerBase
    {
        private readonly CinemaDbContext _context;

        public BankclientsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: api/Bankclients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bankclient>>> GetBankclients()
        {
            return await _context.Bankclients.ToListAsync();
        }

        // GET: api/Bankclients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bankclient>> GetBankclient(int id)
        {
            var bankclient = await _context.Bankclients.FindAsync(id);

            if (bankclient == null)
            {
                return NotFound();
            }

            return bankclient;
        }

        // PUT: api/Bankclients/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankclient(int id, Bankclient bankclient)
        {
            if (id != bankclient.Id)
            {
                return BadRequest();
            }

            _context.Entry(bankclient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankclientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bankclients
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Bankclient>> PostBankclient(Bankclient bankclient)
        {
            _context.Bankclients.Add(bankclient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankclient", new { id = bankclient.Id }, bankclient);
        }

        // DELETE: api/Bankclients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bankclient>> DeleteBankclient(int id)
        {
            var bankclient = await _context.Bankclients.FindAsync(id);
            if (bankclient == null)
            {
                return NotFound();
            }

            _context.Bankclients.Remove(bankclient);
            await _context.SaveChangesAsync();

            return bankclient;
        }

        private bool BankclientExists(int id)
        {
            return _context.Bankclients.Any(e => e.Id == id);
        }
    }
}
