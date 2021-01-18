using System;

namespace Cifra_de_Vigenere
{
    class Program
    {
        static void Main(string[] args)
        {
           // int z = 0;
            

            Console.Write("Insira o texto para ser criptografado:  ");
            string entrada = Console.ReadLine();
            char[] entrada_char = entrada.ToCharArray();

            //char[] convertido = new char[entrada_char.Length];

            Console.Write("Insira a chave de criptografia:  ");
            entrada = Console.ReadLine();
            char[] entrada_char2 = entrada.ToCharArray();

            entrada_char2 = Converter(entrada_char, entrada_char2);
            Console.WriteLine(entrada_char2);
            
            //Console.WriteLine(entrada_char2.Length);   moon = 4

            /*for (int i = 0; i < entrada_char.Length; i++)
            {

                if (z > entrada_char2.Length -1) z = 0;
                
                    convertido[i] = entrada_char2[z];
                    z++;
            
            }
            Console.WriteLine(convertido);*/

        }

        static char[] Converter(char[] modelo , char[] chave )
        {
            int z = 0;
            char[] convertido = new char[modelo.Length];

            for (int i = 0; i < modelo.Length; i++)
            {

                if (z > chave.Length - 1) z = 0;

                convertido[i] = chave[z];
                z++;

            }
            return convertido;
        }
    }
}
