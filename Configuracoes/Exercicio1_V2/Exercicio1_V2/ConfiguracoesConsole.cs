using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_V2
{
    class ConfiguracoesConsole
    {

        public void CarregarConfigsSalvas()
        {
            AtualizarConsoleBackground();
            AtualizarConsoleTextColor();
        }



        public void AlterarCorBackgroundAppConfig (int selecao)
        {
            switch (selecao)
            {
                case 1://Preto
                    Properties.Settings.Default.BackgroundColor = "black";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 2://Branco
                    Properties.Settings.Default.BackgroundColor = "white";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 3://Amarelo
                    Properties.Settings.Default.BackgroundColor = "yellow";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 4://Verde
                    Properties.Settings.Default.BackgroundColor = "green";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 5://Vermelho
                    Properties.Settings.Default.BackgroundColor = "red";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 6://Azul
                    Properties.Settings.Default.BackgroundColor = "blue";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                default:
                    break;
            }
        }

        public void AlterarCorTextAppConfig(int selecao)
        {
            switch (selecao)
            {
                case 1://Preto
                    Properties.Settings.Default.TextColor = "black";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 2://Branco
                    Properties.Settings.Default.TextColor = "white";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 3://Amarelo
                    Properties.Settings.Default.TextColor = "yellow";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 4://Verde
                    Properties.Settings.Default.TextColor = "green";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 5://Vermelho
                    Properties.Settings.Default.TextColor = "red";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                case 6://Azul
                    Properties.Settings.Default.TextColor = "blue";
                    Properties.Settings.Default.Save();
                    CarregarConfigsSalvas();
                    break;
                default:
                    break;
            }
        }

        private void AtualizarConsoleBackground()
        {
            string cor = Properties.Settings.Default.BackgroundColor;
            switch (cor)
            {
                case "black"://Preto
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "white"://Branco
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case "yellow"://Amarelo
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case "green"://Verde
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "red"://Vermelho
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "blue"://Azul
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }

        }

        private void AtualizarConsoleTextColor()
        {
            string cor = Properties.Settings.Default.TextColor;
            switch (cor)
            {
                case "black"://Preto
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "white"://Branco
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow"://Amarelo
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green"://Verde
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red"://Vermelho
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue"://Azul
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }

        }


    }
    
}
