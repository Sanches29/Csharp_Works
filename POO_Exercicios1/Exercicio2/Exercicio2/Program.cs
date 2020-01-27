using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario primeiro;
            Funcionario segundo;

            primeiro = new Funcionario();
            segundo = new Funcionario();

            Console.WriteLine("Digite o nome e sobrenome do primeiro funcionário: ");
            primeiro.nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o salario do primeiro funcionário: ");
            primeiro.salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o nome e sobrenome do segundo funcionário: ");
            segundo.nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite o salario do segundo funcionário: ");
            segundo.salario = double.Parse(Console.ReadLine());

            double salariomedio = (primeiro.salario + segundo.salario) / 2;

            Console.WriteLine("O salário médio é de: " + salariomedio.ToString("F2"));

        }
    }
}
