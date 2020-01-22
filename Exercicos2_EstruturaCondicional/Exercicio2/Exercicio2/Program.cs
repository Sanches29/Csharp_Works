using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (numero % 2 == 0) Console.WriteLine("PAR");
            else Console.WriteLine("IMPAR");
        }
    }
}
