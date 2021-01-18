using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using Quizz;

namespace QuizzMVC.Controllers
{
    public class QuizzMVCController : Controller
    {
        static string diretorioPerguntas = @"PathJson";
        static bool programaIniciado = false;
        // JogoQuizz gameManager = new JogoQuizz(diretorioPerguntas);
        //static private int numeroPergunta = 0;
        //static private int numerodePerguntas = 0;
        //static private bool acabouPrograma = false;
        // GET: QuizzMVC
    


        public ActionResult Index()
        {
            JogoQuizz gameManager = new JogoQuizz(diretorioPerguntas);
            int numerodePerguntas = gameManager.NumeroDePerguntas();
            int numeroPergunta = 0;
            programaIniciado = true;
            //Session.Add("gameManager", gameManager);
            Session["gameManager"] = gameManager;
            Session["numerodePerguntas"] = numerodePerguntas;
            Session["numeroPergunta"] = numeroPergunta;
            return RedirectToAction("ExibirPergunta");
        }

        public ActionResult ExibirPergunta()
        {
            if (programaIniciado == true)
            {
                int numerodePerguntas = (int)Session["numerodePerguntas"];
                int numeroPergunta = (int)Session["numeroPergunta"];
                if (numeroPergunta < numerodePerguntas)
                {
                    var classe = Session["gameManager"] as JogoQuizz;
                    string pergunta = classe.ExibirPerguntaEAlternativas(numeroPergunta);
                    //string pergunta = gameManager.ExibirPerguntaEAlternativas(numeroPergunta);

                    ViewData["perguntaERespostas"] = pergunta;

                    return View();
                }
                else
                {
                    return RedirectToAction("ExibirResultadoFinal");
                }
            }
            else
            {
                return RedirectToAction("AcessoIndevidoPage");
            }
        }

        [HttpPost]
        public ActionResult ValidarResposta(FormCollection CollectionResposta)
        {
            if (programaIniciado == true)
            {
                int numeroPergunta = (int)Session["numeroPergunta"];
                string alternativaEscolhida = CollectionResposta["alternativa"];
                var classe = Session["gameManager"] as JogoQuizz;
                classe.ValidarRespostaUsuario(alternativaEscolhida, numeroPergunta);
                //gameManager.ValidarRespostaUsuario(alternativaEscolhida, numeroPergunta);

                numeroPergunta++;
                Session["numeroPergunta"] = numeroPergunta;
                return RedirectToAction("ExibirPergunta");
            }
            else
            {
                return RedirectToAction("AcessoIndevidoPage");
            }
        }

        public ActionResult ExibirResultadoFinal()
        {
            
            if (programaIniciado == true)
            {
                int numerodePerguntas = (int)Session["numerodePerguntas"];
                int numeroPergunta = (int)Session["numeroPergunta"];
                if (numeroPergunta < numerodePerguntas)
                {
                    return RedirectToAction("AcessoIndevidoPerguntasNaoRespondidas");
                }
                else
                {
                    var classe = Session["gameManager"] as JogoQuizz;
                    //string resultado = gameManager.ResultadoFinal();
                    string resultado = classe.ResultadoFinal();
                    Session.Abandon();
                    programaIniciado = false;

                    ViewData["resultado"] = resultado;

                    return View();
                }
            }
            else
            {
                return RedirectToAction("AcessoIndevidoPage");
            }

        }

        public ActionResult AcessoIndevidoPage()
        {
            Session.Abandon();
            programaIniciado = false;
            return View();
        }

        public ActionResult AcessoIndevidoPerguntasNaoRespondidas()
        {
            Session.Abandon();
            programaIniciado = false;
            return View();
        }
    }
}