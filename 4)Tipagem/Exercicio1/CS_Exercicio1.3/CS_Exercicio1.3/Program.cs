using System;
using System.Linq;
using System.Linq.Expressions;

namespace CS_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //os valores do vetor podem ser feitos por entrada
            string[] palavras = { "a", "ama", "ralar", "aprovado", "rodador", "reter", "aprenda", "selecionado", "mussum" };
            int[] numeros = { 1232, 121, 96235, 72627, 801108, 523925, 9, 865568 };
            

            Console.Write("Escolha 1 para encontrar palavras palindromas e 2 para encontrar numeros palindromos: ");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (escolha)
            {
                case 1:
                    //pode ser introduzida a entrada de valores em um vetor string
                    for (int i = 0; i < palavras.Length; i++)
                    {
                        palindr(palavras[i]);
                    }
                    break;
                case 2:
                    //pode ser introduzida a entrada de valores em um vetor int
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        palindr(numeros[i]);
                    }
                    break;
            }

        }

        private static void palindr(string x)
        {
            string convertido = x;

            string contrario = new string(convertido.Reverse().ToArray());

            if (convertido == contrario) Console.WriteLine($"{convertido} eh palindromo!");

            else Console.WriteLine($"{convertido} nao eh palindromo");
        }

        private static void palindr(int x)
        {
            string convertido = x.ToString();

            palindr(convertido);
        }
        
    }

}












