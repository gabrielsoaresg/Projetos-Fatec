using System;

namespace CÁLCULO_QUILOMETRAGEM{
    class Program{
        static void Main(string[] args){

            int semanas, i, tanque;
            double gasolina, km, calc; 

            Console.WriteLine("Cálculo de Desempenho\n");
            Console.Write("Digite quantas semanas foram analisadas para realizar os cálculos:  ");
            semanas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("PS: A CAPACIDADE MÁXIMA DE ARMAZENAMENTO DE COMBUSTÍVEL NO TANQUE É DE 73L");
            Console.Write("Digite a capacidade máxima do seu tanque de combustível: ");
            tanque = Int32.Parse(Console.ReadLine());
            i = 1;
            if(tanque <= 73){
                for(i = 1; i <= semanas; i++){
                    Console.Write($"Digite os quilômetros rodados na semana {i}: ");
                    km = Double.Parse(Console.ReadLine());
                    Console.Write($"Digite a quantidade de combustível abastecido na semana {i}: ");
                    gasolina = Double.Parse(Console.ReadLine());
                    calc = km / gasolina; 
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Você fez {String.Format("{0:N}", calc)} Km/L na semana {i}");
                    Console.ResetColor();
                    if(calc < 10){
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Seu carro NÃO está fazendo uma boa média de consumo!\n");
                        Console.ResetColor();
                    }else if(calc >= 10 & calc <= 15){
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Seu carro está fazendo uma BOA média de consumo!\n");
                        Console.ResetColor();
                    }else if(calc > 15){
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Seu carro está fazendo uma ÓTIMA média de consumo!\n");
                        Console.ResetColor();
                    }
                }
            }else{
                Console.Write("CAPACIDADE EXCEDIDA!");
                Console.WriteLine("PRESSIONE QUALQUER TECLA PARA CONTINUA....");
                Console.ReadKey();
            }
        }    
    }
} 