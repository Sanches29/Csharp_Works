using System;
using OfficeOpenXml;
using System.IO;
using CpfLibrary;
using System.Globalization;
using System.Collections.Generic;
using System.Dynamic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cultureInfo = new CultureInfo("pt-BR");

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            FileInfo arquivo = new FileInfo(@"PathArquivoExcel");

            using (ExcelPackage objetoArquivo = new ExcelPackage(arquivo))
            {
                ExcelWorksheet arquivoWorksheet = objetoArquivo.Workbook.Worksheets["Sheet1"];

                List<Pessoa> Pessoas = new List<Pessoa>();
                List<Pessoa> PessoasCpfInvalido = new List<Pessoa>();

               for (int i = 3; i <= 17; i++)
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.nome = arquivoWorksheet.Cells[i,2].Value.ToString();
                    pessoa.nascimento = DateTime.Parse(arquivoWorksheet.Cells[i, 3].Value.ToString());
                    pessoa.CPF = arquivoWorksheet.Cells[i, 4].Value.ToString();
                    pessoa.CalcularIdade();
                    pessoa.ValidarCPF();
                    Pessoas.Add(pessoa);
                }

                Console.WriteLine("Todos os registros:");

               for (int i = 0; i < Pessoas.Count; i++)
                {
                    if (Pessoas[i].IsValid == false)
                    {
                        PessoasCpfInvalido.Add(Pessoas[i]);
                    }
                    Console.WriteLine($"Nome: {Pessoas[i].nome} + Nascimento: {Pessoas[i].nascimento.Date.ToShortDateString()} + Idade: {Pessoas[i].idade} + CPF: {Pessoas[i].CPF} + CPF Valido: {Pessoas[i].IsValid}");
                }

                Console.WriteLine();
                Console.WriteLine("Registros com CPF Invalido: ");
                for(int i = 0; i<PessoasCpfInvalido.Count; i++)
                {
                    Console.WriteLine($"Nome: {PessoasCpfInvalido[i].nome} + Nascimento: {PessoasCpfInvalido[i].nascimento} + Idade: {PessoasCpfInvalido[i].idade} + CPF: {PessoasCpfInvalido[i].CPF} + CPF Valido: {PessoasCpfInvalido[i].IsValid}");
                }

               


            }


        }
    }
}
