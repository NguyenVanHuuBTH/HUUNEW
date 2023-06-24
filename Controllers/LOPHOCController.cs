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
    public class LOPHOCController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LOPHOCController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LOPHOC
        public async Task<IActionResult> Index()
        {
              return _context.LOPHOC != null ? 
                          View(await _context.LOPHOC.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.LOPHOC'  is null.");
        }

        // GET: LOPHOC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LOPHOC == null)
            {
                return NotFound();
            }

            var lOPHOC = await _context.LOPHOC
                .FirstOrDefaultAsync(m => m.MaLop == id);
            if (lOPHOC == null)
            {
                return NotFound();
            }

            return View(lOPHOC);
        }

        // GET: LOPHOC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LOPHOC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLop,TenLop,SoLuong")] LOPHOC lOPHOC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lOPHOC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lOPHOC);
        }

        // GET: LOPHOC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LOPHOC == null)
            {
                return NotFound();
            }

            var lOPHOC = await _context.LOPHOC.FindAsync(id);
            if (lOPHOC == null)
            {
                return NotFound();
            }
            return View(lOPHOC);
        }

        // POST: LOPHOC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("MaLop,TenLop,SoLuong")] LOPHOC lOPHOC)
        {
            if (id != lOPHOC.MaLop)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lOPHOC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LOPHOCExists(lOPHOC.MaLop))
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
            return View(lOPHOC);
        }

        // GET: LOPHOC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LOPHOC == null)
            {
                return NotFound();
            }

            var lOPHOC = await _context.LOPHOC
                .FirstOrDefaultAsync(m => m.MaLop == id);
            if (lOPHOC == null)
            {
                return NotFound();
            }

            return View(lOPHOC);
        }

        // POST: LOPHOC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.LOPHOC == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LOPHOC'  is null.");
            }
            var lOPHOC = await _context.LOPHOC.FindAsync(id);
            if (lOPHOC != null)
            {
                _context.LOPHOC.Remove(lOPHOC);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LOPHOCExists(int? id)
        {
          return (_context.LOPHOC?.Any(e => e.MaLop == id)).GetValueOrDefault();
        }
    }
}
