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

        public No remover()
        {
            No item = inicio;
            if (vazia())
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {

                inicio = inicio.proximo;
                tamanho--;
            }
            return item;
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

        public No Ultimo()
        {
            No ultimo = inicio;
            for(No i = inicio; i != null; i = i.proximo)
            {
                ultimo = i;
            }
            return ultimo;
        }

        public void AdicionarFinal(int valor)
        {
            if (vazia())
            {
                adicionar(valor);
            }
            else
            {
                    No novoFinal = new No(valor);
                    Ultimo().proximo = novoFinal;
                    tamanho++;
            }
        }

        public No Penultimo()
        {
            No penultimo = inicio;
            for (No i = inicio; i.proximo != null; i = i.proximo)
            {
                penultimo = i;
            }
            return penultimo;
        }

        public No RemoverFinal()
        {
            No aux = inicio;
            if (!vazia())
            {
                if(tamanho == 1)
                {
                    aux = remover();
                }
                else
                {
                    aux = Ultimo();
                    Penultimo().proximo = null;
                    tamanho--;
                }
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            return aux;
        }

    }
}
