using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercicio1.Models
{
    public class Emprestimos
    {
        public int IdEmprestimos { get; set; }
        public Livro Livro { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Emprestado { get; set; }
        public DateTime PrevisaoDevolucao { get; set; }
        public DateTime Devolucao { get; set; }
    }
}