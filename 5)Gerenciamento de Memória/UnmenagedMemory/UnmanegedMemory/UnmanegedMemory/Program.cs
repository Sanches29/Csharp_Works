using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UnmanegedMemory
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool loop = true;
            Console.WriteLine("Hello World!");
            while (loop)
            {
                List<long> x = CriarLista();
                Console.WriteLine("Nova lista criada, digite 1 para continuar ou 0 para sair");
               // int escolha = int.Parse(Console.ReadLine());
                //if (escolha == 0) loop = false; 
            }
            Console.WriteLine("Terminado");
        }
        static List<long> CriarLista()
        {
            List<long> lst = new List<long> ();
            for (long i = 0; i <= 10000000000000; i++)
            {
                lst.Add(i);
            }

            return lst;
        }
    }
}
