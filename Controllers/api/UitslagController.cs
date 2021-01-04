using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testing0._1.Data;
using Testing0._1.Models;

namespace Testing0._1.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UitslagController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UitslagController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Uitslag
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Uitslag>>> GetUitslagen()
        {
            return await _context.Uitslagen.ToListAsync();
        }

        // GET: api/Uitslag/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Uitslag>> GetUitslag(int id)
        {
            var uitslag = await _context.Uitslagen.FindAsync(id);

            if (uitslag == null)
            {
                return NotFound();
            }

            return uitslag;
        }

        // PUT: api/Uitslag/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUitslag(int id, Uitslag uitslag)
        {
            if (id != uitslag.UitslagID)
            {
                return BadRequest();
            }

            _context.Entry(uitslag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UitslagExists(id))
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

        // POST: api/Uitslag
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Uitslag>> PostUitslag(Uitslag uitslag)
        {
            _context.Uitslagen.Add(uitslag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUitslag", new { id = uitslag.UitslagID }, uitslag);
        }

        // DELETE: api/Uitslag/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Uitslag>> DeleteUitslag(int id)
        {
            var uitslag = await _context.Uitslagen.FindAsync(id);
            if (uitslag == null)
            {
                return NotFound();
            }

            _context.Uitslagen.Remove(uitslag);
            await _context.SaveChangesAsync();

            return uitslag;
        }

        private bool UitslagExists(int id)
        {
            return _context.Uitslagen.Any(e => e.UitslagID == id);
        }
    }
}
