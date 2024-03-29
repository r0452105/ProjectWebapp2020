﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Testing0._1.Data;
using Testing0._1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Testing0._1.Controllers
{
    [Authorize]
    public class RitController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RitController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Rit
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ritten.Include(r => r.Race).Include(r => r.Ritsoort);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Rit/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationDbContext = _context.Uitslagen.Include(r => r.Rit).Include(r => r.Gebruiker).Where(r => r.RitID == id).OrderBy(r => r.Resultaat);

            if (applicationDbContext == null)
            {
                return NotFound();
            }

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Rit/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "Naam");
            ViewData["RitsoortID"] = new SelectList(_context.Ritsoorten, "RitsoortID", "Naam");
            return View();
        }

        // POST: Rit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RitID,Afstand,Naam,Datum,Profielfoto,RitsoortID,RaceID")] Rit rit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "RaceID", rit.RaceID);
            ViewData["RitsoortID"] = new SelectList(_context.Ritsoorten, "RitsoortID", "RitsoortID", rit.RitsoortID);
            return View(rit);
        }

        // GET: Rit/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rit = await _context.Ritten.FindAsync(id);
            if (rit == null)
            {
                return NotFound();
            }
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "RaceID", rit.RaceID);
            ViewData["RitsoortID"] = new SelectList(_context.Ritsoorten, "RitsoortID", "RitsoortID", rit.RitsoortID);
            return View(rit);
        }

        // POST: Rit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RitID,Afstand,Naam,Datum,Profielfoto,RitsoortID,RaceID")] Rit rit)
        {
            if (id != rit.RitID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RitExists(rit.RitID))
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
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "RaceID", rit.RaceID);
            ViewData["RitsoortID"] = new SelectList(_context.Ritsoorten, "RitsoortID", "RitsoortID", rit.RitsoortID);
            return View(rit);
        }

        // GET: Rit/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rit = await _context.Ritten
                .Include(r => r.Race)
                .Include(r => r.Ritsoort)
                .FirstOrDefaultAsync(m => m.RitID == id);
            if (rit == null)
            {
                return NotFound();
            }

            return View(rit);
        }

        // POST: Rit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rit = await _context.Ritten.FindAsync(id);
            _context.Ritten.Remove(rit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RitExists(int id)
        {
            return _context.Ritten.Any(e => e.RitID == id);
        }
    }
}
