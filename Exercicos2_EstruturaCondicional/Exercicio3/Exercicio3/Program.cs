using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros inteiros A e B");
            string[] vet = Console.ReadLine().Split(" ");
            Console.WriteLine(" ");

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if (a % b == 0) Console.WriteLine("São Multiplos");
            else Console.WriteLine("Não são multiplos");
        }
    }
}
