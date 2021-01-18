using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Exercicio2
{
    
    class Conta
    {
        private double Saldo { get; set; }  = 10000.00;

        public void VerSaldo()
        {
            Console.WriteLine($"O Saldo atual é R$ {Saldo}");
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"O Saldo atual é R$ {Saldo}");
            
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
            Console.WriteLine($"O Saldo atual é R$ {Saldo}");
        }

        public double DoubleSaldo()
        {
            return Saldo;
        }
    }
}
