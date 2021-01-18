using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3_2
{
    class Veiculo
    {
        public string cor;
        public string marca;
        public string modelo;
        public int ano;
        protected int rodas;

        public Veiculo()
        {
            rodas = 4;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Veículo genérico ligado!");
        }

        public string Detalhar()
        {
            return @$"Detalhes:
Cor: {cor}
Marca: {marca}
Modelo: {modelo}
Ano: {ano}
Numero de rodas: {rodas}";
        }

        public int GetRodas()
        {
            return rodas;
        }


    }
}
