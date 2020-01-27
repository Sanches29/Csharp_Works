using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno uni1 = new Aluno();

            Console.WriteLine("Entre com os dados do aluno: ");
            Console.Write("Nome: ");
            uni1.Nome = Console.ReadLine();
            Console.Write("Nota 1 trimestre: ");
            uni1.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2 trimestre: ");
            uni1.nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3 trimestre: ");
            uni1.nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Nota final = " + uni1.Soma().ToString("F2"));
            string aprovacao = uni1.Verificacao();

            if(aprovacao == "Aprovado")
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + uni1.restante().ToString("F2") + " PONTOS");
            }




        }
    }
}
