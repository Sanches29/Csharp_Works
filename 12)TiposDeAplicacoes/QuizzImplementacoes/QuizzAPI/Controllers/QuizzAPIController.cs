using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Quizz;

namespace QuizzAPI.Controllers
{
    public class QuizzAPIController : ApiController
    {
        static string diretorioPerguntas = @"D:\home\site\wwwroot\Perguntas.json";
        static JogoQuizz gameManager = new JogoQuizz(diretorioPerguntas);
        static private int numeroPergunta = 0;
        static private int numerodePerguntas = gameManager.NumeroDePerguntas();


        [Route("api/QuizzAPI/IniciarAPI")]
        [HttpGet]
        public string IniciarAPI()
        {
            numeroPergunta = 0;
            gameManager = new JogoQuizz(diretorioPerguntas);
            return "QuizzAPI iniciado";
        }

        [Route("api/QuizzAPI/NumeroDePerguntas")]
        [HttpGet]
        public int NumeroDePerguntas()
        {
            return numerodePerguntas;
        }

        [Route("api/QuizzAPI/ExibirProximaPergunta")]
        [HttpGet]
        public string ExibirProximaPergunta()
        {
            if (numeroPergunta < numerodePerguntas)
            {
                return gameManager.ExibirPerguntaEAlternativas(numeroPergunta);
            }
            else
            {
                return "Não há mais perguntas a serem respondidas.";
            }
        }

        [Route("api/QuizzAPI/ResponderPergunta")]
        [HttpPost]
        public string ResponderPergunta([FromBody] string resposta)
        {
            if (numeroPergunta < numerodePerguntas)
            {
                string validacao = gameManager.ValidarRespostaUsuario(resposta, numeroPergunta);
                numeroPergunta++;
                return validacao;
            }
            else
            {
                return "Não há mais respostas a serem validadas. Chame o metodo exibir resultado final.";
            }
        }

        [Route ("api/QuizzAPI/ExibirResultadoFinal")]
        [HttpGet]
        public string ExibirResultadoFinal()
        {
            if (numeroPergunta < numerodePerguntas)
            {
                return "Ainda há perguntas para serem respondidas, ou respostas a serem validadas.";
            }
            else
            {
                return gameManager.ResultadoFinal();
            }
        }
        



    }
}
