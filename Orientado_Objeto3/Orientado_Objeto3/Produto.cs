using System;


namespace Orientado_Objetos3
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int a)
        {
            Quantidade += a;
        }
        public void RemoverProdutos(int b)
        {
            Quantidade -= b;
        }

        public override string ToString()   //override indica que essa operação veio de outra classe, no caso, Object(Toda
        {                                   // classe é subclasse de Object)      
            return Nome + ", $" + Preco.ToString("F2") + ", " 
                   + Quantidade 
                   + " unidades, Total: $" 
                   + ValorTotalEmEstoque().ToString("F2");
        }
    }

    
}
