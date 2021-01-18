using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        bool liberarprocesso = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                liberarprocesso = true;
                lblNomeArquivo.Text = openFileDialog1.FileName;
                string lines = System.IO.File.ReadAllText(openFileDialog1.FileName);
                txtResultadoAnalise.Text = lines;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            if (liberarprocesso == true)
            {
                string lines = txtResultadoAnalise.Text;
                int letras = 0;
                int numeros = 0;
                int espacos = 0;
                int linhas = 1;
                int caracteres = 0;
                int palavras = 0;
                int palavras3letras = 0;
                string maiorpalavra = "";
                int excessoes = 0;

                char[] grupo = lines.ToCharArray();

                for (int i = 0; i <= (grupo.Length - 1); i++)
                {
                    //Console.WriteLine(grupo[i]);
                    //obter letras
                    if (((int)grupo[i] >= 65 && (int)grupo[i] <= 90) || ((int)grupo[i] >= 97 && (int)grupo[i] <= 122))
                    {
                        letras++;
                    }
                    //obter linhas
                    if ((int)grupo[i] == 10)
                    {
                        linhas++;
                        excessoes++;
                        //Console.WriteLine($"Temos {linhas} linhas ate agora");
                    }
                    //obter numeros
                    if ((int)grupo[i] >= 48 && (int)grupo[i] <= 57)
                    {
                        numeros++;
                    }
                    //obter espaços
                    if ((int)grupo[i] == 32)
                    {
                        espacos++;
                        excessoes++;
                    }
                    //obter /r
                    if ((int)grupo[i] == 13)
                    {
                        excessoes++;
                    }
                    //obter excessoes (espaços e retornos)

                }
                //obter caracteres
                caracteres = grupo.Length - excessoes;
                //obter palavras
                string[] separarEmPalavras = lines.Split(new Char[] { ' ', '\n' });
                palavras = separarEmPalavras.Length;
                //palavras com 3 letras
                foreach (var c in separarEmPalavras)
                {
                    if (c.Length == 3)
                    {
                        palavras3letras++;
                    }
                }
                //maior palavra


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
                        char[] atual = maiorpalavra.ToCharArray();
                        char[] nova = separarPalavrasGrupoTratado[i].ToCharArray();
                        if (nova[0] > atual[0])
                        {
                            maiorpalavra = separarPalavrasGrupoTratado[i];
                        }
                    }
                }

                //mudar o valor do texto com os resultados obtidos
                txtResultadoAnalise.Text = $@"Letras: {letras.ToString()}
Numeros: {numeros.ToString()}
Espaços: {espacos.ToString()}
Linhas: {linhas.ToString()}
Caracteres: {caracteres.ToString()}
Palavras: {palavras.ToString()}
Palavras de 3 Letras: {palavras3letras.ToString()}
Maior Palavra: {maiorpalavra}";
            }
            else
            {
                txtResultadoAnalise.Text = "Nenhum arquivo selecionado";
            }
        }

            static bool isNotReturn(char n)
            {
                return n != 13;
            }
        
    }
}
