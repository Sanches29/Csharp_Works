using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de testes que deseja: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for(int i = 1; i <= num; i++)
            {
                Console.Write("Digite um par de numeros: ");
                string[] vet = Console.ReadLine().Split(" ");
                double a = double.Parse(vet[0]);
                double b = double.Parse(vet[1]);

                if (b != 0)
                {
                    double resultado = a / b;
                    Console.WriteLine(resultado.ToString("F1"));
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Divisão impossível");
                    Console.WriteLine(" ");
                }

            }
        }
    }
}
