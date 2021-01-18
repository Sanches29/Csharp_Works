using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz
{
    public class Perguntas
    {
        public string TituloPergunta { get; set; }
        public List<string> Alternativas { get; set; }
        public string Resposta { get; set; }
    }
}
