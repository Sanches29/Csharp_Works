using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Especifique o combustivel (1 a 4) abastecido seguindo a base:");
            Console.WriteLine(" 1.Alcool 2.Gasolina 3.Diesel 4.Fim");
            int selecao = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while(selecao != 4)
            {
                if(selecao == 1)
                {
                    alcool++;
                    Console.WriteLine("Contabilizado!");
                    Console.WriteLine(" ");
                }
                else if (selecao == 2)
                {
                    gasolina++;
                    Console.WriteLine("Contabilizado!");
                    Console.WriteLine(" ");
                }
                else if (selecao == 3)
                {
                    diesel++;
                    Console.WriteLine("Contabilizado!");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Entrada invalida.");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Digite o próximo código: ");
                selecao = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
