using System;
//using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver Saldo");
                Console.WriteLine("4 - Sair do Sistema");

                Console.Write("Escolha:  ");
                int escolha = int.Parse(Console.ReadLine()); //byte para economizar memoria
                bool validar = true;
                //double saldoteste = 10000.00;

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Deposito");
                        double adicionar = 0.0;
                        while (validar)
                        {
                            Console.Write("Digite o valor a ser depositado: ");
                            //double adicionar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            adicionar = double.Parse(Console.ReadLine());
                            if (adicionar <= 0)
                            {
                                Console.WriteLine("Valor menor que zero, favor introduzir um valor positivo");
                            }
                            else
                            {
                                validar = false;
                            }
                        }
                        conta1.Depositar(adicionar);
                        //Conta.VerSaldo;
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();  
                        break;
                    case 2:
                        Console.WriteLine("Sacar");
                        double sacar = 0.0;
                        while (validar)
                        {
                            Console.Write("Digite o valor que deseja sacar: ");
                            //double sacar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            sacar = double.Parse(Console.ReadLine());
                            if (sacar > conta1.DoubleSaldo())
                            {
                                double maior = sacar - conta1.DoubleSaldo(); //dando erro trabalhar mais tarde
                                Console.WriteLine($"Valor para saque {maior} maior do que o existente em conta");
                            }
                            else
                            {
                                validar = false;
                            }
                        }
                        conta1.Sacar(sacar);
                        //Conta.VerSaldo;
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ver Saldo");
                        conta1.VerSaldo();
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
