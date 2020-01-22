using System;

namespace Saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {

            char letra = 't';
            int numero = 345;
            string frase = "Ola como vai?";
            float variascasas = 12.7564f;
            double duascasas = 12.7564;
            double trescasas = 12.7564;

            Console.WriteLine(letra);
            Console.Write(numero);
            Console.WriteLine("  ");
            Console.WriteLine(frase);
            Console.WriteLine(variascasas);
            Console.WriteLine(duascasas.ToString("F2"));
            Console.WriteLine(trescasas.ToString("F3"));

            Console.WriteLine(" A letra é {0} , o numero é {1} , a frase é {2}, e", letra, numero, frase);
            Console.WriteLine("a float é {0}, com duas casas: {1:F2}, e tres casas {2:F3}", variascasas, duascasas, trescasas);

            Console.WriteLine("--------------------------------------------------------------");

            //melhor forma:
            Console.WriteLine($"{letra} e {numero} tambem, alem de {frase}");
            Console.WriteLine($"numeros sao {variascasas}, {duascasas:F2} e {trescasas:F3}");

            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine(letra + "e" + numero + "alem de" + frase);
            Console.WriteLine("numeros temos" + variascasas + "," + duascasas.ToString("F2") + "," + trescasas.ToString("F3"));

        }
    }
}
