using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Quizz;
//using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace QuizzImplementacoes
{
    class QuizzConsole
    {
        static void Main()
        {
            bool continuarPrograma = true;

            while (continuarPrograma)
            {
                int opcaoSelecionada = ExibirMenuDeEscolhasEPegarSelecao();
                switch (opcaoSelecionada)
                {
                    case 1:
                        TrabalhandoComJogo();
                        break;
                    case 2:
                        Console.WriteLine("Até mais");
                        Console.ReadKey();
                        continuarPrograma = false;
                        break;
                }
            }

        }
        static int ExibirMenuDeEscolhasEPegarSelecao()
        {
            int escolha = 0;
            Console.WriteLine("***QUIZZ***");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Jogar");
            Console.WriteLine("2. Sair");

            do
            {
                Console.Write("Digite sua escolha: ");
                escolha = int.Parse(Console.ReadLine());

            } while (escolha < 1 || escolha > 2);

            return escolha;

        }

        static void TrabalhandoComJogo()
        {
            Console.WriteLine(IniciarQuizzAPI());

            int numeroDePerguntas = GETNumeroDePerguntas();
            for (int i = 0; i < numeroDePerguntas; i++)
            {
                Console.Clear();
                Console.WriteLine(GETProximaPergunta());
                Console.Write("Insira a letra da resposta: ");
                string respostaUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine(POSTResponderPergunta(respostaUsuario));
                Console.WriteLine("Pressione qualquer tecla para a proxima questao...");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine(GETResultadoFinal());
            Console.ReadKey();
            Console.Clear();

        }

        static string IniciarQuizzAPI()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://quizzapi.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("/api/QuizzAPI/IniciarAPI").Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<string>().Result;
                }
                else
                {
                    return "Erro ao iniciar a API";
                }
            }

        }


        static int GETNumeroDePerguntas()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://quizzapi.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("/api/QuizzAPI/NumeroDePerguntas").Result;
                if (response.IsSuccessStatusCode)
                {
                    //n sei
                    return response.Content.ReadAsAsync<int>().Result;
                }
                else
                {
                    return 0;
                }
            }

        }

        static string GETProximaPergunta()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://quizzapi.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("/api/QuizzAPI/ExibirProximaPergunta").Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<string>().Result;
                }
                else
                {
                    return "Erro no request da proxima pergunta";
                }
            }

        }

        static string POSTResponderPergunta(string resposta)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://quizzapi.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync<string>("/api/QuizzAPI/ResponderPergunta", resposta).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    return "Erro ao responder pergunta";
                }
            }

        }

        static string GETResultadoFinal()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://quizzapi.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("/api/QuizzAPI/ExibirResultadoFinal").Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    return "Erro no request de resposta final";
                }
            }

        }
    }
}









