using System;
using System.Linq;


namespace CS_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 4, 7, 17, 9, 79, 95, 4, 66, 36, 17, 70, 51, 24, 35, 65, 64, 60, 19, 27, 1 };
            char[] letras = {'V','Q','P','U','S','E','B','I','J','C','N','Z','X','T','F','A','K','W','L','Y'};

            Console.Write("Escolha 1 para maior numero, ou 2 para maior letra no array: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    int maior = numeros.Max();
                    Console.WriteLine(maior);
                    break;
                case 2:
                    char maiorC = letras.Max();
                    Console.WriteLine(maiorC);
                    break;
            }

        }

    }
}
