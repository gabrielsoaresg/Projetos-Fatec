using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Ligada
{
    class Lista
    {
        public int tamanho;
        public No inicio;

        public Lista()
        {
            tamanho = 0;
            inicio = null;
        }

        public bool vazia()
        {
            return tamanho == 0;
        }

        public void adicionar(int valor)
        {
            No novo = new No(valor);
            novo.proximo = inicio;
            inicio = novo;
            tamanho++;
        }

        public void imprimir()
        {
            if (!vazia())
            {
                for (No i = inicio; i != null; i = i.proximo)
                {
                    Console.WriteLine($"Item: {i.item}");
                }
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
           
        }

        public void remover()
        {
            No item;
            if (vazia())
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                item = inicio;
                inicio = inicio.proximo;
                tamanho--;
            }
        }
        public bool procurar(int item)
        {
            if (vazia())
            {
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                for (No i = inicio; i != null; i = i.proximo)
                {
                    if (item == i.item)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }
}
