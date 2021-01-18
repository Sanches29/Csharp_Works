using System;

namespace Exercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver Saldo");
                Console.WriteLine("4 - Sair do Sistema");

                Console.Write("Escolha:  ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Deposito");
                        Console.Write("Digite o valor a ser depositado: ");
                        double adicionar = double.Parse(Console.ReadLine());
                        conta.Depositar(adicionar);
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Sacar");
                        Console.Write("Digite o valor que deseja sacar: ");
                        double sacar = double.Parse(Console.ReadLine());
                        conta.Sacar(sacar);
                        //Conta.VerSaldo;
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ver Saldo");
                        conta.VerSaldo();
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Sair do Sistema");
                        controle = false;
                        break;
                    default:
                        Console.WriteLine("Escolha inexistente");
                        break;
                }
            }
        }
    }
}
