using System;

namespace CALCULADORA{

    class Program{

        static void Main(string[] args){

            int a, b, soma, sub, mult, div, mod, escolha;

            Console.WriteLine("Calculadora\n");
            Console.Write("Digite o primeiro número: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            b = Int32.Parse(Console.ReadLine());
            
            soma = a + b;
            sub = a - b;
            mult = a * b;
            div = a / b; 
            mod = a % b;
            
            Console.WriteLine("OPERAÇÕES:\n");
            Console.WriteLine("[1] Soma\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\n[5] Módulo");
            Console.Write("Escolha uma operação: ");
            escolha = Int32.Parse(Console.ReadLine());

            switch(escolha){

                case 1:
                    Console.WriteLine($"{a} + {b} = {soma}");
                    break;
                case 2:
                    Console.WriteLine($"{a} - {b} = {sub}");
                    break;
                case 3:
                    Console.WriteLine($"{a} * {b} = {mult}");
                    break;
                case 4:
                    Console.WriteLine($"{a} / {b} = {div}");
                    break;
                case 5:
                    Console.WriteLine($"{a} % {b} = {mod}");
                    Console.WriteLine("OBS: Operação de módularização encontra o resto da divisão.");
                    break;
            }
        }
    }
}