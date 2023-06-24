using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CUONGDB.Models;

namespace CUONGDB.Controllers
{
    public class HUUController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HUUController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HUU
        public async Task<IActionResult> Index()
        {
              return _context.HUU != null ? 
                          View(await _context.HUU.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.HUU'  is null.");
        }

        // GET: HUU/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.HUU == null)
            {
                return NotFound();
            }

            var hUU = await _context.HUU
                .FirstOrDefaultAsync(m => m.HUUID == id);
            if (hUU == null)
            {
                return NotFound();
            }

            return View(hUU);
        }

        // GET: HUU/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HUU/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create([Bind("HUUID,HUUName,HUUSđt,HUUSL,HUUSL02")] HUU hUU)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hUU);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hUU);
        }

        // GET: HUU/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.HUU == null)
            {
                return NotFound();
            }

            var hUU = await _context.HUU.FindAsync(id);
            if (hUU == null)
            {
                return NotFound();
            }
            return View(hUU);
        }

        // POST: HUU/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HUUID,HUUName,HUUSđt,HUUSL,HUUSL02")] HUU hUU)
        {
            if (id != hUU.HUUID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hUU);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HUUExists(hUU.HUUID))
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
            return View(hUU);
        }

        // GET: HUU/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.HUU == null)
            {
                return NotFound();
            }

            var hUU = await _context.HUU
                .FirstOrDefaultAsync(m => m.HUUID == id);
            if (hUU == null)
            {
                return NotFound();
            }

            return View(hUU);
        }

        // POST: HUU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.HUU == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HUU'  is null.");
            }
            var hUU = await _context.HUU.FindAsync(id);
            if (hUU != null)
            {
                _context.HUU.Remove(hUU);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HUUExists(string id)
        {
          return (_context.HUU?.Any(e => e.HUUID == id)).GetValueOrDefault();
        }
    }
}
