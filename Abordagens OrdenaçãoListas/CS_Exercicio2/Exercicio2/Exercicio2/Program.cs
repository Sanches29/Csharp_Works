using System;

namespace CS_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, o programa a seguir lerá de um arquivo txt o valor d a possição 1952");
            Console.WriteLine("e logo em seguida o multiplicará por 5378 e o resultado sera impresso.");
            Console.WriteLine();

            string[] lines = System.IO.File.ReadAllLines(@"PathDoArquivoTxt");
            int posicao = int.Parse(lines[1952]);
            Console.WriteLine($"A posição 1953 equivale ao valor {posicao}");
            Console.WriteLine();
            Console.WriteLine($"O valor multiplicado é {posicao * 5378} ");
        }
    }
}
