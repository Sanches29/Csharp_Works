using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressoesAnonimas
{
    class Repositorio<T>
    {


        private List<T> minhaLista = new List<T>();
        
        public void adicionar(T[] item)
        {

            minhaLista.AddRange(item);

        }

        public void adicionarIlimitado(params T[] meusItens)
        {
            minhaLista.AddRange(meusItens);
        }




    }
}
