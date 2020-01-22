using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores serão digitados? -> ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int dentro = 0;
            int fora = 0;
            
            for (int i = 1; i <= numero; i++)
            {
                Console.Write("Digite um valor: ");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                if(valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }

            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
