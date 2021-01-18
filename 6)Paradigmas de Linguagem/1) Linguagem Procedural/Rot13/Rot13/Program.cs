using System;

namespace Rot13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o texto e este será criptografado ou descriptografado em ROT13:");
            string entrada = Console.ReadLine();
            char[] entrada_split = entrada.ToUpper().ToCharArray();
            foreach (char c in entrada_split)
            {
                if (c == 32) Console.Write(c); //32 remete a SPACE, deixemos como está.
                else
                {
                    int rotacao13 = c + 13;  //Metodo ROT13 (Soma 13 ao valor numerico do char)
                    if (rotacao13 > 90) //Z equivale a 90 (Nosso limite de valor)
                    {
                        rotacao13 = (rotacao13 - 90) + 64; //A equivale a 65 (A nossa base de contagem)
                    }
                    char rotacao13char = (char)rotacao13;
                    Console.Write(rotacao13char);
                }

            }

        }
    }
}
