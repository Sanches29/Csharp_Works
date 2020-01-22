using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero para calcular todos os seus divisores: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for(int i = 1; i<=numero; i++)
            {
                if((numero % i) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
