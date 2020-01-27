using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario uni1 = new Funcionario();

            Console.WriteLine("Entre os dados do funcionário: ");
            Console.Write("Nome: ");
            uni1.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            uni1.Bruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            uni1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + uni1);
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            uni1.AumentarSalario(porcent);
            Console.WriteLine("Dados atualizados: " + uni1);
        }
    }
}
