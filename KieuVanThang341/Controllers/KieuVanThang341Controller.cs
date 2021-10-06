using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KieuVanThang341.Data;
using KieuVanThang341.Models;

namespace KieuVanThang341.Controllers
{
    public class KieuVanThang341Controller : Controller
    {
        private readonly KieuVanThang341Context _context;

        public KieuVanThang341Controller(KieuVanThang341Context context)
        {
            _context = context;
        }

        // GET: KieuVanThang341
        public async Task<IActionResult> Index()
        {
            return View(await _context.KVT341.ToListAsync());
        }

        // GET: KieuVanThang341/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kVT341 = await _context.KVT341
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (kVT341 == null)
            {
                return NotFound();
            }

            return View(kVT341);
        }

        // GET: KieuVanThang341/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KieuVanThang341/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] KVT341 kVT341)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kVT341);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kVT341);
        }

        // GET: KieuVanThang341/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kVT341 = await _context.KVT341.FindAsync(id);
            if (kVT341 == null)
            {
                return NotFound();
            }
            return View(kVT341);
        }

        // POST: KieuVanThang341/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] KVT341 kVT341)
        {
            if (id != kVT341.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kVT341);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KVT341Exists(kVT341.PersonId))
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
            return View(kVT341);
        }

        // GET: KieuVanThang341/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kVT341 = await _context.KVT341
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (kVT341 == null)
            {
                return NotFound();
            }

            return View(kVT341);
        }

        // POST: KieuVanThang341/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var kVT341 = await _context.KVT341.FindAsync(id);
            _context.KVT341.Remove(kVT341);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KVT341Exists(string id)
        {
            return _context.KVT341.Any(e => e.PersonId == id);
        }
    }
}
