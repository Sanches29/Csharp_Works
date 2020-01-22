using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite coordanas X e Y: ");
            Console.WriteLine(" ");
            string[] vet = Console.ReadLine().Split(" ");
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x>0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                    Console.WriteLine(" ");
                    
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                    Console.WriteLine(" ");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                    Console.WriteLine(" ");
                }
                else 
                {
                    Console.WriteLine("Quarto Quadrante");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Escreva outra coordenada:");
                vet = Console.ReadLine().Split(" ");
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }
        }
    }
}
