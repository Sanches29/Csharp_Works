using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (numero >= 0) Console.WriteLine("Positivo");
            else Console.WriteLine("Negativo");
        }
    }
}
