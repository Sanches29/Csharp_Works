using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Olá, este programa lhe retornará seu salário.");
            Console.WriteLine("Primeiramente, digite seu numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Ok. Agora me diga o total de horas trabalhadas: ");
            int horastrab = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Certo. Agora me diga o valor da sua hora: ");
            double valordahora = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Calculando...");

            double salario = valordahora * horastrab;

            while(x != 200000)
            {
                x++;
            }

            Console.WriteLine("O salario do funcionário de numero " + numero + " é de: R$" + salario);



            

        }
    }
}
