using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            long soma = 0;

            for (int i = 0; i<= 1000000; i++)
            {
                soma += i;
            }

            Console.WriteLine(soma);
        }
    }
}
