using System;

namespace POO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis do tipo triangulo
            Triangulo x, y;
            //instanciando variaveis triangulo (alocando na heap)
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os 3 lados do triangulo A");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os 3 lados do triangulo B");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();
            double areaP = x.Area();



            while (true) ;
        }
    }
}
