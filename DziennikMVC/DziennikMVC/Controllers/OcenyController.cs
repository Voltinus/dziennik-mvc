using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DziennikMVC.Models;

namespace DziennikMVC.Controllers
{
    public class OcenyController : Controller
    {
        private readonly DziennikDbContext _context;

        public OcenyController(DziennikDbContext context)
        {
            _context = context;
        }

        // GET: Oceny
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ocena.ToListAsync());
        }

        // GET: Oceny/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocena = await _context.Ocena
                .FirstOrDefaultAsync(m => m.OcenaId == id);
            if (ocena == null)
            {
                return NotFound();
            }

            return View(ocena);
        }

        // GET: Oceny/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Oceny/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OcenaId,ocena,opis_oceny,czy_koncowa,data,UczenId,NauczycielId,PrzedmiotId")] Ocena ocena)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocena);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ocena);
        }

        // GET: Oceny/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocena = await _context.Ocena.FindAsync(id);
            if (ocena == null)
            {
                return NotFound();
            }
            return View(ocena);
        }

        // POST: Oceny/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OcenaId,ocena,opis_oceny,czy_koncowa,data,UczenId,NauczycielId,PrzedmiotId")] Ocena ocena)
        {
            if (id != ocena.OcenaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ocena);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcenaExists(ocena.OcenaId))
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
            return View(ocena);
        }

        // GET: Oceny/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocena = await _context.Ocena
                .FirstOrDefaultAsync(m => m.OcenaId == id);
            if (ocena == null)
            {
                return NotFound();
            }

            return View(ocena);
        }

        // POST: Oceny/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ocena = await _context.Ocena.FindAsync(id);
            _context.Ocena.Remove(ocena);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcenaExists(int id)
        {
            return _context.Ocena.Any(e => e.OcenaId == id);
        }
    }
}
