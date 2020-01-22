using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Digite um numero para calcular seu fatorial: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                int resultado = 1;

                for (int i = 1; i <= num; i++)
                {
                    resultado *= i;
                }
                Console.WriteLine(resultado);
            
        }
    }
}
