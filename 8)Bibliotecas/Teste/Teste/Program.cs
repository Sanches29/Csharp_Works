using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            //diferença de anos:::::::::::::::::::::::::::::;
            DateTime nascimento = new DateTime(2000,07,18);
            DateTime atual = DateTime.Now;
            int anos;

            if (nascimento.Month <= atual.Month)
            {
                if(nascimento.Day <= atual.Day)
                {
                    anos = atual.Year - nascimento.Year;
                }
                else
                {
                    anos = (atual.Year - nascimento.Year) - 1;
                }
            }
            else
            {
                anos = (atual.Year - nascimento.Year) - 1;
            }
            
            Console.WriteLine(nascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine(atual.ToString("dd/MM/yyyy"));
            Console.WriteLine($"A diferença de anos é {anos}");
        }
    }
}
