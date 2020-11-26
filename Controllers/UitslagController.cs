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
    public class UitslagController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UitslagController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Uitslag
        public async Task<IActionResult> Index(string searchname)
        {
            if (!String.IsNullOrEmpty(searchname))
            {
                var applicationDbContext = _context.Uitslagen.Include(u => u.Gebruiker).Include(u => u.Rit).Where(u => u.Gebruiker.Naam.Contains(searchname)|| u.Gebruiker.Voornaam.Contains(searchname));
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                var applicationDbContext = _context.Uitslagen.Include(u => u.Gebruiker).Include(u => u.Rit);
                return View(await applicationDbContext.ToListAsync());
            }
        }

        // GET: Uitslag/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uitslag = await _context.Uitslagen
                .Include(u => u.Gebruiker)
                .Include(u => u.Rit)
                .Include(u => u.Rit.Ritsoort)
                .FirstOrDefaultAsync(m => m.UitslagID == id);
            if (uitslag == null)
            {
                return NotFound();
            }

            return View(uitslag);
        }

        // GET: Uitslag/Create
        public IActionResult Create()
        {
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "VolledigeNaam");
            ViewData["RitID"] = new SelectList(_context.Ritten, "RitID", "Naam");
            return View();
        }

        // POST: Uitslag/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UitslagID,Puntenklassement,Bergklassement,Strijdlustklassement,Resultaat,Algemeenklassement,RitID,GebruikerID")] Uitslag uitslag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uitslag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "VolledigeNaam", uitslag.GebruikerID);
            ViewData["RitID"] = new SelectList(_context.Ritten, "RitID", "Naam", uitslag.RitID);
            return View(uitslag);
        }

        // GET: Uitslag/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uitslag = await _context.Uitslagen.FindAsync(id);
            if (uitslag == null)
            {
                return NotFound();
            }
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "VolledigeNaam", uitslag.GebruikerID);
            ViewData["RitID"] = new SelectList(_context.Ritten, "RitID", "Naam", uitslag.RitID);
            return View(uitslag);
        }

        // POST: Uitslag/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UitslagID,Puntenklassement,Bergklassement,Strijdlustklassement,Resultaat,Algemeenklassement,RitID,GebruikerID")] Uitslag uitslag)
        {
            if (id != uitslag.UitslagID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uitslag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UitslagExists(uitslag.UitslagID))
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
            ViewData["GebruikerID"] = new SelectList(_context.Gebruikers, "GebruikerID", "VolledigeNaam", uitslag.GebruikerID);
            ViewData["RitID"] = new SelectList(_context.Ritten, "RitID", "Naam", uitslag.RitID);
            return View(uitslag);
        }

        // GET: Uitslag/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uitslag = await _context.Uitslagen
                .Include(u => u.Gebruiker)
                .Include(u => u.Rit)
                .FirstOrDefaultAsync(m => m.UitslagID == id);
            if (uitslag == null)
            {
                return NotFound();
            }

            return View(uitslag);
        }

        // POST: Uitslag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uitslag = await _context.Uitslagen.FindAsync(id);
            _context.Uitslagen.Remove(uitslag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UitslagExists(int id)
        {
            return _context.Uitslagen.Any(e => e.UitslagID == id);
        }
    }
}
