using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarPrograma = true;  
            
            while (continuarPrograma) 
            {
                int opcaoSelecionada = ExibirMenuDeEscolhasEPegarSelecao();
                switch (opcaoSelecionada)
                {
                    case 1:
                        TrabalhandoComJogo();
                        break;
                    case 2:
                        Console.WriteLine("Até mais");
                        Console.ReadKey();
                        continuarPrograma = false;
                        break;
                }
            }


        }

        static int ExibirMenuDeEscolhasEPegarSelecao()
        {
            int escolha = 0;
            Console.WriteLine("***QUIZZ***");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Jogar");
            Console.WriteLine("2. Sair");

            do
            {
                Console.Write("Digite sua escolha: ");
                escolha = int.Parse(Console.ReadLine());

            } while (escolha < 1 || escolha > 2);

            return escolha;

        }

        static void TrabalhandoComJogo()
        {
            JogoQuizz gameManager = new JogoQuizz();

            int numeroDePerguntas = gameManager.NumeroDePerguntas();
            for (int i = 0; i < numeroDePerguntas; i++)
            {
                Console.Clear();
                Console.WriteLine(gameManager.ExibirPerguntaEAlternativas(i));
                Console.Write("Insira a letra da resposta: ");
                string respostaUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine(gameManager.ValidarRespostaUsuario(respostaUsuario, i));
                Console.WriteLine("Pressione qualquer tecla para a proxima questao...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine(gameManager.ResultadoFinal());
            Console.ReadKey();
            Console.Clear();

        }
    }
}
