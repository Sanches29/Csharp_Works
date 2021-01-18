using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Veiculo carro = new Carro();
            Veiculo moto = new Moto();

            Console.WriteLine($"O numero de rodas do veiculo é: {veiculo.GetRodas()}" );
            veiculo.Ligar();
            Console.WriteLine(veiculo.Detalhar());
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"O numero de rodas do carro é: {carro.GetRodas()}");
            carro.Ligar();
            Console.WriteLine(carro.Detalhar());
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"O numero de rodas da moto é: {moto.GetRodas()}");
            moto.Ligar();
            Console.WriteLine(moto.Detalhar());


        }
    }
}
