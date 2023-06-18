using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CondominioInteligente.Data;
using CondominioInteligente.Models;
using Microsoft.IdentityModel.Tokens;
using CondominioInteligente.Models.DTO;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace CondominioInteligente.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly CondominioInteligenteContext _context;

        public UsuariosController(CondominioInteligenteContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login([Bind("Email,Senha")] LoginDto usuario)
        {
            if (usuario.Senha.IsNullOrEmpty() && usuario.Email.IsNullOrEmpty())
            {
                return View();
            }

            var user = await _context.Usuario.FirstOrDefaultAsync(m => m.Email == usuario.Email);

            if (user==null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();
            }
            
            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha);

            if (isSenhaOk)
            {
                
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString()),
                };

                var userIntentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIntentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(1),
                    IsPersistent = true,

                };

                await HttpContext.SignInAsync(principal, props);


                return Redirect("/");
            }
            

            ViewBag.Message = "Usuário e/ou senha inválidos!";
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Usuarios");
        
        }

        [AllowAnonymous]
        public async Task<IActionResult> AccessDenied()
        {
            return RedirectToAction("Login", "Usuarios");
        }

        public async Task<IActionResult> Index()
        {
            return _context.Usuario != null ?
                          View(await _context.Usuario.ToListAsync()) :
                          Problem("Entity set 'CondominioInteligenteContext.Usuario'  is null.");
        }
        public async Task<IActionResult> Listagem()
        {
            var usarios = await _context.Usuario.Where(u => u.CodTipoUsuario == 1).ToListAsync();

            return PartialView("Index", usarios);
        }
        public async Task<IActionResult> ListarAprovacoes()
        {
            var usarios = await _context.Usuario.Where(u => u.CodTipoUsuario == 1 && u.Aprovado == null).ToListAsync();

            return PartialView("ListarAprovacoes", usarios);
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.CodUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [AllowAnonymous]
        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodUsuario,CodTipoUsuario,Nome,Email,Telefone,Senha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {   usuario.Senha= BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                usuario.Aprovado = null;
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodUsuario,CodTipoUsuario,Nome,Email,Telefone,Senha")] Usuario usuario)
        {
            if (id != usuario.CodUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.CodUsuario))
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
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuario == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.CodUsuario == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.Usuario'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // POST: Usuarios/Aprovar/5
        [HttpPost, ActionName("Aprovar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Aprovar(int id)
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.Usuario'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                usuario.Aprovado = true;
                _context.Usuario.Update(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // POST: Usuarios/Reprovar/5
        [HttpPost, ActionName("Reprovar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reprovar(int id)
        {
            if (_context.Usuario == null)
            {
                return Problem("Entity set 'CondominioInteligenteContext.Usuario'  is null.");
            }
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario != null)
            {
                usuario.Aprovado = false;
                _context.Usuario.Update(usuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return (_context.Usuario?.Any(e => e.CodUsuario == id)).GetValueOrDefault();
        }
    }
}
