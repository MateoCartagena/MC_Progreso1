using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MC_Progreso1.Data;
using MC_Progreso1.Models;

namespace MC_Progreso1.Controllers
{
    public class MCartagenaController : Controller
    {
        private readonly MC_DBBContext _context;

        public MCartagenaController(MC_DBBContext context)
        {
            _context = context;
        }

        // GET: MCartagena
        public async Task<IActionResult> Index()
        {
              return _context.MCartagena != null ? 
                          View(await _context.MCartagena.ToListAsync()) :
                          Problem("Entity set 'MC_DBBContext.MCartagena'  is null.");
        }

        // GET: MCartagena/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MCartagena == null)
            {
                return NotFound();
            }

            var mCartagena = await _context.MCartagena
                .FirstOrDefaultAsync(m => m.McID == id);
            if (mCartagena == null)
            {
                return NotFound();
            }

            return View(mCartagena);
        }

        // GET: MCartagena/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MCartagena/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("McID,McPromedioGlobal,McSegundoNombre,McSoltero,McFechaHoy")] MCartagena mCartagena)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mCartagena);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mCartagena);
        }

        // GET: MCartagena/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MCartagena == null)
            {
                return NotFound();
            }

            var mCartagena = await _context.MCartagena.FindAsync(id);
            if (mCartagena == null)
            {
                return NotFound();
            }
            return View(mCartagena);
        }

        // POST: MCartagena/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("McID,McPromedioGlobal,McSegundoNombre,McSoltero,McFechaHoy")] MCartagena mCartagena)
        {
            if (id != mCartagena.McID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mCartagena);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MCartagenaExists(mCartagena.McID))
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
            return View(mCartagena);
        }

        // GET: MCartagena/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MCartagena == null)
            {
                return NotFound();
            }

            var mCartagena = await _context.MCartagena
                .FirstOrDefaultAsync(m => m.McID == id);
            if (mCartagena == null)
            {
                return NotFound();
            }

            return View(mCartagena);
        }

        // POST: MCartagena/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MCartagena == null)
            {
                return Problem("Entity set 'MC_DBBContext.MCartagena'  is null.");
            }
            var mCartagena = await _context.MCartagena.FindAsync(id);
            if (mCartagena != null)
            {
                _context.MCartagena.Remove(mCartagena);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MCartagenaExists(int id)
        {
          return (_context.MCartagena?.Any(e => e.McID == id)).GetValueOrDefault();
        }
    }
}
