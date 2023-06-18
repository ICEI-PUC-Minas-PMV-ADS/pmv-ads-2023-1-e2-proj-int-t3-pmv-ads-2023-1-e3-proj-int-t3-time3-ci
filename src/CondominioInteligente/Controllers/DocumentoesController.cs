using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CondominioInteligente.Data;
using CondominioInteligente.Models;
using Microsoft.AspNetCore.Authorization;

namespace CondominioInteligente.Controllers
{
    [Authorize]
    public class DocumentoesController : Controller
    {
        private readonly CondominioInteligenteContext _context;

        public DocumentoesController(CondominioInteligenteContext context)
        {
            _context = context;
        }

        // GET: Documentoes
        public async Task<IActionResult> Index()
        {
            var condominioInteligenteContext = _context.Documento.Include(d => d.Reuniao);
            return View(await condominioInteligenteContext.ToListAsync());
        }

        public async Task<IActionResult> Listagem()
        {
            var condominioInteligenteContext = _context.Documento.Include(d => d.Reuniao);
            return PartialView("Index", await condominioInteligenteContext.ToListAsync());
        }

        // GET: Documentoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Documento == null)
            {
                return NotFound();
            }

            var documento = await _context.Documento
                .Include(d => d.Reuniao)
                .FirstOrDefaultAsync(m => m.CodDocumento == id);
            if (documento == null)
            {
                return NotFound();
            }

            return View(documento);
        }

        // GET: Documentoes/Create
        public IActionResult Create(int? codReuniao = null)
        {
            ViewData["CodReuniao"] = new SelectList(_context.Reuniao, "CodReuniao", "Pauta");
            if (codReuniao == null)
                return View();
            else
            {
                ViewData["retornarReuniao"] = true;
                return View(new Documento { CodReuniao = codReuniao.Value });
            }
        }

        // POST: Documentoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodDocumento,Arquivo,CodReuniao")] Documento documento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodReuniao"] = new SelectList(_context.Reuniao, "CodReuniao", "Pauta", documento.CodReuniao);
            return View(documento);
        }

        // GET: Documentoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Documento == null)
            {
                return NotFound();
            }

            var documento = await _context.Documento.FindAsync(id);
            if (documento == null)
            {
                return NotFound();
            }
            ViewData["CodReuniao"] = new SelectList(_context.Reuniao, "CodReuniao", "Pauta", documento.CodReuniao);
            return View(documento);
        }

        // POST: Documentoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodDocumento,Arquivo,CodReuniao")] Documento documento)
        {
            if (id != documento.CodDocumento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(documento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentoExists(documento.CodDocumento))
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
            ViewData["CodReuniao"] = new SelectList(_context.Reuniao, "CodReuniao", "Pauta", documento.CodReuniao);
            return View(documento);
        }

        // GET: Documentoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Documento == null)
            {
                return NotFound();
            }

            var documento = await _context.Documento
                .Include(d => d.Reuniao)
                .FirstOrDefaultAsync(m => m.CodDocumento == id);
            if (documento == null)
            {
                return NotFound();
            }

            return View(documento);
        }

        // POST: Documentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Documento == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.Documento'  is null.");
            }
            var documento = await _context.Documento.FindAsync(id);
            if (documento != null)
            {
                _context.Documento.Remove(documento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentoExists(int id)
        {
            return (_context.Documento?.Any(e => e.CodDocumento == id)).GetValueOrDefault();
        }
    }
}
