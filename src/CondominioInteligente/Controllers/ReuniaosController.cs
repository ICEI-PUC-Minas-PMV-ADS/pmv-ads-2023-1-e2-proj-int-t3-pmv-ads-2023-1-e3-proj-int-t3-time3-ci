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
    public class ReuniaosController : Controller
    {
        private readonly CondominioInteligenteContext _context;

        public ReuniaosController(CondominioInteligenteContext context)
        {
            _context = context;
        }

        // GET: Reuniaos
        public async Task<IActionResult> Index()
        {
            var condominioInteligenteContext = _context.Reuniao.Include(r => r.UsuarioMaster);
            return View(await condominioInteligenteContext.ToListAsync());
        }

        // GET: Reuniaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reuniao == null)
            {
                return NotFound();
            }

            var reuniao = await _context.Reuniao
                .Include(r => r.UsuarioMaster)
                .FirstOrDefaultAsync(m => m.CodReuniao == id);
            if (reuniao == null)
            {
                return NotFound();
            }

            return View(reuniao);
        }

        // GET: Reuniaos/Create
        public IActionResult Create()
        {
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome");
            return View();
        }

        // POST: Reuniaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodReuniao,Data,NomeReuniao,Pauta,Ata,CodUsuario")] Reuniao reuniao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reuniao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome", reuniao.CodUsuario);
            return View(reuniao);
        }

        // GET: Reuniaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reuniao == null)
            {
                return NotFound();
            }

            var reuniao = await _context.Reuniao.FindAsync(id);
            if (reuniao == null)
            {
                return NotFound();
            }
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome", reuniao.CodUsuario);
            return View(reuniao);
        }

        // POST: Reuniaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodReuniao,Data,NomeReuniao,Pauta,Ata,CodUsuario")] Reuniao reuniao)
        {
            if (id != reuniao.CodReuniao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reuniao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReuniaoExists(reuniao.CodReuniao))
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
            ViewData["CodUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome", reuniao.CodUsuario);
            return View(reuniao);
        }

        // GET: Reuniaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reuniao == null)
            {
                return NotFound();
            }

            var reuniao = await _context.Reuniao
                .Include(r => r.UsuarioMaster)
                .FirstOrDefaultAsync(m => m.CodReuniao == id);
            if (reuniao == null)
            {
                return NotFound();
            }

            return View(reuniao);
        }

        // POST: Reuniaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reuniao == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.Reuniao'  is null.");
            }
            var reuniao = await _context.Reuniao.FindAsync(id);
            if (reuniao != null)
            {
                _context.Reuniao.Remove(reuniao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReuniaoExists(int id)
        {
          return (_context.Reuniao?.Any(e => e.CodReuniao == id)).GetValueOrDefault();
        }
    }
}
