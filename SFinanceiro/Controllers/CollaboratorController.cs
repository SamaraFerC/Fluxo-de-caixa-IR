//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using FluxoCaixa.Infra.Data.Context;
//using FluxoCaixa.Domain.Entities;

//namespace SFinanceiro.Controllers
//{
//    [Authorize]
//    public class CollaboratorController : Controller
//    {
//        private readonly AppDbContext _context;

//        public CollaboratorController(AppDbContext context)
//        {
//            _context = context;
//        }

//        public async Task<IActionResult> Index()
//        {
//            //await _context.Collaborator.ToListAsync()
//            return View();
//        }

//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var usuario = "";// await _context.Collaborator
//                //.FirstOrDefaultAsync(m => m.Id == id);
//            if (usuario == null)
//            {
//                return NotFound();
//            }

//            return View(usuario);
//        }

//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("UsuarioId,Name,Email,Password")] Collaborator usuario)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(usuario);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(usuario);
//        }

//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var usuario =""// await _context.Collaborator.FindAsync(id);
//            if (usuario == null)
//            {
//                return NotFound();
//            }
//            return View(usuario);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("UsuarioId,Name,Email,Password")] Collaborator usuario)
//        {
//            if (id != usuario.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(usuario);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!UsuarioExists(usuario.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(usuario);
//        }

//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var usuario = await _context.Collaborator
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (usuario == null)
//            {
//                return NotFound();
//            }

//            return View(usuario);
//        }

//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            var usuario = await _context.Collaborator.FindAsync(id);
//            if (usuario != null)
//            {
//                _context.Collaborator.Remove(usuario);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool UsuarioExists(int id)
//        {
//            return _context.Collaborator.Any(e => e.Id == id);
//        }
//    }
//}
