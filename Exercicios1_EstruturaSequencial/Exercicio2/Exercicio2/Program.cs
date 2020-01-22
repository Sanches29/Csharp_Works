using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double area;

            Console.WriteLine("Digite o raio do circulo:");
            raio = double.Parse(Console.ReadLine());

            area = 3.14159 * (Math.Pow(raio, 2));

            Console.WriteLine("A area do circulo é: " + area.ToString("F4"));

        }
    }
}
