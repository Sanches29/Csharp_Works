using System;


namespace Exercicio2
{
    class Funcionario
    {
        public string Nome;
        public double Bruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Bruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            Bruto += Bruto * porcentagem / 100;
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido().ToString("F2");
        }
    }
}
