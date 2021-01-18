using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Exercicio3
{
    class Veiculo
    {
        protected string cor;
        protected string marca;
        protected string modelo;
        protected int ano;
        protected int rodas;

        public Veiculo()
        {
            cor = "Preto";
            marca = "Honda";
            modelo = "City";
            ano = 2017;
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
