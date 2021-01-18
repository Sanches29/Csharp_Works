using System;
using CommandLine;

namespace Exercicio2
{

    class Program
    {
        public class Options
        {
            [Option('c', "Criptografia", Required = true, HelpText = "Tipo de criptografia a ser utilizada")]
            public string Criptografia { get; set; }

            [Option('k', "Chave", Required = false, HelpText = "Chave para ser utilizada apenas na criptografia vigenere")]
            public string Chave { get; set; } = null;

            [Option('t', "Texto", Required = true, HelpText = "Texto que será trabalhado")]
            public string Texto { get; set; }

            [Option('a', "Acao", Required = true, HelpText = "Ação a ser realizada")]
            public string Acao { get; set; }

        }

        static void Main(string[] args)
        {
            Criptografia objeto = new Criptografia();

            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>

                   {
                       if (o.Criptografia == "ROT13")
                       {
                           if (o.Acao == "Criptografar")
                           {
                               Console.WriteLine(objeto.CriptografarRot13(o.Texto));
                           }
                           else if (o.Acao == "Descriptografar")
                           {
                               Console.WriteLine(objeto.DescriptografarRot13(o.Texto));
                           }
                       }
                       else if (o.Criptografia == "Vigenere")
                       {
                           if (o.Acao == "Criptografar")
                           {
                               if (o.Chave == null)
                               {
                                   Console.WriteLine("ERRO: Chave inexistente. Consulte Help para mais informações.");
                               }
                               else
                               {
                                   Console.WriteLine(objeto.CriptografarVigenere(o.Texto, o.Chave));
                               }

                           }
                           else if (o.Acao == "Descriptografar")
                           {
                               if (o.Chave == null)
                               {
                                   Console.WriteLine("ERRO: Chave inexistente. Consulte Help para mais informações.");
                               }
                               else
                               {
                                   Console.WriteLine(objeto.DescriptografarVigenere(o.Texto, o.Chave));
                               }
                           }
                       }
                       
                   });


        }
    }
}
