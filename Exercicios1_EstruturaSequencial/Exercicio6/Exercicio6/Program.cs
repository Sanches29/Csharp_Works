using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite valores para A B e C:");
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine(" ");

            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            //Area do triângulo
            double tri = (a * c) / 2;

            //Area do circulo
            double cir = 3.14159 * Math.Pow(c, 2);

            //Area do trapezio
            double trap = ((a + b) * c) / 2;

            //Area do quadrado
            double quad = Math.Pow(b, 2);

            //area do retangulo
            double ret = a * b;

            Console.WriteLine("Triângulo: " + tri.ToString("F4"));
            Console.WriteLine("Circulo: " + cir.ToString("F4"));
            Console.WriteLine("Trapézio: " + trap.ToString("F4"));
            Console.WriteLine("Quadrado: " + quad.ToString("F4"));
            Console.WriteLine("Retângulo: " + ret.ToString("F4"));

        }
    }
}
