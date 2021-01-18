using System;
using CommandLine;

namespace Exercicio2
{

    class Program
    {
        public class Options
        {
            [Option('c', "criptografia", Required = true, HelpText = "Tipo de criptografia a ser utilizada")]
            public string Criptografia { get; set;}

            [Option('k', "chave", Required = false, HelpText = "Chave para ser utilizada apenas na criptografia vigenere")]
            public string Chave { get; set; } = null;

            [Option('t', "texto", Required = true, HelpText = "Texto que será trabalhado")]
            public string Texto { get; set; }

            [Option('a', "acao", Required = true, HelpText = "Ação a ser realizada")]
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
                           if(o.Acao == "Criptografar")
                           {
                               objeto.CriptografarRot13(o.Texto);
                           }
                           else if (o.Acao == "Descriptografar")
                           {
                               objeto.DescriptografarRot13(o.Texto);
                           }
                       }
                       else if (o.Criptografia == "Vigenere")
                       {
                           if (o.Acao == "Criptografar")
                           {
                               if (o.Chave == null)
                               {
                                   Console.WriteLine("Chave inexistente");
                               }
                               else
                               {
                                   objeto.CriptografarVigenere(o.Texto, o.Chave);
                               }

                           }
                           else if (o.Acao == "Descriptografar"){
                               if(o.Chave == null)
                               {
                                   Console.WriteLine("Chave inexistente");
                               }
                               else
                               {
                                   objeto.DescriptografarVigenere(o.Texto, o.Chave);
                               }
                           }
                       }

                   });


         }
    }
}
