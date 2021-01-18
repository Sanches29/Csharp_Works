using Exercicio1_V2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercicio1
{
    class Program
    {
        static ConfiguracoesConsole config = new ConfiguracoesConsole();
        static GerenciadorDePalavras gerenciador = new GerenciadorDePalavras();

        static void Main(string[] args)
        {
            config.CarregarConfigsSalvas();
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
            int erros = 0;
            string palavra = gerenciador.palavraRandom();
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
            //StringBuilder letrasErradas = new StringBuilder();

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
            
            bool validarSelecao = false;
            int escolha = 0;
            Console.WriteLine("****CONFIGURAÇÕES****");
            Console.WriteLine("1 - Alterar cor do background");
            Console.WriteLine("2 - Alterar cor da fonte");
            Console.WriteLine("3 - Alterar caminho do arquivo de palavras");
            Console.WriteLine("4 - Sair");

            while (!validarSelecao)
            {
                Console.WriteLine("Digite a sua escolha");
                escolha = int.Parse(Console.ReadLine());

                if (escolha < 1 || escolha > 4)
                {
                    Console.WriteLine("Escolha inválida.");
                }
                else
                {
                    validarSelecao = true;
                }
            }

            switch (escolha)
            {
                case 1://BackgroundColor
                    Console.Clear();
                    Console.WriteLine("Escolha uma das cores abaixo:");
                    Console.WriteLine(@"1-Preto;
2-Branco
3-Amarelo
4-Verde
5-Vermelho
6-Azul");
                    validarSelecao = false;
                    int escolhaCor = 0;
                    while (!validarSelecao)
                    {
                        Console.WriteLine("Digite a sua escolha");
                        escolhaCor = int.Parse(Console.ReadLine());

                        if (escolhaCor < 1 || escolhaCor > 6)
                        {
                            Console.WriteLine("Escolha inválida.");
                        }
                        else
                        {
                            validarSelecao = true;
                        }
                    }
                    config.AlterarCorBackgroundAppConfig(escolhaCor);
                    Console.WriteLine("Alteração feita com sucesso! Presssione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 2://TextColor
                    Console.Clear();
                    Console.WriteLine("Escolha uma das cores abaixo:");
                    Console.WriteLine(@"1 - Preto;
2-Branco
3-Amarelo
4-Verde
5-Vermelho
6-Azul");
                    validarSelecao = false;
                    int escolhaCorText = 0;
                    while (!validarSelecao)
                    {
                        Console.WriteLine("Digite a sua escolha");
                        escolhaCorText = int.Parse(Console.ReadLine());

                        if (escolhaCorText < 1 || escolhaCorText > 6)
                        {
                            Console.WriteLine("Escolha inválida.");
                        }
                        else
                        {
                            validarSelecao = true;
                        }
                    }
                    config.AlterarCorTextAppConfig(escolhaCorText);
                    Console.WriteLine("Alteração feita com sucesso! Presssione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 3://Diretorio arquivo
                    Console.Clear();
                    Console.WriteLine("Insira abaixo o novo diretorio: Lembre-se: Não esqueça de colocar o arquivo no final!");
                    Console.Write("Novo diretorio: ");
                    string novoDiretorio = Console.ReadLine();
                    gerenciador.changeDiretorio(novoDiretorio);
                    Console.WriteLine("Diretorio alterado com sucesso!Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 4://sair
                    break;
                default:
                    break;
            }


        }
    }
}
