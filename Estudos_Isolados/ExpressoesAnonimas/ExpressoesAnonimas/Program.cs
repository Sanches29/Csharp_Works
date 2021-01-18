using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressoesAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClasseX> lista1 = new List<ClasseX>();

            ClasseX objeto1 = new ClasseX();
            objeto1.parametroString = "a";
            objeto1.parametroInt = 3;
            lista1.Add(objeto1);

            ClasseX objeto2 = new ClasseX();
            objeto2.parametroString = "b";
            objeto2.parametroInt = 6;
            lista1.Add(objeto2);

            lista1.Where(x => { return x.parametroInt < 6;});



            Repositorio<int> RepositorioInt = new Repositorio<int>();
            int[] numeros = { 1, 2, 3, 4 }; 
            RepositorioInt.adicionar(numeros);

            Repositorio<ClasseX> RepositorioClasseX = new Repositorio<ClasseX>();
            RepositorioClasseX.adicionar(lista1.ToArray());

            RepositorioInt.adicionarIlimitado(1, 2, 3, 4, 5, 6, 4, 2, 3, 423, 421);

        }
    }


    
}
