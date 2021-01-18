using System;
using System.Linq;

namespace CS_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] palavras = { "a", "ama", "ralar", "aprovado", "rodador", "reter", "aprenda", "selecionado", "mussum" };


            for (int i = 0; i < palavras.Length; i++)
            {
                palindr(palavras[i]);
            }

        }

        private static void palindr(string x)
        {
            string convertido = x;

            string contrario = new string(convertido.Reverse().ToArray());

            if (convertido == contrario) Console.WriteLine($"{convertido} eh palindromo!");

            else Console.WriteLine($"{convertido} nao eh palindromo");
        }
    }
}
