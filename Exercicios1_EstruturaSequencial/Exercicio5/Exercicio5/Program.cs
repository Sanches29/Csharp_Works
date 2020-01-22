using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo da peça 1, o numero de peças, e o valor desta:");
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine(" ");
            Console.WriteLine("Digite o codigo da peça 2, o numero de peças, e o valor desta:");
            string[] vet2 = Console.ReadLine().Split(' ');

            int numpec1 = int.Parse(vet[1]);
            float valor1 = float.Parse(vet[2]);
            int numpec2 = int.Parse(vet2[1]);
            float valor2 = float.Parse(vet2[2]);

            float pagar = (numpec1 * valor1) + (numpec2 * valor2);

            Console.WriteLine(" ");
            Console.WriteLine("O valor a ser pago é: R$" + pagar);
        }
    }
}
