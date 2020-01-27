
using System;  //para poder utilizar o Math.Sqrt
namespace Orientado_Objetos2
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Calculo_area()                                //como o metodo esta dentro da classe triagulo e o metodo nao depende de outros
                                                                   // parametros a não ser A,B,C ja presentes na classe, não é necessário definir
                                                                  // parametros para a função.
        {
            double p = (A + B + C) / 2.0;                             //nao precisa especificar qual o objeto a ser trabalhado, o metodo sera
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // aplicado para o triangulo em questao( primeiro ou segundo ou terceiro.... etc)       
        } 
    }
 }

