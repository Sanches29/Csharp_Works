using System;
using Xunit;
using BibliotecaEntity;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using Exercicio1.Models;
using BibliotecaEntity.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaEntityIntegrationTests
{
    public class LivroControllerTest
    {
        [Fact]
        public void LivroController_Assert_DetailsAsync()
        {

            var ContextoBancoBiblioteca = new Context();
            var PrimeiroLivro = ContextoBancoBiblioteca.Livros.Include(c => c.Categoria).ToList<Livro>().First();

            var LivroController = new LivrosController(ContextoBancoBiblioteca);
            var livroDetalhes = (ViewResult)LivroController.Details(PrimeiroLivro.IdLivro).Result;
            

            Assert.Equal(PrimeiroLivro, livroDetalhes.Model);
           
        }
    }
}
