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
    public class NieuwsartikelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NieuwsartikelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Nieuwsartikel
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nieuwsartikels.ToListAsync());
        }

        public async Task<IActionResult> Indexadmin()
        {
            return View(await _context.Nieuwsartikels.ToListAsync());
        }

        // GET: Nieuwsartikel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nieuwsartikel = await _context.Nieuwsartikels
                .FirstOrDefaultAsync(m => m.NieuwsartikelID == id);
            if (nieuwsartikel == null)
            {
                return NotFound();
            }

            return View(nieuwsartikel);
        }

        // GET: Nieuwsartikel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nieuwsartikel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NieuwsartikelID,Titel,KorteOmschrijving,ArtikelTekst,Artikelfoto")] Nieuwsartikel nieuwsartikel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nieuwsartikel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nieuwsartikel);
        }

        // GET: Nieuwsartikel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nieuwsartikel = await _context.Nieuwsartikels.FindAsync(id);
            if (nieuwsartikel == null)
            {
                return NotFound();
            }
            return View(nieuwsartikel);
        }

        // POST: Nieuwsartikel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NieuwsartikelID,Titel,KorteOmschrijving,ArtikelTekst,Artikelfoto")] Nieuwsartikel nieuwsartikel)
        {
            if (id != nieuwsartikel.NieuwsartikelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nieuwsartikel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NieuwsartikelExists(nieuwsartikel.NieuwsartikelID))
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
            return View(nieuwsartikel);
        }

        // GET: Nieuwsartikel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nieuwsartikel = await _context.Nieuwsartikels
                .FirstOrDefaultAsync(m => m.NieuwsartikelID == id);
            if (nieuwsartikel == null)
            {
                return NotFound();
            }

            return View(nieuwsartikel);
        }

        // POST: Nieuwsartikel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nieuwsartikel = await _context.Nieuwsartikels.FindAsync(id);
            _context.Nieuwsartikels.Remove(nieuwsartikel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NieuwsartikelExists(int id)
        {
            return _context.Nieuwsartikels.Any(e => e.NieuwsartikelID == id);
        }
    }
}
