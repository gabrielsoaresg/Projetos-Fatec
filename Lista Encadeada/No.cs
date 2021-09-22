using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Ligada
{
    public class No
    {
        public int item;
        public No proximo;

        public No(int valor)
        {
            item = valor;
            proximo = null;
        }
    }
}
