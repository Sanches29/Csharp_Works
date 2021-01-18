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
using DnsClient.Internal;
using Microsoft.Extensions.Logging;

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
            Serilog.Log.Verbose("Index acessada");
            Serilog.Log.Information("Lista de livros incluindo categoria recuparada");
            Serilog.Log.Verbose("Saindo Index");
            return View(await _context.Livros.Include(c => c.Categoria).ToListAsync());
        }

        // GET: Livroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Serilog.Log.Verbose("Details Acessada");
            if (id == null)
            {
                Serilog.Log.Warning("Id livro nulo");
                return NotFound();
            }

            var livro = await _context.Livros.Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            Serilog.Log.Information("Informções do livro associado ao Id recuparadas incluindo categoria");
            Serilog.Log.Verbose("{@MeuItem}", livro);
            if (livro == null)
            {
                Serilog.Log.Warning("Valor de livro nulo");
                return NotFound();
            }

            Serilog.Log.Verbose("Saindo Details");
            return View(livro);
        }

        // GET: Livroes/Create
        public IActionResult Create()
        {
            Serilog.Log.Verbose("Create GET acessado");
            ViewBag.Categoria = new SelectList(_context.Categorias.ToList(), "IdCategoria", "NomeCategoria");
            Serilog.Log.Information("Select List com lista de categorias adicionado a ViewBag");
            Serilog.Log.Verbose("Saindo Create GET");
            return View();
        }

        // POST: Livroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLivro,NomeLivro,Categoria,Autor,Ativo")] Livro livro)
        {
            Serilog.Log.Verbose("Create POST acessado");
            if (ModelState.IsValid)
            {
                Categoria CategoriaSelecionada = _context.Categorias.First(x => x.IdCategoria.Equals(livro.Categoria.IdCategoria));
                livro.Categoria = CategoriaSelecionada;
                Serilog.Log.Information("Categoria recuperada pelo Id e associada ao objeto livro");

                var client = new MongoClient();
                Serilog.Log.Information("Iniciando Client MongoDB");
                var database = client.GetDatabase("Biblioteca");
                Serilog.Log.Information("Acessando databse Biblioteca");
                var collection = database.GetCollection<BsonDocument>("BibliotecaLogs");
                Serilog.Log.Information("Acessando collection BibliotecaLogs");

                var document = new BsonDocument
                {
                    {"Nome Alterado", livro.NomeLivro },
                    {"Autor Alterado", livro.Autor },
                    {"Categoria Alterada", livro.Categoria.NomeCategoria},
                    {"Ativo Alterado", livro.Ativo },
                    {"Data", DateTime.Now },
                    {"Ação", "Insert" }
                };
                Serilog.Log.Information("BsonDocument criado e populado com informações de criação");

                collection.InsertOne(document);
                Serilog.Log.Information("BsonDocument inserido na collection");

                Serilog.Log.Verbose("{@MeuItem}", livro);

                _context.Add(livro);
                await _context.SaveChangesAsync();
                Serilog.Log.Verbose("Saindo Create POST");
                return RedirectToAction(nameof(Index));
            }
            Serilog.Log.Warning("Model State não válido");
            return View(livro);
        }

        // GET: Livroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Serilog.Log.Verbose("Edit GET acessado");
            if (id == null)
            {
                Serilog.Log.Warning("Id livro nulo");
                return NotFound();
            }

            var livro = await _context.Livros.FindAsync(id);
            ViewBag.CategoriaEdit = new SelectList(_context.Categorias.ToList(), "IdCategoria", "NomeCategoria");
            Serilog.Log.Information("Select List com lista de categorias adicionado a ViewBag");

            Serilog.Log.Verbose("{@Meuitem}", livro);
            if (livro == null)
            {
                Serilog.Log.Warning("Valor de livro nulo");
                return NotFound();
            }
            Serilog.Log.Verbose("Saindo Edit GET");
            return View(livro);
        }

        // POST: Livroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLivro,NomeLivro,Autor,Categoria,Ativo")] Livro livro)
        {
            Serilog.Log.Verbose("Edit POST acessada");
            if (id != livro.IdLivro)
            {
                Serilog.Log.Warning("Id selecionado difere do Id do Livro para edição");
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
                    Serilog.Log.Information("Objeto livro não alterado recupado");

                    livro.Categoria = _context.Categorias.First(x => x.IdCategoria.Equals(livro.Categoria.IdCategoria));
                    Serilog.Log.Information("Categoria referente ao Id escolhido associado ao objeto livro");

                    var client = new MongoClient();
                    Serilog.Log.Information("Iniciando Client MongoDB");
                    var database = client.GetDatabase("Biblioteca");
                    Serilog.Log.Information("Acessando Database Biblioteca");
                    var collection = database.GetCollection<BsonDocument>("BibliotecaLogs");
                    Serilog.Log.Information("Acessando Collection BibliotecaLogs");

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
                    Serilog.Log.Information("BsonDocument criado e populado com informações do objeto livro antes e depois da alteração");

                    collection.InsertOne(document);
                    Serilog.Log.Information("BsonDocument adicionado na collection");
                    Serilog.Log.Verbose("{@Meuitem}", livro);

                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.IdLivro))
                    {
                        Serilog.Log.Warning("Id Livro não encontrado");
                        return NotFound();
                    }
                    else
                    {
                        Serilog.Log.Error("Excepiton erro ao atualizar Banco de dados com informações");
                        throw;
                    }
                }
                Serilog.Log.Verbose("Saindo Edit POST");
                return RedirectToAction(nameof(Index));
            }
            Serilog.Log.Warning("Model State não válido");
            return View(livro);
        }

        // GET: Livroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Serilog.Log.Verbose("Delete GET acessado");
            if (id == null)
            {
                Serilog.Log.Warning("Valor id nulo");
                return NotFound();
            }

            var livro = await _context.Livros.Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.IdLivro == id);
            Serilog.Log.Information("Livro associado ao Id recuperado incluindo categoria");

            Serilog.Log.Verbose("{@MeuItem}", livro);
            if (livro == null)
            {
                Serilog.Log.Warning("Valor de livro é nulo");
                return NotFound();
            }

            Serilog.Log.Verbose("Saindo Delete GET");
            return View(livro);
        }

        // POST: Livroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Serilog.Log.Verbose("Delete POST acessado");
            var livro = await _context.Livros.FindAsync(id);
            Serilog.Log.Information("Livro associado ao Id recuperado");
            //var livro = await _context.Livros.Include(c => c.Categoria)
            //  .FirstOrDefaultAsync(m => m.IdLivro == id);

            var client = new MongoClient();
            Serilog.Log.Information("Iniciando Client MongoDB");
            var database = client.GetDatabase("Biblioteca");
            Serilog.Log.Information("Acessando a database Biblioteca");
            var collection = database.GetCollection<BsonDocument>("BibliotecaLogs");
            Serilog.Log.Information("Acessando collection BibliotecaLogs");

            var document = new BsonDocument
                {
                    {"Nome Original", livro.NomeLivro },
                    {"Data", DateTime.Now },
                    {"Ação", "Delete" }
                };
            Serilog.Log.Information("BsonDocument criado e populado com infomações sobre o livro a ser deletado");

            collection.InsertOne(document);
            Serilog.Log.Information("BsonDocument inserido na collection");

            Serilog.Log.Verbose("{@Meuitem}", livro);

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
            Serilog.Log.Verbose("Saindo Delete POST");
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livros.Any(e => e.IdLivro == id);
        }
    }
}
