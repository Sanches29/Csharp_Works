using System;
using CommandLine;

namespace QuickStart
{
    class Program
    {
        public class Options
        {
            [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
            public bool Verbose { get; set; }

            [Option('k', "chave", Required = false, HelpText = "Chave para Vigenere")]
            public string Chave { get; set; }

            [Option('c', "criptografia", Required = true, HelpText = "Tipo desejado de criptografia")]
            public string Criptografia { get; set; }

        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>

                   {
                       if (o.Criptografia)
                       {
                           Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                           Console.WriteLine("Quick Start Example! App is in Verbose mode!");
                       }
                       else
                       {
                           Console.WriteLine($"Current Arguments: -v {o.Verbose}");
                           Console.WriteLine("Quick Start Example!");
                       }
                       
                   }

                   );
        }
    }
}