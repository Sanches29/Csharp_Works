using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exercicio1.Models;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using CsvHelper;

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
            return View(await _context.Emprestimos.Include(c => c.Cliente).Include(c => c.Livro).ToListAsync());
        }

        public async Task<IActionResult> DevoulucaoPendente()
        {
            return View();
        }

        // GET: Emprestimos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprestimos = await _context.Emprestimos.Include(c => c.Cliente).Include(c => c.Livro)
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
            ViewBag.Livro = new SelectList(_context.Livros.ToList(), "IdLivro", "NomeLivro");
            ViewBag.Cliente = new SelectList(_context.Clientes.ToList(), "IdCliente", "NomeCliente");
            return View();
        }

        // POST: Emprestimos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmprestimos,Cliente,Livro,Emprestado,PrevisaoDevolucao,Devolucao")] Emprestimos emprestimos)
        {
            if (ModelState.IsValid)
            {

                if (_context.Emprestimos.Any(x => x.Cliente.IdCliente.Equals(emprestimos.Cliente.IdCliente) && x.Devolucao == null))
                {
                    return RedirectToAction(nameof(DevoulucaoPendente));
                    //return View(emprestimos);

                }
                else
                {
                    emprestimos.Livro = _context.Livros.First(x => x.IdLivro.Equals(emprestimos.Livro.IdLivro));

                    emprestimos.Cliente = _context.Clientes.First(x => x.IdCliente.Equals(emprestimos.Cliente.IdCliente));

                    _context.Add(emprestimos);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
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
            ViewBag.Cliente = new SelectList(_context.Clientes.ToList(), "IdCliente", "NomeCliente");
            ViewBag.Livro = new SelectList(_context.Livros.ToList(), "IdLivro", "NomeLivro");
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
        public async Task<IActionResult> Edit(int id, [Bind("IdEmprestimos,Cliente,Livro,Emprestado,PrevisaoDevolucao,Devolucao")] Emprestimos emprestimos)
        {
            if (id != emprestimos.IdEmprestimos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    emprestimos.Cliente = _context.Clientes.First(x => x.IdCliente.Equals(emprestimos.Cliente.IdCliente));
                    emprestimos.Livro = _context.Livros.First(x => x.IdLivro.Equals(emprestimos.Livro.IdLivro));

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

        public async Task<IActionResult> ExportCSV()
        {
            await using (var sw = new StreamWriter(@"PathArquivoOutput"))
            {
                using (var writer = new CsvWriter(sw, System.Globalization.CultureInfo.CurrentCulture))
                {
                    writer.WriteHeader(typeof(Emprestimos));
                    writer.NextRecord();
                    foreach (Emprestimos s in _context.Emprestimos.Include(c => c.Cliente).Include(c => c.Livro).ThenInclude(c => c.Categoria).ToList<Emprestimos>())
                    {
                        writer.WriteRecord(s);
                        writer.NextRecord();
                    }
                }
            }

            return View();
        }

        public async Task<IActionResult> ExportXML()
        {
            await using (var sw = new StreamWriter(@"PathArquivoOutput"))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<Emprestimos>));
                x.Serialize(sw, _context.Emprestimos.Include(c => c.Cliente).Include(c => c.Livro).ThenInclude(c => c.Categoria).ToList<Emprestimos>());
            }

            return View();
        }
    }
}
