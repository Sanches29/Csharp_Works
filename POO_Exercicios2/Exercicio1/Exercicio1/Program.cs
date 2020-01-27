using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo uni1 = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            uni1.largura = double.Parse(Console.ReadLine());

            
            Console.Write("Altura: ");
            uni1.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + uni1.Area().ToString("F2"));
            Console.WriteLine("Perimetro: " + uni1.Perimetro().ToString("F2"));
            Console.WriteLine("Diagonal: " + uni1.Diagonal().ToString("F2"));



        }
    }
}
