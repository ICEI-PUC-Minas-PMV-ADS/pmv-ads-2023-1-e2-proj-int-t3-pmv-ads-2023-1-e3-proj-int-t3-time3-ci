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
    public class MoradiasController : Controller
    {
        private readonly CondominioInteligenteContext _context;

        public MoradiasController(CondominioInteligenteContext context)
        {
            _context = context;
        }

        // GET: Moradias
        public async Task<IActionResult> Index()
        {
            var condominioInteligenteContext = _context.Moradia.Include(m => m.Proprietario);
            return View(await condominioInteligenteContext.ToListAsync());
        }

        public async Task<IActionResult> Listagem()
        {
            var condominioInteligenteContext = _context.Moradia.Include(m => m.Proprietario);
            return PartialView("Index", await condominioInteligenteContext.ToListAsync());
        }

        // GET: Moradias


        // GET: Moradias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Moradia == null)
            {
                return NotFound();
            }

            var moradia = await _context.Moradia
                .Include(m => m.Proprietario)
                .FirstOrDefaultAsync(m => m.CodMoradia == id);
            if (moradia == null)
            {
                return NotFound();
            }

            return View(moradia);
        }

        // GET: Moradias/Create
        public IActionResult Create()
        {
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome");
            return View();
        }

        // POST: Moradias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodMoradia,IdentificadorMoradia,CodUsuario")] Moradia moradia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moradia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome", moradia.CodUsuario);
            return View(moradia);
        }

        // GET: Moradias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Moradia == null)
            {
                return NotFound();
            }

            var moradia = await _context.Moradia.FindAsync(id);
            if (moradia == null)
            {
                return NotFound();
            }
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome", moradia.CodUsuario);
            return View(moradia);
        }

        // POST: Moradias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodMoradia,IdentificadorMoradia,CodUsuario")] Moradia moradia)
        {
            if (id != moradia.CodMoradia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moradia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoradiaExists(moradia.CodMoradia))
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
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome", moradia.CodUsuario);
            return View(moradia);
        }

        // GET: Moradias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Moradia == null)
            {
                return NotFound();
            }

            var moradia = await _context.Moradia
                .Include(m => m.Proprietario)
                .FirstOrDefaultAsync(m => m.CodMoradia == id);
            if (moradia == null)
            {
                return NotFound();
            }

            return View(moradia);
        }

        // POST: Moradias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Moradia == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.Moradia'  is null.");
            }
            var moradia = await _context.Moradia.FindAsync(id);
            if (moradia != null)
            {
                _context.Moradia.Remove(moradia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoradiaExists(int id)
        {
          return (_context.Moradia?.Any(e => e.CodMoradia == id)).GetValueOrDefault();
        }
    }
}
