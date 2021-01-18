using System;

namespace Exercicio3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Veiculo carro = new Carro();
            Veiculo moto = new Moto();

            Console.WriteLine("Inicio do programa");
            Console.WriteLine("Defina valores basicos para a classe veículo: ");
            Console.Write("Entre com a cor do veiculo: ");
            veiculo.cor = Console.ReadLine();
            Console.Write("Entre com a marca do veiculo: ");
            veiculo.marca = Console.ReadLine();
            Console.Write("Entre com o modelo do veiculo: ");
            veiculo.modelo = Console.ReadLine();
            Console.Write("Entre com o ano do veiculo: ");
            veiculo.ano = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Defina valores para a classe carro: ");
            Console.Write("Entre com a cor do carro: ");
            carro.cor = Console.ReadLine();
            Console.Write("Entre com a marca do carro: ");
            carro.marca = Console.ReadLine();
            Console.Write("Entre com o modelo do carro: ");
            carro.modelo = Console.ReadLine();
            Console.Write("Entre com o ano do carro: ");
            carro.ano = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Defina valores para a classe moto: ");
            Console.Write("Entre com a cor da moto: ");
            moto.cor = Console.ReadLine();
            Console.Write("Entre com a marca da moto: ");
            moto.marca = Console.ReadLine();
            Console.Write("Entre com o modelo da moto: ");
            moto.modelo = Console.ReadLine();
            Console.Write("Entre com o ano da moto: ");
            moto.ano = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"O numero de rodas do veiculo é: {veiculo.GetRodas()}");
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
