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
    public class RitController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RitController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Rit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rit>>> GetRitten()
        {
            return await _context.Ritten.ToListAsync();
        }

        // GET: api/Rit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rit>> GetRit(int id)
        {
            var rit = await _context.Ritten.FindAsync(id);

            if (rit == null)
            {
                return NotFound();
            }

            return rit;
        }

        // PUT: api/Rit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRit(int id, Rit rit)
        {
            if (id != rit.RitID)
            {
                return BadRequest();
            }

            _context.Entry(rit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RitExists(id))
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

        // POST: api/Rit
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rit>> PostRit(Rit rit)
        {
            _context.Ritten.Add(rit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRit", new { id = rit.RitID }, rit);
        }

        // DELETE: api/Rit/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rit>> DeleteRit(int id)
        {
            var rit = await _context.Ritten.FindAsync(id);
            if (rit == null)
            {
                return NotFound();
            }

            _context.Ritten.Remove(rit);
            await _context.SaveChangesAsync();

            return rit;
        }

        private bool RitExists(int id)
        {
            return _context.Ritten.Any(e => e.RitID == id);
        }
    }
}
