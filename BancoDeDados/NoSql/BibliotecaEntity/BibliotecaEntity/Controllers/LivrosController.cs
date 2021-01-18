using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Exercicio1.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BibliotecaEntity.Controllers
{
    public class LivrosController : Controller
    {
        private readonly Context _context;

        public LivrosController(Context context)
        {
            _context = context;
        }

        // GET: Livroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Livros.Include(c => c.Categoria).ToListAsync());
        }

        // GET: Livroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livroes/Create
        public IActionResult Create()
        {
            /*
            List<Categoria> categorias = _context.Categorias.ToList();
            List<SelectListItem> ItensCategoria = new List<SelectListItem>();
            for(int i = 0; i < categorias.Count; i++)
            {
                SelectListItem item = new SelectListItem();
                item.Text = categorias[i].NomeCategoria;
                item.Value = categorias[i].IdCategoria.ToString();
                //item.Selected
                ItensCategoria.Add(item);
            }
            ViewBag.Categorias2 = ItensCategoria; */

            ViewBag.Categoria = new SelectList(_context.Categorias.ToList(), "IdCategoria", "NomeCategoria");
            return View();
        }

        // POST: Livroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLivro,NomeLivro,Categoria,Autor,Ativo")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                Categoria CategoriaSelecionada = _context.Categorias.First(x => x.IdCategoria.Equals(livro.Categoria.IdCategoria));
                livro.Categoria = CategoriaSelecionada;

                var client = new MongoClient();
                var database = client.GetDatabase("Biblioteca");
                var collection = database.GetCollection<BsonDocument>("BibliotecaLogs");

                var document = new BsonDocument
                {
                    {"Nome Alterado", livro.NomeLivro },
                    {"Autor Alterado", livro.Autor },
                    {"Categoria Alterada", livro.Categoria.NomeCategoria},
                    {"Ativo Alterado", livro.Ativo },
                    {"Data", DateTime.Now },
                    {"Ação", "Insert" }
                };

                collection.InsertOne(document);

                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        // GET: Livroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FindAsync(id);
            ViewBag.CategoriaEdit = new SelectList(_context.Categorias.ToList(), "IdCategoria", "NomeCategoria");
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        // POST: Livroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLivro,NomeLivro,Autor,Categoria,Ativo")] Livro livro)
        {
            if (id != livro.IdLivro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
                try
                {

                    //var objetoLivroOriginal = _context.Livros.AsNoTracking().First(x => x.IdLivro.Equals(livro.IdLivro));
                    //objetoLivroOriginal.Categoria = _context.Categorias.First(c => c.IdCategoria.Equals(livro.Categoria.IdCategoria));

                    var objetoLivroOriginal = await _context.Livros.AsNoTracking().Include(c => c.Categoria)
                      .FirstOrDefaultAsync(m => m.IdLivro == livro.IdLivro);

                    livro.Categoria = _context.Categorias.First(x => x.IdCategoria.Equals(livro.Categoria.IdCategoria));

                    var client = new MongoClient();
                    var database = client.GetDatabase("Biblioteca");
                    var collection = database.GetCollection<BsonDocument>("BibliotecaLogs");

                    var document = new BsonDocument
               {
                    {"Nome Original", objetoLivroOriginal.NomeLivro},
                    {"Nome Alterado", livro.NomeLivro },
                    {"Autor Original", objetoLivroOriginal.Autor},
                    {"Autor Alterado", livro.Autor },
                    {"Categoria Original", objetoLivroOriginal.Categoria.NomeCategoria},
                    {"Categoria Alterada", livro.Categoria.NomeCategoria},
                    {"Ativo Original", objetoLivroOriginal.Ativo},
                    {"Ativo Alterado", livro.Ativo },
                    {"Data", DateTime.Now },
                    {"Ação", "Edit" }
                };

                    collection.InsertOne(document);

                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.IdLivro))
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
            return View(livro);
        }

        // GET: Livroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            //var livro = await _context.Livros.Include(c => c.Categoria)
              //  .FirstOrDefaultAsync(m => m.IdLivro == id);

            var client = new MongoClient();
            var database = client.GetDatabase("Biblioteca");
            var collection = database.GetCollection<BsonDocument>("BibliotecaLogs");

            var document = new BsonDocument
                {
                    {"Nome Original", livro.NomeLivro },
                    {"Data", DateTime.Now },
                    {"Ação", "Delete" }
                };

            collection.InsertOne(document);

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livros.Any(e => e.IdLivro == id);
        }
    }
}
