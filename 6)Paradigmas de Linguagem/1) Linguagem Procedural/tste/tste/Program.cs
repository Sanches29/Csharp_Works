using System;

namespace tste
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = somarNumerosDeUmAte(5);
            Console.WriteLine($"A soma de 1 até 5 é {resultado}");
         }

        // Linguagem: C#
        // Função que chama a si mesma em seu corpo. Função recursiva.
       static int somarNumerosDeUmAte(int valorMaximo)
        {
            if (valorMaximo <= 0)
            { // este é o CASO BASE da função recursiva, que indica
              //quando a função termina sua recursividade.
                return 0;
            }
            int retorno = somarNumerosDeUmAte(valorMaximo - 1);
            return valorMaximo + retorno; // chamando a si
                                                                         // mesma!
        }

    }
}
