using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2
{
    class Criptografia
    {


        public void CriptografarRot13(string texto)
        {

            char[] entrada_split = texto.ToUpper().ToCharArray();
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

        public void DescriptografarRot13(string texto)
        {
            char[] entrada_split = texto.ToUpper().ToCharArray();
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

        public void CriptografarVigenere(string texto, string chave)
        {
            char[] entrada_char = texto.ToUpper().ToCharArray();
            char[] entrada_char2 = chave.ToUpper().ToCharArray();

            char[] chaveconvertida = Converter(entrada_char, entrada_char2);

            char[] criptografado = new char[entrada_char.Length];
            int resultado;

            for (int i = 0; i < entrada_char.Length; i++)
            {
                if (entrada_char[i] == 32) resultado = 32;
                else
                {
                    resultado = ((entrada_char[i] + chaveconvertida[i]) % 26) + 65; //Imaginar uma reta com valores. O valor do caracter original eh deslocado vezes o valor do caracter da chave. Mod 26 para garatir que o resultado sempre esteja dentro do intervalo de 26.
                }                                                              //A soma com 65 eh devido ao valor A equivaler a 65. "Pq não 64?" Pq trabalhamos com resto, e o resto do valor de A sendo ele mesmo, dará 0, portando deve casar com 65. É como se A fosse a posição [0]
                criptografado[i] = (char)resultado;
            }

            Console.WriteLine(criptografado);

        }

        public void DescriptografarVigenere(string texto, string chave)
        {
            char[] entrada_char = texto.ToUpper().ToCharArray();
            char[] entrada_char2 = chave.ToUpper().ToCharArray();

            char[] chaveconvertida = Converter(entrada_char, entrada_char2);

            char[] descriptografado = new char[entrada_char.Length];
            int resultado;

            for (int i = 0; i < entrada_char.Length; i++)
            {
                if (entrada_char[i] == 32) resultado = 32;
                else
                {
                    resultado = ((entrada_char[i] - chaveconvertida[i] + 26) % 26) + 65;
                }
                descriptografado[i] = (char)resultado;
            }
            Console.WriteLine(descriptografado);

        }

        private char[] Converter(char[] modelo, char[] chave)
        {
            int z = 0;
            char[] convertido = new char[modelo.Length];

            for (int i = 0; i < modelo.Length; i++)
            {

                if (z > chave.Length - 1) z = 0; // resetar a chave para que preencha o resto
                // quero que espaço continue sendo espaço
                if (modelo[i] == 32) convertido[i] = modelo[i];  // outro if ao inves de if else, pq quero que seja testado SEMPRE
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
