using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Testing0._1.Data;
using Testing0._1.Models;

namespace Testing0._1.Controllers
{
    public class GebruikerTeamController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GebruikerTeamController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GebruikerTeam
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.GebruikersTeams.Include(g => g.Gebruiker).Include(g => g.Team);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: GebruikerTeam/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gebruikerTeam = await _context.GebruikersTeams
                .Include(g => g.Gebruiker)
                .Include(g => g.Team)
                .FirstOrDefaultAsync(m => m.GebruikerTeamID == id);
            if (gebruikerTeam == null)
            {
                return NotFound();
            }

            return View(gebruikerTeam);
        }

        // GET: GebruikerTeam/Create
        public IActionResult Create()
        {
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "Naam");
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID");
            return View();
        }

        // POST: GebruikerTeam/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GebruikerTeamID,TeamID,GebruikerID")] GebruikerTeam gebruikerTeam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gebruikerTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "Naam", gebruikerTeam.GebruikerID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", gebruikerTeam.TeamID);
            return View(gebruikerTeam);
        }

        // GET: GebruikerTeam/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gebruikerTeam = await _context.GebruikersTeams.FindAsync(id);
            if (gebruikerTeam == null)
            {
                return NotFound();
            }
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "Naam", gebruikerTeam.GebruikerID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", gebruikerTeam.TeamID);
            return View(gebruikerTeam);
        }

        // POST: GebruikerTeam/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GebruikerTeamID,TeamID,GebruikerID")] GebruikerTeam gebruikerTeam)
        {
            if (id != gebruikerTeam.GebruikerTeamID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gebruikerTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GebruikerTeamExists(gebruikerTeam.GebruikerTeamID))
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
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "Naam", gebruikerTeam.GebruikerID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", gebruikerTeam.TeamID);
            return View(gebruikerTeam);
        }

        // GET: GebruikerTeam/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gebruikerTeam = await _context.GebruikersTeams
                .Include(g => g.Gebruiker)
                .Include(g => g.Team)
                .FirstOrDefaultAsync(m => m.GebruikerTeamID == id);
            if (gebruikerTeam == null)
            {
                return NotFound();
            }

            return View(gebruikerTeam);
        }

        // POST: GebruikerTeam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gebruikerTeam = await _context.GebruikersTeams.FindAsync(id);
            _context.GebruikersTeams.Remove(gebruikerTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GebruikerTeamExists(int id)
        {
            return _context.GebruikersTeams.Any(e => e.GebruikerTeamID == id);
        }
    }
}
