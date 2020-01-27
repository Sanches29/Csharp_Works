using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa primeira;
            Pessoa segunda;

            primeira = new Pessoa();
            segunda = new Pessoa();

            Console.WriteLine("Digite o nome e idade da primeira pessoa: ");
            string[] vet = Console.ReadLine().Split(" ");
            primeira.nome = vet[0];
            primeira.idade = int.Parse(vet[1]);

            Console.WriteLine("Digite o nome e idade da segunda pessoa: ");
            vet = Console.ReadLine().Split(" ");
            segunda.nome = vet[0];
            segunda.idade = int.Parse(vet[1]);

            if(primeira.idade > segunda.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + primeira.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + segunda.nome);
            }

        }
    }
}
