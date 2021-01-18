using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exercicio1.Models;

namespace BibliotecaEntityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimosController : ControllerBase
    {
        private readonly Context _context;

        public EmprestimosController(Context context)
        {
            _context = context;
        }

        // GET: api/Emprestimos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emprestimos>>> GetEmprestimos()
        {
            return await _context.Emprestimos.Include(c => c.Cliente).Include(c => c.Livro).ThenInclude(c => c.Categoria).ToListAsync();
        }
    }
}

