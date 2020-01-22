using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

                Console.Write("Digite um numero entre 1 e 1000: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");

                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            
        }
    }
}
