using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3_2
{
    class Carro:Veiculo
    {
        public Carro()
        {
            rodas = 4;
        }

        public override void Ligar()
        {
            Console.WriteLine("Carro ligado!");
        }
    }
}
