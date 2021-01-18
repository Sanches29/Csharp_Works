using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPOO
{
    class ExecucaoConfiguracao : IExecucao
    {
        public void Executar()
        {
            Console.WriteLine("Estou na config");
        }
    }
}
