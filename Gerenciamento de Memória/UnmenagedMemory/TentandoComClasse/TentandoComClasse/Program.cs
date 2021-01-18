using System;
using System.Collections.Generic;

namespace TentandoComClasse
{
    class Program
    {
        static List<MemoryLeak> ml;
        static void Main(string[] args)
        {
           // MemoryLeak ml = new MemoryLeak();

            while (true)
            {
                ml = Metodo();
                Console.ReadKey();
            }
        }

        static List<MemoryLeak> Metodo()
        {
            List<MemoryLeak> lista = new List<MemoryLeak>();
            for (long i = 0; i <= 50000; i++)
            {
                lista.Add(new MemoryLeak());
            }
            return lista;
        }

    }
}
