using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos casos de teste deseja? ->");
            int numcasos = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            /*Console.Write("Digite 3 valores double: ");
            string[] vet = Console.ReadLine().Split(" ");
            double num1 = double.Parse(vet[0]);
            double num2 = double.Parse(vet[1]);
            double num3 = double.Parse(vet[2]);
            */

            for(int i = 1; i <= numcasos; i++)
            {
                Console.Write("Digite 3 valores double: ");
                string[] vet = Console.ReadLine().Split(" ");
                Console.WriteLine(" ");
                double num1 = double.Parse(vet[0]);
                double num2 = double.Parse(vet[1]);
                double num3 = double.Parse(vet[2]);

                double resultado = ((num1*2) + (num2 * 3) + (num3 * 5)) / 10;
                Console.WriteLine(resultado.ToString("F1"));
            }



        }
    }
}
