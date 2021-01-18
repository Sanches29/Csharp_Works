using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios1e2
{
    public class EscreverFrasesComLimiteDeLetrasPorLinhas
    {

        public string RecebeAFraseERetornStringFormatada(string frase, int NumeroMaximoDeLetrasNaLinha)
        {
            List<string> PalvrasDaFrase = new List<string>();
            PalvrasDaFrase.AddRange(frase.Split(" "));
            StringBuilder fraseFormatada = new StringBuilder();
            int Multiplo = 1;      
            //int NumeroDeComparacao = Multiplo * (NumeroMaximoDeLetrasNaLinha + 2); //+2 pq os ultimos dois espaços são para \r\n
            foreach(string item in PalvrasDaFrase)
            {
                int NumeroDeComparacaoAtualizado = Multiplo*(NumeroMaximoDeLetrasNaLinha + 2);
                //int Tamanho = fraseFormatada.ToString().Length;
                if(item.Length > (NumeroMaximoDeLetrasNaLinha)){
                    throw new Exception($"O tamanho de {item} é maior do que o tamanho definido na linha");
                    
                }
                else if((fraseFormatada.ToString().Length + item.Length) < (NumeroDeComparacaoAtualizado - 2))
                {
                    fraseFormatada.Append(item + " ");
                }
                else if((fraseFormatada.ToString().Length + item.Length) == (NumeroDeComparacaoAtualizado - 2))
                {
                    fraseFormatada.Append(item);
                }
                else
                {
                    fraseFormatada.Append("\r\n" + item + " ");
                    Multiplo++;
                }
            }

            return fraseFormatada.ToString();

        }





    }
}
