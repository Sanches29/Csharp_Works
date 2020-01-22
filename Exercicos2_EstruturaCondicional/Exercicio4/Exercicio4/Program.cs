using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o horario de inicio e termino do jogo:");
            string[] vet = Console.ReadLine().Split(" ");
            Console.WriteLine(" ");

            int horainicio = int.Parse(vet[0]);
            int horatermino = int.Parse(vet[1]);

            int duracao = 0;

            if (horatermino > horainicio)
            {
                duracao = horatermino - horainicio;
                Console.WriteLine(duracao);
            }
            else
            {
                duracao = 24 - horainicio + horatermino; //saber o necessario para completar 1 dia + horas adicionais do dia seguinte.
                Console.WriteLine(duracao);
            }
        }
    }
}
