using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Exercicio1
{
    class JogoQuizz
    {
        private int acertos = 0;
        private int numeroDePerguntas = 0;
        List<Perguntas> perguntas = new List<Perguntas>();

        public JogoQuizz()
        {
            string json = File.ReadAllText(Properties.Settings.Default.DiretorioJson);
            perguntas = JsonConvert.DeserializeObject<List<Perguntas>>(json);
            numeroDePerguntas = perguntas.Count();
        }


        public string ValidarRespostaUsuario(string respostaDoUsuario, int numeroDaPergunta)
        {
            if(respostaDoUsuario == perguntas[numeroDaPergunta].Resposta)
            {
                acertos++;
                return "Correto!";
            }
            else
            {
                return "Incorreto!";
            }

        }

        public string ExibirPerguntaEAlternativas(int numeroDaPergunta)
        {
            StringBuilder PerguntasEAlternativas = new StringBuilder();
            PerguntasEAlternativas.AppendLine(perguntas[numeroDaPergunta].TituloPergunta);
            for (int i = 0; i < perguntas[numeroDaPergunta].Alternativas.Count(); i++)
            {
                PerguntasEAlternativas.AppendLine(perguntas[numeroDaPergunta].Alternativas[i]);
            }

            return PerguntasEAlternativas.ToString();

        }

        public int NumeroDePerguntas()
        {
            return numeroDePerguntas;
        } 

        public string ResultadoFinal()
        {
            double valorMinimo = numeroDePerguntas * 0.75;
            if (acertos >= valorMinimo) return "Bem sucedido no teste!";
            else return "Mal sucedido no teste!";

        }


    }
}
