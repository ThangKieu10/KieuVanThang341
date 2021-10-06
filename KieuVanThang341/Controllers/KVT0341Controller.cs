using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KVT0341.Models;
using KieuVanThang341.Data;

namespace KieuVanThang341.Controllers
{
    public class KVT0341Controller : Controller
    {
        private readonly KieuVanThang341Context _context;

        public KVT0341Controller(KieuVanThang341Context context)
        {
            _context = context;
        }

        // GET: KVT0341
        public async Task<IActionResult> Index()
        {
            return View(await _context.KVT0341.ToListAsync());
        }

        // GET: KVT0341/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kVT0341 = await _context.KVT0341
                .FirstOrDefaultAsync(m => m.KVTId == id);
            if (kVT0341 == null)
            {
                return NotFound();
            }

            return View(kVT0341);
        }

        // GET: KVT0341/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KVT0341/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KVTId,KVTName")] KVT0341 kVT0341)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kVT0341);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kVT0341);
        }

        // GET: KVT0341/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kVT0341 = await _context.KVT0341.FindAsync(id);
            if (kVT0341 == null)
            {
                return NotFound();
            }
            return View(kVT0341);
        }

        // POST: KVT0341/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KVTId,KVTName")] KVT0341 kVT0341)
        {
            if (id != kVT0341.KVTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kVT0341);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KVT0341Exists(kVT0341.KVTId))
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
            return View(kVT0341);
        }

        // GET: KVT0341/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kVT0341 = await _context.KVT0341
                .FirstOrDefaultAsync(m => m.KVTId == id);
            if (kVT0341 == null)
            {
                return NotFound();
            }

            return View(kVT0341);
        }

        // POST: KVT0341/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var kVT0341 = await _context.KVT0341.FindAsync(id);
            _context.KVT0341.Remove(kVT0341);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KVT0341Exists(string id)
        {
            return _context.KVT0341.Any(e => e.KVTId == id);
        }
    }
}
