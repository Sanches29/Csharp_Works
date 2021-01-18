using System;
using System.Text;

namespace Exercicios1e2
{
    public class FizzBuzz
    {

        public string ResultadoFizzBuzz1a100()
        {
            StringBuilder resultadoAnaliseFizzBuzz = new StringBuilder();
            for(int i = 1;i<=100; i++)
            {
                resultadoAnaliseFizzBuzz.AppendLine(VerificaSeEhFizzBuzz(i));
            }

            return resultadoAnaliseFizzBuzz.ToString();

            
        }

        private string VerificaSeEhFizzBuzz(int numero)
        {

            if(numero%3 == 0)
            {
                if(numero%5 == 0)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else
            {
                if(numero%5 == 0)
                {
                    return "Buzz";
                }

                else
                {
                    return numero.ToString();
                }
            }

        }

        public string ResultadoFizzBuzzComNumeroEscolhido(int numero)
        {
            return VerificaSeEhFizzBuzz(numero);
        }




    }
}
