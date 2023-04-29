using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CondominioInteligente.Data;
using CondominioInteligente.Models;

namespace CondominioInteligente.Controllers
{
    public class AreaComumsController : Controller
    {
        private readonly CondominioInteligenteContext _context;

        public AreaComumsController(CondominioInteligenteContext context)
        {
            _context = context;
        }

        // GET: AreaComums
        public async Task<IActionResult> Index()
        {
              return _context.AreaComum != null ? 
                          View(await _context.AreaComum.ToListAsync()) :
                          Problem("Entity set 'CondominioInteligenteContext.AreaComum'  is null.");
        }

        // GET: AreaComums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AreaComum == null)
            {
                return NotFound();
            }

            var areaComum = await _context.AreaComum
                .FirstOrDefaultAsync(m => m.CodArea == id);
            if (areaComum == null)
            {
                return NotFound();
            }

            return View(areaComum);
        }

        // GET: AreaComums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AreaComums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodArea,Nome")] AreaComum areaComum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(areaComum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(areaComum);
        }

        // GET: AreaComums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AreaComum == null)
            {
                return NotFound();
            }

            var areaComum = await _context.AreaComum.FindAsync(id);
            if (areaComum == null)
            {
                return NotFound();
            }
            return View(areaComum);
        }

        // POST: AreaComums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodArea,Nome")] AreaComum areaComum)
        {
            if (id != areaComum.CodArea)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(areaComum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaComumExists(areaComum.CodArea))
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
            return View(areaComum);
        }

        // GET: AreaComums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AreaComum == null)
            {
                return NotFound();
            }

            var areaComum = await _context.AreaComum
                .FirstOrDefaultAsync(m => m.CodArea == id);
            if (areaComum == null)
            {
                return NotFound();
            }

            return View(areaComum);
        }

        // POST: AreaComums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AreaComum == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.AreaComum'  is null.");
            }
            var areaComum = await _context.AreaComum.FindAsync(id);
            if (areaComum != null)
            {
                _context.AreaComum.Remove(areaComum);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaComumExists(int id)
        {
          return (_context.AreaComum?.Any(e => e.CodArea == id)).GetValueOrDefault();
        }
    }
}
