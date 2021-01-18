using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizz;

namespace QuizzForms
{
    public partial class Form1 : Form
    {
        static string diretorioPerguntas = @"C:\Users\GuilhermeSilvaSanche\Desktop\Universidade_Trainee\10)BoasPraticas\Perguntas.json";
        static private int numeroPergunta = 0;
        static private int numerodePerguntas = 0;
        static private bool acabouPrograma = false;
        JogoQuizz gameManager = new JogoQuizz(diretorioPerguntas);

        public Form1()
        {
            InitializeComponent();
            
            numerodePerguntas = gameManager.NumeroDePerguntas();
            ExibirPergunta();
        }

        private void ExibirPergunta()
        {
            if (numeroPergunta < numerodePerguntas)
            {
                rtxt1.Clear();
                rtxt1.Text = gameManager.ExibirPerguntaEAlternativas(numeroPergunta);
            }
            else
            {
                rtxt1.Text = gameManager.ResultadoFinal();
                acabouPrograma = true;
                btnAvancar.Text = "Finalizar";
            }


        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (acabouPrograma == false)
            {
                string alternativaEscolhida = checklstboxAlternativas.CheckedItems[0].ToString();
                string resultado = gameManager.ValidarRespostaUsuario(alternativaEscolhida, numeroPergunta);
                if(resultado == "Correto!")
                {
                    var acertou = new Acertou();
                    acertou.Show();
                }
                else
                {
                    var errou = new Errou();
                    errou.Show();
                }
                numeroPergunta++;
                ExibirPergunta();
            }
            else
            {
                Application.Exit();
            }
        }

        private void checklstboxAlternativas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checklstboxAlternativas.Items.Count; ++i)
                if (i != e.Index) checklstboxAlternativas.SetItemChecked(i, false);
        }
    }
}
