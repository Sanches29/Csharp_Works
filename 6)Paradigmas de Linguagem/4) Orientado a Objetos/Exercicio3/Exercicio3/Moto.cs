using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Moto:Veiculo
    {
        public Moto()
        {
            cor = "Verde";
            marca = "Kawasaki";
            modelo = "Ninja 400";
            ano = 2019;
            rodas = 2;
        }

        public override void Ligar()
        {
            Console.WriteLine("Moto Ligada");
        }
    }
}
