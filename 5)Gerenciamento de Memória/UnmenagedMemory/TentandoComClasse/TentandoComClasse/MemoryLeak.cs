using System;
using System.Collections.Generic;
using System.Text;

namespace TentandoComClasse
{
    class MemoryLeak
    {
        public List<long> lst = new List<long>();

        public MemoryLeak()
        {
            for(long i = 0; i <= 5000; i++)
            {
                lst.Add(i);
            }
        }
        
        /*public void Adicionar(List<long> lst2)
        {
            lst.AddRange(lst2);
            Console.WriteLine("dnv");
        }*/

    }
}
