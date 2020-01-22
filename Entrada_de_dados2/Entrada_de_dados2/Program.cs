using System;

namespace Entrada_de_dados2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um int");
            
            
            int n1 = int.Parse(Console.ReadLine());//ReadLine só le string, portanto teremos que fazer uma conversao de string
                                                   // para inteiro utilizando int.Parse
            Console.WriteLine("Digite um char");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um double");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma string com nome, sexo, idade e altura");
            /*string s = Console.ReadLine();
              string[] vet = s.Split(' ');
              */
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = float.Parse(vet[3]);



            Console.WriteLine("Você digitou:" + n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine("Nome:" + nome + " Sexo:" + sexo + " Idade:" + idade + " Altura:" + altura.ToString("F2"));



        }
    }
}
