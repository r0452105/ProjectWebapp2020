using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testing0._1.Data;
using Testing0._1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;


namespace Testing0._1.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class NieuwsartikelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NieuwsartikelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Nieuwsartikel
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nieuwsartikel>>> GetNieuwsartikels()
        {
            return await _context.Nieuwsartikels.ToListAsync();
        }

        // GET: api/Nieuwsartikel/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nieuwsartikel>> GetNieuwsartikel(int id)
        {
            var nieuwsartikel = await _context.Nieuwsartikels.FindAsync(id);

            if (nieuwsartikel == null)
            {
                return NotFound();
            }

            return nieuwsartikel;
        }

        // PUT: api/Nieuwsartikel/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNieuwsartikel(int id, Nieuwsartikel nieuwsartikel)
        {
            if (id != nieuwsartikel.NieuwsartikelID)
            {
                return BadRequest();
            }

            _context.Entry(nieuwsartikel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NieuwsartikelExists(id))
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

        // POST: api/Nieuwsartikel
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Nieuwsartikel>> PostNieuwsartikel(Nieuwsartikel nieuwsartikel)
        {
            _context.Nieuwsartikels.Add(nieuwsartikel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNieuwsartikel", new { id = nieuwsartikel.NieuwsartikelID }, nieuwsartikel);
        }

        // DELETE: api/Nieuwsartikel/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Nieuwsartikel>> DeleteNieuwsartikel(int id)
        {
            var nieuwsartikel = await _context.Nieuwsartikels.FindAsync(id);
            if (nieuwsartikel == null)
            {
                return NotFound();
            }

            _context.Nieuwsartikels.Remove(nieuwsartikel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NieuwsartikelExists(int id)
        {
            return _context.Nieuwsartikels.Any(e => e.NieuwsartikelID == id);
        }
    }
}
