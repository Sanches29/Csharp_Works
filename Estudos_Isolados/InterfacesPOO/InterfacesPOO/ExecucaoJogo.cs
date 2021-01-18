using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPOO
{
    class ExecucaoJogo : IExecucao
    {
        public void Executar()
        {
            Console.WriteLine("Estou no jogo");
        }

        public void IniciarJogoExibeMensagem()
        {
            Console.WriteLine("Mensagem secundaria");
        }
    }
}
