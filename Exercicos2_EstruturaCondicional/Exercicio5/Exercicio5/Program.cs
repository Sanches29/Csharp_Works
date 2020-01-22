using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código do produto de 1 a 5 e logo em seguida a quantidade deste");
            string[] vet = Console.ReadLine().Split(" ");
            Console.WriteLine(" ");

            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double valor = 0.0;

            if (codigo == 1) valor = quantidade * 4.00;
            else if (codigo == 2) valor = quantidade * 4.00;
            else if (codigo == 2) valor = quantidade * 4.50;
            else if (codigo == 3) valor = quantidade * 5.00;
            else if (codigo == 4) valor = quantidade * 2.00;
            else if (codigo == 5) valor = quantidade * 1.50;
            else Console.WriteLine("produto inexistente");

            Console.WriteLine("Total: R$ " + valor.ToString("F2"));

        }
    }
}
