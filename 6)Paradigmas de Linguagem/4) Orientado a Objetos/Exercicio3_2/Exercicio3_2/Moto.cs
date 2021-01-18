using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3_2
{
    class Moto:Veiculo
    {
        public Moto()
        {
            rodas = 2;
        }

        public override void Ligar()
        {
            Console.WriteLine("Moto ligada!");
        }

    }
}
