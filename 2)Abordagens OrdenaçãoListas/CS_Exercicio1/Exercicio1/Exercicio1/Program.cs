//1. Ordene os números em ordem decrescente sem usar funções prontas do framework .NET
//(LINQ e correlatos) e escreva o resultado em um arquivo texto;
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

            QuickSort(linhas, 0, linhas.Length - 1);
            
            using (System.IO.StreamWriter file =
             new System.IO.StreamWriter(@"PathDoArquivoParaOutput"))
            {
                for (int i = 0; i <= linhas.Length - 1; i++)
                {
                    file.WriteLine(linhas[i]);
                }
            }

        }

        public static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1); //recursividade
                QuickSort(arr, i + 1, end);
                //buffer overflow
            }
        }

        public static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] >= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }
}