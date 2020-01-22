using System;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();
            string[] vet = s.Split(' '); //separar os dados de um vetor string através de 'espaço'
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            string t = Console.ReadLine();
            string[] vet2 = t.Split('.'); //separar os dados de um vetor string através de '.'
            string p4 = vet2[0];
            string p5 = vet2[1];
            string p6 = vet2[2];

            Console.WriteLine("Voce digitou: " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);
            Console.WriteLine(vet);//teste
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);




        }
    }
}
