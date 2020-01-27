using System;


namespace Exercicio3
{
    class Aluno
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double Soma()
        {
            return nota1 + nota2 + nota3;
        }
        public string Verificacao()
        {
            if (Soma() >= 60)
            {
                return "Aprovado";
            }
            else
            {

                return "Reprovado";  
            }
        }
        public double restante()
        {
            return (60 - Soma());
        }
    }
}
