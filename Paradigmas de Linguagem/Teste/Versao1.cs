using System;

namespace Cifra_de_Vigenere
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o texto para ser criptografado:  ");
            string entrada = Console.ReadLine();
            char[] entrada_char = entrada.ToCharArray();


            Console.Write("Insira a chave de criptografia:  ");
            entrada = Console.ReadLine();
            char[] entrada_char2 = entrada.ToCharArray();

            entrada_char2 = Converter(entrada_char, entrada_char2);
            Console.WriteLine(entrada_char2);
            

        }

        static char[] Converter(char[] modelo , char[] chave )
        {
            int z = 0;
            char[] convertido = new char[modelo.Length];

            for (int i = 0; i < modelo.Length; i++)
            {

                if (z > chave.Length - 1) z = 0; // resetar a chave para que preencha o resto
                // quero que espaço continue sendo espaço
                if (modelo[i] == 32) convertido[i] = modelo[i];         // outro if ao inves de if else, pq quero que seja testado SEMPRE
                else
                {
                    
                    convertido[i] = chave[z];
                    z++;
                }
            }
            return convertido;
        }
    }
}
