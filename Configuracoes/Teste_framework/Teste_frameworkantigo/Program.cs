using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Teste_frameworkantigo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Properties.Settings.Default.BackgroundColor);
            Console.WriteLine(Properties.Settings.Default.TextColor);
            

            Properties.Settings.Default.BackgroundColor = "yellow";
            Properties.Settings.Default.TextColor = "black";
            Properties.Settings.Default.Save();

            string corFundo = Properties.Settings.Default.BackgroundColor;
            string corLetra = Properties.Settings.Default.TextColor;



           
            Console.WriteLine(corFundo);
            Console.WriteLine(corLetra);
            Console.ReadKey();

            
        }
    }
}
