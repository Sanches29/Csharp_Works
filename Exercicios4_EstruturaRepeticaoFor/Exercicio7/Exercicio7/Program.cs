using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro positivo: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for(int i = 1; i<=num; i++)
            {
                int quadrado = i*i;
                int cubo = i*i*i;

                Console.WriteLine(i + " " + quadrado + " " + cubo);

            }
        }
    }
}
