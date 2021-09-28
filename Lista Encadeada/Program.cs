using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Ligada
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, qtdNumeros, valor, numeroProcurado;
            Lista lista = new Lista();
            string menu = ("[0] Encerrar\n[1] Adicionar número\n[2] Adicionar número no final\n[3] Imprimir lista \n[4] Remover número no final\n[5] Remover número\n" +
                              "[6] Procurar número\n[7] Mostrar último número\n[8] Mostrar penúltimo número");

            Console.WriteLine("---------Lista de inteiros---------\n");
            do
            {
                Console.Write(menu + "\n");
                Console.Write("\nEscolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Write("Deseja adicionar quantos números? ");
                        qtdNumeros = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= qtdNumeros; i++)
                        {
                            Console.Write($"Digite o {i}° número: ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            lista.adicionar(valor);
                        }
                        break;
                    case 2:
                        Console.Write("Deseja adicionar quantos números no final da fila? ");
                        qtdNumeros = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= qtdNumeros; i++)
                        {
                            Console.Write($"Digite o {i}° número: ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            lista.AdicionarFinal(valor);
                        }
                        break;
                    case 3:
                        
                        lista.imprimir();
                        break;
                    case 4:
                        lista.RemoverFinal();
                        break;
                    case 5:
                        lista.remover();
                        break;
                    case 6:
                        Console.Write("Qual número deseja procurar na lista? ");
                        numeroProcurado = Convert.ToInt32(Console.ReadLine());
                        lista.procurar(numeroProcurado);
                        if (lista.procurar(numeroProcurado) == true)
                        {
                            Console.WriteLine("\nO valor existe na lista!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nO valor não existe na lista!\n");
                        }
                        break;
                    case 7:
                        Console.WriteLine($"\nÚltimo: {lista.Ultimo().item}\n");
                        break;
                    case 8:
                        Console.WriteLine($"\nPenúltimo: {lista.Penultimo().item}\n");
                        break;
                }
            } while (opcao != 0);

            Console.Write("Fim do programa, pressione qualquer tecla para sair......");

            Console.ReadKey();
        }
    }
}
