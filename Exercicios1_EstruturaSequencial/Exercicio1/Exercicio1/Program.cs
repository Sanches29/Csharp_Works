using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int resultado;

            Console.WriteLine("Digite o primeiro termo:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo termo:");
            b = int.Parse(Console.ReadLine());

            resultado = a + b;

            Console.WriteLine("O resultdo é:" + resultado);



        }
    }
}
