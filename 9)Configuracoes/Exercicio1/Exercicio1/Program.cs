using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            int escolha;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("*****JOGO DA FORCA*****");


                Console.WriteLine(@"Escolha uma das opções a seguir: 
1 - Jogar
2- Customizar aplicação
3- Sair");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1://jogar
                        Jogo();
                        break;
                    case 2://config
                        Config();
                        break;
                    case 3://sair
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Seleção não existente, pressiona uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }


        }

        static void Jogo()
        {
            Console.WriteLine("Fala jovi vamo joga");
            int erros = 0;
            string palavra = "Celular";
            palavra = palavra.ToUpper();
            char[] palavraArray = palavra.ToCharArray();
            int acertos = 0;


            StringBuilder builder = new StringBuilder();
            for (int i = 0; i <= palavraArray.Length - 1; i++)
            {
                builder.Append(" _");

            }

            string stringpronta = builder.ToString();
            char[] palavrasPreencher = stringpronta.ToCharArray();

            List<char> letrasErradasAlpha = new List<char>();
            letrasErradasAlpha.Add((char)32);
            StringBuilder letrasErradas = new StringBuilder();

            do
            {
                Console.Clear();
                Console.WriteLine("*****JOGO DA FORCA*****");
                foreach (char c in palavrasPreencher)
                {
                    Console.Write(c);
                }
                Console.WriteLine("Erros: " + erros + "/6");
                Console.Write("Letras erradas: ");
                for (int i = 0; i < letrasErradasAlpha.Count; i++)
                {
                    Console.Write(letrasErradasAlpha[i]);
                }
                Console.WriteLine();

                Console.Write("Digite uma letra: ");
                char letra = Char.ToUpper(char.Parse(Console.ReadLine()));
                bool houveSubstituicao = false;
                for (int i = 0; i <= palavraArray.Length - 1; i++)
                {

                    if (letra == palavraArray[i])
                    {
                        int iProx = i++;
                        int posicao = i + iProx;
                        if (letra != palavrasPreencher[posicao])
                        {
                            palavrasPreencher[posicao] = letra;
                            acertos++;
                        }
                        houveSubstituicao = true;
                    }
                }
                if (houveSubstituicao == false)
                {
                    letrasErradasAlpha.Add(letra);
                    erros++;
                }



            } while (erros < 6 && acertos < palavraArray.Length);

            if (acertos == palavraArray.Length)
            {
                Console.WriteLine("Parabens!!! Você ganhou!");
            }
            else
            {
                Console.WriteLine("Perdeu >=(");
            }
            Console.WriteLine("Deseja jogar novamente?");
            Console.WriteLine("1 - Sim    2 - Não");
            int escolha2 = int.Parse(Console.ReadLine());

            if (escolha2 == 1)
            {
                Jogo();
            }

        }

        static void Config()
        {
            Console.WriteLine("N me dirige a palavra n");
            Console.ReadKey();
        }
    }
}
