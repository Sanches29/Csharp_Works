using System;

namespace Exercicio1
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return ((largura * 2) + (altura * 2));
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + (Math.Pow(altura, 2)));
        }

    }
}
