using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoJsonPerguntas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("essa eh uma linha /n");
            Console.WriteLine("Essa eh outra linha");
            string json = File.ReadAllText(@"PathJson");

            List<Perguntas> perguntas = JsonConvert.DeserializeObject<List<Perguntas>>(json);

            Console.WriteLine(perguntas[1].TituloPergunta);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(perguntas[1].Alternativas[i]);
            }
            Console.WriteLine(perguntas[1].Resposta);
            Console.ReadLine();

        }
    }
}
