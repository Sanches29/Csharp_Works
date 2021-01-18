using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Carro:Veiculo
    {
        public Carro()
        {
            cor = "Vermelho";
            marca = "Fiat";
            modelo = "Uno";
            ano = 1986;
            rodas = 4;
        }

        public override void Ligar()
        {
            Console.WriteLine("Carro ligado!");
        }

    }
}
