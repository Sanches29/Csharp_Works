using System;

namespace Orientado_Objetos1
{
    class Program
    {
        static void Main(string[] args)
        {

            

            //classe : é a definição de um tipo. No caso, um triangulo de lados A,B,C (atributos)
            //objetos: são instancias da classe (casos particulares da minha classe) (caracteristicas diferentes associadas a A, B, C)
            //ex: objeto x com A(3.0) B(4.0) e C(5.0) -------- objeto y com A(7.5) B(4.5) C(4.02)


            //cirando ponteiro (memoria stack(estatica))
            Triangulo x, y;
            //alocando um bloco (3 espaços ABC) na memoria Heap(dinamica)
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Insira a medida dos lados do triângulo x: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a medida dos lados do triângulo y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2;

            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;

            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }



        }
    }
}
