using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercicios1e2;

namespace FizzBuzzTests
{
    public class EscreverFrasesComLimiteDeLetrasPorLinhasTests
    {
        [Theory]
        [InlineData("Eu gosto de ovo", 8 ,"Eu gosto\r\nde ovo ")]
        [InlineData("Eu" , 8 , "Eu ")]
        [InlineData("abcdefgh abcdefgh", 8, "abcdefgh\r\nabcdefgh ")]

        public void TestandoFrasesComClasse(string entrada,int tamanhoDaLinha ,string expectativa)
        {
            EscreverFrasesComLimiteDeLetrasPorLinhas agent1 = new EscreverFrasesComLimiteDeLetrasPorLinhas();
            string resultado = agent1.RecebeAFraseERetornStringFormatada(entrada, tamanhoDaLinha);

            Assert.Equal(resultado, expectativa);
        }

        [Fact]

        public void TestandoPalavrasMaioresQueLimiteDaLinhaDeveGerarException()
        {
            EscreverFrasesComLimiteDeLetrasPorLinhas agent1 = new EscreverFrasesComLimiteDeLetrasPorLinhas();

            string mensagemExcecao = Assert.Throws<Exception>(
                () => agent1.RecebeAFraseERetornStringFormatada("abcdefghi", 8)
                ).Message;

            Assert.Equal("O tamanho de abcdefghi é maior do que o tamanho definido na linha", mensagemExcecao);
        }


    }
}
