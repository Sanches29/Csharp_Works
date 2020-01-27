using System;

namespace Orientado_Objetos2
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo primeiro;
            Triangulo segundo;

            primeiro = new Triangulo();
            segundo = new Triangulo();

            
            Console.WriteLine("Digite as medidas do primeiro triangulo: ");
            primeiro.A = double.Parse(Console.ReadLine());
            primeiro.B = double.Parse(Console.ReadLine());
            primeiro.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as medidas do segundo triangulo: ");
            segundo.A = double.Parse(Console.ReadLine());
            segundo.B = double.Parse(Console.ReadLine());
            segundo.C = double.Parse(Console.ReadLine());

            double AreaPrimeiro = primeiro.Calculo_area();
            double AreaSegundo = segundo.Calculo_area();

            Console.WriteLine("Area do Primeiro: " + AreaPrimeiro.ToString("F4"));
            Console.WriteLine("Area do Segundo: " + AreaSegundo.ToString("F4"));

            if(AreaPrimeiro > AreaSegundo)
            {
                Console.WriteLine("Area maior: Primeiro");
            }
            else
            {
                Console.WriteLine("Area maior: Segundo");
            }




        }
    }
}
