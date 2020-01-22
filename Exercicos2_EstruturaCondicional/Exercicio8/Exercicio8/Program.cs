using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário: ");
            Console.WriteLine(" ");
            double salario = double.Parse(Console.ReadLine());
            double saida = 0.0;
            double resto = 0.0;

            if (salario <= 2000)
            {
                Console.WriteLine("Isento de imposto de renda");
            }
            else if (salario > 2000 && salario <= 3000)
            {
                resto = salario - 2000;
                resto *= 0.08;
                Console.WriteLine(resto);
            }
            else if (salario > 3000 && salario <= 4500)
            {
                resto = salario - 3000;
                double pagar = (1000 * 0.08) + (resto* 0.18);
                Console.WriteLine(pagar.ToString("F2"));
            }
            else
            {
                resto = salario - 4500;
                double pagar = (1000 * 0.08) + (1500 * 0.18) + (resto * 0.28);
                Console.WriteLine(pagar.ToString("F2"));
            }

        }
    }
}
