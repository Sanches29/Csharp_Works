using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha para o acesso: ");
            Console.WriteLine(" ");
            string senha = "2002";
            string tentativa;
            tentativa= Console.ReadLine();



            while (tentativa != senha)
            {
                Console.WriteLine("Senha incorreta, tente novamente: ");
                Console.WriteLine(" ");
                tentativa = Console.ReadLine();
            }

            Console.WriteLine("Senha correta, acesso permitido.");
            


        }
    }
}
