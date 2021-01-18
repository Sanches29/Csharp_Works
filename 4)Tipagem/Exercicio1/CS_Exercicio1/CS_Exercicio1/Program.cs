using System;
using System.Linq;

namespace CS_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int[] numeros = { 1232, 121, 96235, 72627, 801108, 523925, 9, 865568 };

            for (int i = 0; i < numeros.Length; i++)
            {
                palindr(numeros[i]);
            }
            
        }

        private static void palindr (int x)
        {
            string convertido = x.ToString();

            string contrario = new string(convertido.Reverse().ToArray());

            if (convertido == contrario) Console.WriteLine($"{convertido} eh palindromo!");

            else Console.WriteLine($"{convertido} nao eh palindromo");
        } 
    }
}
