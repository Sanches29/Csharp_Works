using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exercicio1.Models;

namespace BibliotecaEntity.Controllers
{
    public class EmprestimosController : Controller
    {
        private readonly Context _context;

        public EmprestimosController(Context context)
        {
            _context = context;
        }

        // GET: Emprestimos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Emprestimos.ToListAsync());
        }

        // GET: Emprestimos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprestimos = await _context.Emprestimos
                .FirstOrDefaultAsync(m => m.IdEmprestimos == id);
            if (emprestimos == null)
            {
                return NotFound();
            }

            return View(emprestimos);
        }

        // GET: Emprestimos/Create
        public IActionResult Create()
        {
            ViewBag.Livros = new SelectList(_context.Livros.ToList(), "Id", "Nome");
            ViewBag.CLientes = new SelectList(_context.Clientes.ToList(), "Id", "Nome");
            return View();
        }

        // POST: Emprestimos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmprestimos,Emprestado,PrevisaoDevolucao,Devolucao")] Emprestimos emprestimos)
        {
            if (ModelState.IsValid)
            {
                emprestimos.Livro = _context.Livros.First(x => x.IdLivro.Equals(emprestimos.Livro.IdLivro));

                emprestimos.Cliente = _context.Clientes.First(x => x.IdCliente.Equals(emprestimos.Cliente.IdCliente));

                
                _context.Add(emprestimos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emprestimos);
        }

        // GET: Emprestimos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprestimos = await _context.Emprestimos.FindAsync(id);
            if (emprestimos == null)
            {
                return NotFound();
            }
            return View(emprestimos);
        }

        // POST: Emprestimos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmprestimos,Emprestado,PrevisaoDevolucao,Devolucao")] Emprestimos emprestimos)
        {
            if (id != emprestimos.IdEmprestimos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emprestimos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmprestimosExists(emprestimos.IdEmprestimos))
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
            return View(emprestimos);
        }

        // GET: Emprestimos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprestimos = await _context.Emprestimos
                .FirstOrDefaultAsync(m => m.IdEmprestimos == id);
            if (emprestimos == null)
            {
                return NotFound();
            }

            return View(emprestimos);
        }

        // POST: Emprestimos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emprestimos = await _context.Emprestimos.FindAsync(id);
            _context.Emprestimos.Remove(emprestimos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmprestimosExists(int id)
        {
            return _context.Emprestimos.Any(e => e.IdEmprestimos == id);
        }
    }
}
