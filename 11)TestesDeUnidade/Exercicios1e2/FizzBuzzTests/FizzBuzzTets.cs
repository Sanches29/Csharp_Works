using System;
using Xunit;
using Exercicios1e2;

namespace FizzBuzzTests
{
    public class FizzBuzzTets
    {
        [Theory]
        [InlineData(3,"Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(7, "7")]
        public void TestandoFizzBuzzFuncionamento(int numero, string resultadoEsperado)
        {
            
            FizzBuzz fizzBuzz = new FizzBuzz();
            string resultado = fizzBuzz.ResultadoFizzBuzzComNumeroEscolhido(numero);
               
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}
