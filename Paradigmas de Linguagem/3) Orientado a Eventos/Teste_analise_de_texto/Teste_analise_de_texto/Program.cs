using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teste_analise_de_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste = @"Hoje eu vou comer 1234 coisas
e alem disso fazer nada aoisas"; //43 letras
            int letras = 0;
            int numeros = 0;
            int espacos = 0;
            int linhas = 1;
            int caracteres = 0;
            int palavras = 0;
            int palavras3letras = 0;
            string maiorpalavra = "";
            int excessoes = 0;
            

            char[] grupo = teste.ToCharArray();

            for (int i = 0; i <= (grupo.Length -1); i++)
            {
                //Console.WriteLine(grupo[i]);
                //obter letras
                if(((int)grupo[i] >= 65 && (int)grupo[i] <= 90) || ((int)grupo[i] >= 97 && (int)grupo[i] <= 122))
                {
                    letras++;
                }
                //obter linhas
                if((int)grupo[i] == 10)
                {
                    linhas++;
                    excessoes++;
                    //Console.WriteLine($"Temos {linhas} linhas ate agora");
                }
                //obter numeros
                if((int)grupo[i] >= 48 && (int)grupo[i] <= 57)
                {
                    numeros++;
                }
                //obter espaços
                if((int)grupo[i] == 32)
                {
                    espacos++;
                    excessoes++;
                }
                //obter /r
                if((int)grupo[i] == 13)
                {
                    excessoes++;
                }
                //obter excessoes (espaços e retornos)

            }
            //obter caracteres
            caracteres = grupo.Length - excessoes;
            //obter palavras
            string[] separarEmPalavras = teste.Split(new Char[] { ' ', '\n' });
            palavras = separarEmPalavras.Length;
            //palavras com 3 letras
            foreach (var c in separarEmPalavras)
            {
                if(c.Length == 3)
                {
                    palavras3letras++;
                }
            }
            //maior palavra
            static bool isNotReturn(char n)
            {
                return n != 13;
            }

            grupo = Array.FindAll(grupo, isNotReturn).ToArray();

            StringBuilder builder = new StringBuilder();
            foreach (char value in grupo)
            {
                builder.Append(value);
            }
            string grupotratado = builder.ToString();
            string[] separarPalavrasGrupoTratado = grupotratado.Split(new Char[] { ' ', '\n' });

            for (int i = 0; i <= separarPalavrasGrupoTratado.Length - 1; i++)
            {
                if (separarPalavrasGrupoTratado[i].Length > maiorpalavra.Length)
                {
                    maiorpalavra = separarPalavrasGrupoTratado[i];
                }
                else if (separarPalavrasGrupoTratado[i].Length == maiorpalavra.Length)
                {
                    Console.WriteLine("mesmo tamanho");
                    char[] atual = maiorpalavra.ToCharArray();
                    char[] nova = separarPalavrasGrupoTratado[i].ToCharArray();
                    Console.WriteLine(atual[0]);
                    Console.WriteLine(nova[0]);
                    if (nova[0] > atual[0])
                    {
                        maiorpalavra = separarPalavrasGrupoTratado[i];
                    }
                }
            }


            Console.WriteLine(linhas);
            Console.WriteLine(numeros);
            Console.WriteLine(espacos);
            Console.WriteLine(letras);
            Console.WriteLine(caracteres);
            Console.WriteLine(palavras);
            Console.WriteLine(palavras3letras);
            Console.WriteLine(maiorpalavra);
            Console.WriteLine(maiorpalavra.Length);
        }
    }
}
