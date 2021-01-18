using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_V2
{
    class GerenciadorDePalavras
    {
        Random random = new Random();
       

        public string palavraRandom()
        {
            List<string> lista = lerArquivo();
            //Random random = new Random();
            int randomindex = random.Next(lista.Count);
            return lista[randomindex];
        }

        private List<string> lerArquivo()
        {
            string[] palavras = System.IO.File.ReadAllLines(Properties.Settings.Default.Diretorio);
            List<string> palavraslist = palavras.ToList();
            return palavraslist;
        }

        public void changeDiretorio(string diretorioNovo)
        {
            Properties.Settings.Default.Diretorio = diretorioNovo;
            Properties.Settings.Default.Save();
        }
        

    }
}
