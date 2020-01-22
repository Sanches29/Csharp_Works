using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)

        {
            bool y = true;
            while (y)
            {
                Console.WriteLine("Digite um numero qualquer");
                string inicio = Console.ReadLine();
                Console.WriteLine(" ");
                if (inicio == "exit")
                {
                    y = false;
                }
                else
                {
                    int x = int.Parse(inicio);


                    if (x >= 0.00 && x < 25.00)
                    {
                        Console.WriteLine("Intervalo 0-24");
                    }
                    else if (x >= 25.00 && x < 50.00)
                    {
                        Console.WriteLine("Intervalo 25 - 49");
                    }
                    else if (x >= 50.00 && x < 75.00)
                    {
                        Console.WriteLine("Intervalo 50 - 74");
                    }
                    else if (x >= 75.00 && x <= 100)
                    {
                        Console.WriteLine("Intervalo 75 - 100");
                    }
                    else
                    {
                        Console.WriteLine("O numero não se encontra em nenhum intervalo");
                    }
                }
            }
        }
    }
}
