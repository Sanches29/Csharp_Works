using OfficeOpenXml.DataValidation.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using CpfLibrary;

namespace Exercicio1
{
    class Pessoa
    {

        public string nome;
        public DateTime nascimento;
        public string CPF;
        public int idade;
        public bool IsValid;

        public void CalcularIdade()
        {
            DateTime atual = DateTime.Now;
            if (nascimento.Month <= atual.Month)
            {
                if (nascimento.Day <= atual.Day)
                {
                    idade = atual.Year - nascimento.Year;
                }
                else
                {
                    idade = (atual.Year - nascimento.Year) - 1;
                }
            }
            else
            {
                idade = (atual.Year - nascimento.Year) - 1;
            }
        }



        public void ValidarCPF()
        {
            IsValid = Cpf.Check(CPF);

        }
    }
}
