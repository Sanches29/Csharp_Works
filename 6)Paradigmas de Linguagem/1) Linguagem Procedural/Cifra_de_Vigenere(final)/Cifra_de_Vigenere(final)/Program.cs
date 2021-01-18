using System;

namespace Cifra_de_Vigenere
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            Console.WriteLine("Olá, este eh um programa que permite criptografar ou descriptografar uma frase utilizando o modelo da");
            Console.WriteLine("Cifra de Vigenese. Por favor, escolha 1 para Criptografar e 2 para Descriptografar:");

            do
            {
                Console.Write("Entrada: ");
                escolha = int.Parse(Console.ReadLine());
            } while ((escolha != 1) && (escolha != 2)); //while executa enquanto for true


            Console.WriteLine();

            if (escolha == 1) Console.Write("Insira o texto para ser criptografado:  ");
            else Console.Write("Insira o texto para ser descriptografado:  ");
            string entrada = Console.ReadLine();
            char[] entrada_char = entrada.ToUpper().ToCharArray(); //transforma tudo em maiusculo depois transforma em array de char


            Console.Write("Insira a chave de criptografia/descriptografia:  ");
            entrada = Console.ReadLine();
            entrada.ToUpper();
            char[] entrada_char2 = entrada.ToUpper().ToCharArray();

            entrada_char2 = Converter(entrada_char, entrada_char2);

            switch (escolha)
            {
                case 1:
                    char[] criptografado = Criptografar(entrada_char, entrada_char2);
                    Console.WriteLine();
                    Console.WriteLine("Texto para Criptografar: " + new string (entrada_char)); // .ToString eh executado automaticamente em todo WriteLine quando se concatena string, porem, ToString em char[] retorna o seu tipo, e nao seu valor.
                    Console.WriteLine("Chave escolhida: " + entrada);
                    Console.WriteLine("Texto Criptografada: " + new string (criptografado));
                    break;

                case 2:
                    char[] descriptografado = Descriptografar(entrada_char, entrada_char2);
                    Console.WriteLine();
                    Console.WriteLine("Texto para Criptografar: " + new string(entrada_char));
                    Console.WriteLine("Chave escolhida: " + entrada);
                    Console.WriteLine("Texto Criptografada: " + new string (descriptografado));
                    break;
            }


        }

        static char[] Converter(char[] modelo, char[] chave)
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

        static char[] Criptografar(char[] modelo, char[] chave_convertida)
        {
            char[] criptografado = new char[modelo.Length];
            int resultado;

            for (int i = 0; i < modelo.Length; i++)
            {
                if (modelo[i] == 32) resultado = 32;
                else
                {
                    resultado = ((modelo[i] + chave_convertida[i]) % 26) + 65; //Imaginar uma reta com valores. O valor do caracter original eh deslocado vezes o valor do caracter da chave. Mod 26 para garatir que o resultado sempre esteja dentro do intervalo de 26.
                }                                                              //A soma com 65 eh devido ao valor A equivaler a 65. "Pq não 64?" Pq trabalhamos com resto, e o resto do valor de A sendo ele mesmo, dará 0, portando deve casar com 65. É como se A fosse a posição [0]
                criptografado[i] = (char)resultado;
            }
            //Console.WriteLine(criptografado);
            return criptografado;
        }

        static char[] Descriptografar(char[] descriptografar, char[] chave_convertida)
        {
            char[] descriptografado = new char[descriptografar.Length];
            int resultado;

            for (int i = 0; i < descriptografar.Length; i++)
            {
                if (descriptografar[i] == 32) resultado = 32;
                else
                {
                    resultado = ((descriptografar[i] - chave_convertida[i] + 26) % 26) + 65; 
                }
                descriptografado[i] = (char)resultado; 
            }
            return descriptografado;
        }
    }
}
