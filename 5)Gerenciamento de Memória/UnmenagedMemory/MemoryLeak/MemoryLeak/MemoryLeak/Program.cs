using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace MemoryLeak
{
    class Program
    {
       List<int> _intances = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;
            while (true)
            {
                adicionar(i);
                i++;

            }

            static void adicionar(int i)
            {
                _intances.Add(i);
            }
        }
    }
}
