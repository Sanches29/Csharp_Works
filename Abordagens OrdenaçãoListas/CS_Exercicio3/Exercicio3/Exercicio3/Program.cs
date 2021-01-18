using System;


namespace CS_Exerecicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] lines = System.IO.File.ReadAllLines(@"PathDoArquivoTxt");
            int[] linhas = new int[lines.Length];

            for (int i = 0; i <= lines.Length - 1; i++)
            {
                linhas[i] = int.Parse(lines[i]);
            }

            /* Console.WriteLine(linhas[7]);

             for (int i = 0; i <= linhas.Length - 1; i++)
             {
                 if (linhas[i] % 350 == 0)
                 {
                     Console.WriteLine(linhas[i]);
                 }
             }*/

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"PathDoArquivoParaOutput"))
            {
                for (int i = 0; i <= linhas.Length - 1; i++)
                {
                    if (linhas[i] % 350 == 0)
                    {
                        file.WriteLine(linhas[i]);
                    }
                }
            }





        }
    }
}