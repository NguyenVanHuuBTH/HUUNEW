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
    public class RUNController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RUNController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RUN
        public async Task<IActionResult> Index()
        {
              return _context.RUN != null ? 
                          View(await _context.RUN.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.RUN'  is null.");
        }

        // GET: RUN/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RUN == null)
            {
                return NotFound();
            }

            var rUN = await _context.RUN
                .FirstOrDefaultAsync(m => m.RUNID == id);
            if (rUN == null)
            {
                return NotFound();
            }

            return View(rUN);
        }

        // GET: RUN/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RUN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RUNID,RUNNAME,RUNADDRESS,RUNSEX")] RUN rUN)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rUN);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rUN);
        }

        // GET: RUN/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RUN == null)
            {
                return NotFound();
            }

            var rUN = await _context.RUN.FindAsync(id);
            if (rUN == null)
            {
                return NotFound();
            }
            return View(rUN);
        }

        // POST: RUN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("RUNID,RUNNAME,RUNADDRESS,RUNSEX")] RUN rUN)
        {
            if (id != rUN.RUNID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rUN);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RUNExists(rUN.RUNID))
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
            return View(rUN);
        }

        // GET: RUN/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RUN == null)
            {
                return NotFound();
            }

            var rUN = await _context.RUN
                .FirstOrDefaultAsync(m => m.RUNID == id);
            if (rUN == null)
            {
                return NotFound();
            }

            return View(rUN);
        }

        // POST: RUN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RUN == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RUN'  is null.");
            }
            var rUN = await _context.RUN.FindAsync(id);
            if (rUN != null)
            {
                _context.RUN.Remove(rUN);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RUNExists(string id)
        {
          return (_context.RUN?.Any(e => e.RUNID == id)).GetValueOrDefault();
        }
    }
}
