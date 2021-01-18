using System;
using System.Collections;
using System.Collections.Generic;

namespace Estudo_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(2);
            a.Add(3);

            int qualquer = (int)a[0];
            Console.WriteLine(a[0]);

            List<int> b = new List<int>();
            b.Add(1);
            b.Add(2);
            b.Add(3);

            int qualquer2 = b[0];

        }
    }
}
