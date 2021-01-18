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
            Console.WriteLine(entrada);


            Console.Write("Insira a chave de criptografia:  ");
            entrada = Console.ReadLine();
            char[] entrada_char2 = entrada.ToCharArray();

            entrada_char2 = Converter(entrada_char, entrada_char2);
            Console.WriteLine(entrada_char2);

            char[] criptografado = Criptografar(entrada_char, entrada_char2);

            //Console.WriteLine(Criptografar(entrada_char, entrada_char2));
            Console.WriteLine(criptografado);

            char[] descriptografado = Descriptografar(criptografado, entrada_char2);

            Console.WriteLine(descriptografado);



        }

        static char[] Converter(char[] modelo, char[] chave)
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

        static char[] Criptografar(char[] modelo, char[] chave_convertida)
        {
            char[] criptografado = new char[modelo.Length];
            int resultado;

            for(int i = 0; i<modelo.Length; i++)
            {
                if (modelo[i] == 32) resultado = 32;
                else
                {
                    resultado = ((modelo[i] + chave_convertida[i]) % 26) + 65;
                }
                criptografado[i] = (char)resultado;
            }
            //Console.WriteLine(criptografado);
            return criptografado;
        }

        static char[] Descriptografar (char[] descriptografar, char[] chave_convertida)
        {
            char[] descriptografado = new char[descriptografar.Length];
            int resultado;

            for(int i = 0; i<descriptografar.Length; i++)
            {
                if (descriptografar[i] == 32) resultado = 32;
                else
                {
                    resultado = ((descriptografar[i] - chave_convertida[i] + 26) % 26) +65;
                }
                descriptografado[i] = (char)resultado; //conversao implicita
            }
            return descriptografado;
        }
    }
}
