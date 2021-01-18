using System;
using Xunit;
using BibliotecaEntity;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using Exercicio1.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaEntityIntegrationTests
{
    public class EntityDetailsTest
    {
        [Fact]
        public void EntityFramework_Assert_Details_First()
        {

            var ContextoBancoBiblioteca = new Context();

            var PrimeiroLivro = ContextoBancoBiblioteca.Livros.Include(c => c.Categoria).ToList<Livro>().First();


            Assert.Equal<bool>(PrimeiroLivro.Ativo, true || false);
            Assert.NotNull(PrimeiroLivro.Autor);
            Assert.NotNull(PrimeiroLivro.Categoria);   
            Assert.IsType<int>(PrimeiroLivro.IdLivro);
            Assert.NotNull(PrimeiroLivro.NomeLivro);


        }
    }
}
