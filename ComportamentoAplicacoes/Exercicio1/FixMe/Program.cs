using System;
using System.Threading;

namespace FixMe
{
    class Program
    {
        private static void pausar()
        {
            Console.WriteLine("\n*** Pressione alguma tecla para continuar ***\n");
            Console.ReadKey();
        }
        

        private static void escrever15NumerosAleatoriosNoConsole()
        {
            Console.Clear();
            Console.WriteLine("Números aleatórios");
            Console.WriteLine("-------------------------------------------\n");
            
            for (int i = 0; i < 15; i++)
            {
                escreverNumeroAleatorioNoConsole();
                Thread.Sleep(2);
            }
            

            pausar();
        }

        private static void somarDoisNumeros()
        {
            Console.Clear();
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("-------------------------------------------\n");
            int resutado = 0;
            int numero1 = 13;
            int numero2 = 17;
            resutado = somar(numero1, numero2, resutado);
            Console.WriteLine($"A soma entre {numero1} e {numero2} é {resutado}");
            pausar();
        }

        private static void escreverNumeroAleatorioNoConsole()
        {
            int sementeInicial = DateTime.Now.Millisecond;
            Random random = new Random(sementeInicial);
            int numeroAleatorio = random.Next();
            Console.WriteLine($"  Número aleatório gerado: {numeroAleatorio}");
            
        }

        private static int somar(int numero1, int numero2, int resultado)
        {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            resultado = numero1 + numero2;
            return resultado;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }

        private static byte mostrarMenuEObterOpcao()
        {
            byte opcaoEscolhida = byte.MaxValue;
            bool opcaoValida;

            Console.WriteLine("\n\nMENU");
            Console.WriteLine("  0 - Sair");
            Console.WriteLine("  1 - Números aleatórios");
            Console.WriteLine("  2 - Soma de dois números");

            do
            {
                
                Console.Write("\nEscolha uma opção: ");
                string opcaoChar = Console.ReadKey().KeyChar.ToString();
                opcaoValida = byte.TryParse(opcaoChar, out opcaoEscolhida);

                opcaoValida = opcaoValida && (opcaoEscolhida >= 0 && opcaoEscolhida <= 2);
                if (!opcaoValida)
                {
                    opcaoEscolhida = byte.MaxValue;
                    Console.WriteLine("\nOpção inválida!");
                    pausar();
                }
                
            } while (opcaoEscolhida >  2);

            return opcaoEscolhida;
        }

        static void Main()
        {
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nBem vindo ao Fix-me!\n\nEsse app precisa ser consertado para funcionar corretamente.");
                byte opcaoEscolhida = mostrarMenuEObterOpcao();

                if (opcaoEscolhida == 1)
                {
                    escrever15NumerosAleatoriosNoConsole();
                }
                else if (opcaoEscolhida == 2)
                {
                    somarDoisNumeros();
                }
                else if (opcaoEscolhida == 0)
                {
                    Console.WriteLine("\n\nAté logo!");
                    break;
                }
            }

            pausar();
            
        }        
    }
}
