using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite uma coordenada da seguinte forma: X(espaço)Y");
                Console.WriteLine(" ");
                string[] vet = Console.ReadLine().Split(" ");

                double x = double.Parse(vet[0]);
                double y = double.Parse(vet[1]);

                if (x > 0 && y > 0) Console.WriteLine("Primeiro Quadrante");
                else if (x < 0 && y > 0) Console.WriteLine("Segundo Quadrante");
                else if (x < 0 && y < 0) Console.WriteLine("Terceiro Quadrante");
                else if (x > 0 && y < 0) Console.WriteLine("Quarto Quadrante");
                else if (x == 0) Console.WriteLine("Eixo Y");
                else Console.WriteLine("Eixo X");

            }
        }
    }
}
