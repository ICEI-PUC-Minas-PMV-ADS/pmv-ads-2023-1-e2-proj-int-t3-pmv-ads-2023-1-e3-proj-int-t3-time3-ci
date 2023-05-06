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
    public class SolicitacaoAreaComumsController : Controller
    {
        private readonly CondominioInteligenteContext _context;

        public SolicitacaoAreaComumsController(CondominioInteligenteContext context)
        {
            _context = context;
        }

        // GET: SolicitacaoAreaComums
        public async Task<IActionResult> Index()
        {
            return _context.SolicitacaoAreaComum != null ?
                        View(await _context.SolicitacaoAreaComum.Include(a => a.Area).ToListAsync()) :
                        Problem("Entity set 'CondominioInteligenteContext.SolicitacaoAreaComum'  is null.");
        }

        public async Task<IActionResult> Listagem()
        {
            var solcitacoes = await _context.SolicitacaoAreaComum
                .Include(s => s.UsuarioSolictante)
                .Include(s => s.Area).ToListAsync();
            return PartialView("Index", solcitacoes);
        }

        public async Task<IActionResult> ListarSolicitacao()
        {
            var solcitacoes = await _context.SolicitacaoAreaComum
                .Include(s=> s.UsuarioSolictante)
                .Include(s=> s.Area)
                .Where(s => s.aprovado == null).ToListAsync();
            return PartialView("ListarSolicitacao", solcitacoes);
        }


        // GET: SolicitacaoAreaComums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SolicitacaoAreaComum == null)
            {
                return NotFound();
            }

            var solicitacaoAreaComum = await _context.SolicitacaoAreaComum
                .FirstOrDefaultAsync(m => m.CodSolictacao == id);
            if (solicitacaoAreaComum == null)
            {
                return NotFound();
            }

            return View(solicitacaoAreaComum);
        }

        // GET: SolicitacaoAreaComums/Create
        public IActionResult Create()
        {
            ViewBagSolicitacao();

            return View();
        }



        // POST: SolicitacaoAreaComums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DataInicio,DataFim,CodArea,CodUsuario")] SolicitacaoAreaComum solicitacaoAreaComum)
        {
            if (ModelState.IsValid)
            {
                solicitacaoAreaComum.aprovado = null;
                _context.Add(solicitacaoAreaComum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBagSolicitacao();

            return View(solicitacaoAreaComum);
        }

        private void ViewBagSolicitacao()
        {
            ViewData["OpcoesArea"] = new SelectList(_context.AreaComum, "CodArea", "Nome");
            ViewData["OpcoesUsuario"] = new SelectList(_context.Usuario, "CodUsuario", "Nome");
        }

        // GET: SolicitacaoAreaComums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SolicitacaoAreaComum == null)
            {
                return NotFound();
            }

            var solicitacaoAreaComum = await _context.SolicitacaoAreaComum.FindAsync(id);
            if (solicitacaoAreaComum == null)
            {
                return NotFound();
            }
            return View(solicitacaoAreaComum);
        }

        // POST: SolicitacaoAreaComums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodSolictacao,DataInicio,DataFim,aprovado")] SolicitacaoAreaComum solicitacaoAreaComum)
        {
            if (id != solicitacaoAreaComum.CodSolictacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitacaoAreaComum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitacaoAreaComumExists(solicitacaoAreaComum.CodSolictacao))
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
            return View(solicitacaoAreaComum);
        }

        // GET: SolicitacaoAreaComums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SolicitacaoAreaComum == null)
            {
                return NotFound();
            }

            var solicitacaoAreaComum = await _context.SolicitacaoAreaComum
                .FirstOrDefaultAsync(m => m.CodSolictacao == id);
            if (solicitacaoAreaComum == null)
            {
                return NotFound();
            }

            return View(solicitacaoAreaComum);
        }

        // POST: SolicitacaoAreaComums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SolicitacaoAreaComum == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.SolicitacaoAreaComum'  is null.");
            }
            var solicitacaoAreaComum = await _context.SolicitacaoAreaComum.FindAsync(id);
            if (solicitacaoAreaComum != null)
            {
                _context.SolicitacaoAreaComum.Remove(solicitacaoAreaComum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitacaoAreaComumExists(int id)
        {
            return (_context.SolicitacaoAreaComum?.Any(e => e.CodSolictacao == id)).GetValueOrDefault();
        }


        // POST: SolicitacaoAreaComums/Aprovar/5
        [HttpPost, ActionName("Aprovar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Aprovar(int id)
        {
            if (_context.SolicitacaoAreaComum == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.SolicitacaoAreaComum'  is null.");
            }
            var solicitacaoAreaComum = await _context.SolicitacaoAreaComum.FindAsync(id);
            solicitacaoAreaComum.aprovado = true;

            _context.SolicitacaoAreaComum.Update(solicitacaoAreaComum);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: SolicitacaoAreaComums/Reprovar/5
        [HttpPost, ActionName("Reprovar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reprovar(int id)
        {
            if (_context.SolicitacaoAreaComum == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.SolicitacaoAreaComum'  is null.");
            }
            var solicitacaoAreaComum = await _context.SolicitacaoAreaComum.FindAsync(id);
            solicitacaoAreaComum.aprovado = false;

            _context.SolicitacaoAreaComum.Update(solicitacaoAreaComum);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
