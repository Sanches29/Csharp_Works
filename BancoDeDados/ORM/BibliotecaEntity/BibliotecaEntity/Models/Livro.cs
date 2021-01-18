using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercicio1.Models
{
    public class Livro
    {
        [Key]
        public int IdLivro { get; set; }
        public string NomeLivro { get; set; }
        public Categoria Categoria { get; set; }
        public string Autor { get; set; }
        public bool Ativo { get; set; }
    }
}