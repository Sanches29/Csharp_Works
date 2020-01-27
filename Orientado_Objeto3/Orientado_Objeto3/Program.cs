using System;

namespace Orientado_Objetos3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Produto X;

             X = new Produto();
             */

            Produto X = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            X.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            X.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + X);
            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            X.AdicionarProdutos(qte);
            Console.WriteLine("Dados do Produto: " + X);
            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            X.RemoverProdutos(qte);
            Console.WriteLine("Dados do Produto: " + X);





        }
    }
}
