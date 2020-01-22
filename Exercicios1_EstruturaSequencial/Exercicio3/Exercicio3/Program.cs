using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro numeros utilizando espaço para separá-los:");
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);
            int d = int.Parse(vet[3]);

            int resultado = (a * b) - (c * d);

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
