using System;

namespace SistemaBancario
{
    public class ContaBancaria
    {
        public string NomeCliente { get; private set; }
        public double Saldo { get; private set; }
        public TipoConta TipoConta { get; }

        private ContaBancaria() { }

        public ContaBancaria(string nomeCliente, double saldo, TipoConta tipoConta)
        {
            NomeCliente = nomeCliente;
            Saldo = saldo;
            TipoConta = tipoConta;
        }

        public void Debitar(double quantidade)
        {
            if(TipoConta == TipoConta.Poupanca)
            {
                if (quantidade >= 1000)
                {
                    //throw new Exception("Conta poupança não pode debitar acima de 1000");
                    return;
                }
            }
            Saldo -= quantidade; 
        }

        public void Creditar(double quantidade)
        {
            Saldo += quantidade;
        }        
    }
    public enum TipoConta
    {
        Corrente,
        Poupanca
    }
}