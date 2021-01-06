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
    public class GebruikerTeamController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GebruikerTeamController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/GebruikerTeam
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GebruikerTeam>>> GetGebruikersTeams()
        {
            return await _context.GebruikersTeams.ToListAsync();
        }

        // GET: api/GebruikerTeam/5
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("{id}")]
        public async Task<ActionResult<GebruikerTeam>> GetGebruikerTeam(int id)
        {
            var gebruikerTeam = await _context.GebruikersTeams.FindAsync(id);

            if (gebruikerTeam == null)
            {
                return NotFound();
            }

            return gebruikerTeam;
        }

        // PUT: api/GebruikerTeam/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGebruikerTeam(int id, GebruikerTeam gebruikerTeam)
        {
            if (id != gebruikerTeam.GebruikerTeamID)
            {
                return BadRequest();
            }

            _context.Entry(gebruikerTeam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GebruikerTeamExists(id))
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

        // POST: api/GebruikerTeam
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GebruikerTeam>> PostGebruikerTeam(GebruikerTeam gebruikerTeam)
        {
            _context.GebruikersTeams.Add(gebruikerTeam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGebruikerTeam", new { id = gebruikerTeam.GebruikerTeamID }, gebruikerTeam);
        }

        // DELETE: api/GebruikerTeam/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GebruikerTeam>> DeleteGebruikerTeam(int id)
        {
            var gebruikerTeam = await _context.GebruikersTeams.FindAsync(id);
            if (gebruikerTeam == null)
            {
                return NotFound();
            }

            _context.GebruikersTeams.Remove(gebruikerTeam);
            await _context.SaveChangesAsync();

            return gebruikerTeam;
        }

        private bool GebruikerTeamExists(int id)
        {
            return _context.GebruikersTeams.Any(e => e.GebruikerTeamID == id);
        }
    }
}
