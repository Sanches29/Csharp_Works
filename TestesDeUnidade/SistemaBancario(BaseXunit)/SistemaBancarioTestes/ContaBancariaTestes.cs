using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SistemaBancario;
using System.Numerics;

namespace SistemaBancarioTestes
{
    public class ContaBancariaTestes
    {
        [Theory]
        [InlineData(TipoConta.Corrente, 20, 10, 10)]
        [InlineData(TipoConta.Poupanca, 3000, 1000, 3000)]
        [InlineData(TipoConta.Poupanca, 3000, 999, 2001)]
        [InlineData(TipoConta.Poupanca, 3000, 1, 2999)]
        public void DeveDebitarSaldo(TipoConta tipoConta, double saldo, double debito, double expectativa)
        {
            //Arrange
            ContaBancaria cb = new ContaBancaria("Enzo", saldo, tipoConta);

            //Act
            cb.Debitar(debito);

            //Assert
            Assert.Equal(expectativa, cb.Saldo);
        }

        [Fact]
        public void DeveLancarExcecaoCasoDebitoMaiorQue1000EmContaPoupanca()
        {
            //Arrange
            ContaBancaria cb = new ContaBancaria("Enzo", 2000, TipoConta.Poupanca);

            //Assert
            var msgExcecao = Assert.Throws<Exception>(
                //Act
                () => cb.Debitar(1000)
                ).Message;

            Assert.Equal("Conta poupança não pode debitar acima de 1000", msgExcecao);
        }
    }
}



//Eu gosto\r\nde ovo 
//Eu 
//abcdefgh abcdefgh