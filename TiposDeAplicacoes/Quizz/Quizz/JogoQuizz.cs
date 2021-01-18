using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Quizz
{
    public class JogoQuizz
    {
        private int acertos = 0;
        private int numeroDePerguntas = 0;
        List<Perguntas> perguntas = new List<Perguntas>();

        public JogoQuizz(string diretorioJsonPerguntas)
        {
            string json = File.ReadAllText(diretorioJsonPerguntas);
            perguntas = JsonConvert.DeserializeObject<List<Perguntas>>(json);
            numeroDePerguntas = perguntas.Count();
        }


        public string ValidarRespostaUsuario(string respostaDoUsuario, int numeroDaPergunta)
        {
            if (respostaDoUsuario == perguntas[numeroDaPergunta].Resposta)
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
            double porcentagemAcertos = ((double) acertos / (double)numeroDePerguntas)*100;
            if (acertos >= valorMinimo) return $"Bem sucedido no teste! Você acertou {porcentagemAcertos}%";
            else return $"Mal sucedido no teste! Seu resultado de {porcentagemAcertos}% é menor que 75%";

        }


    }
}
