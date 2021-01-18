using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecucao executor = obterTipoExecucaoPelaEscolha(2);
            executor.Executar();
            ExecucaoJogo jogo = executor as ExecucaoJogo;
            jogo.IniciarJogoExibeMensagem();
            ExecucaoConfiguracao config = (ExecucaoConfiguracao) executor;
            Console.ReadKey();
        }

        static IExecucao obterTipoExecucaoPelaEscolha(int escolha) {
            switch (escolha)
            {
                case 1:
                    return new ExecucaoConfiguracao();
                case 2:
                    return new ExecucaoJogo();
                default:
                    throw new Exception();
            }


        }
    }
}
