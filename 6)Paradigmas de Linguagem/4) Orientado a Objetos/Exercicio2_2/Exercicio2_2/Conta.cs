using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2_2
{
    class Conta
    {
        private double saldo;

        public Conta()
        {
            saldo = 10000.00;
        }

        public void VerSaldo()
        {
            Console.WriteLine($"O Saldo atual é R$ {saldo}");
        }

        public void Depositar(double valor)
        {

                if (valor <= 0)
                {
                    Console.WriteLine("Valor menor que zero, favor introduzir um valor positivo");
                
                }
                else
                {
                    saldo += valor;
                    Console.WriteLine($"O Saldo atual é R$ {saldo}");
                    
                }
        }

        public void Sacar(double valor)
        {
            
                if (valor > saldo)
                {
                    double maior = valor - saldo; //dando erro trabalhar mais tarde
                    Console.WriteLine($"Valor para saque {maior} maior do que o existente em conta");
                }
                else
                {
                    saldo -= valor;
                    Console.WriteLine($"O Saldo atual é R$ {saldo}");
                }
            
            
        }

        public double DoubleSaldo()
        {
            return saldo;
        }
    }

}
