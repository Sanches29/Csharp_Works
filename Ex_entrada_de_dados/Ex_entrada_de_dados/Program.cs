using System;

namespace Ex_entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome completo:");
            string nome_completo = Console.ReadLine();

            Console.WriteLine("Quantos quartos sua casa possui?");
            int num_quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimo_nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(nome_completo);
            Console.WriteLine(num_quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));

        }
    }
}
