using System;

namespace Aplicativo{
    
    
    class Program{
            static void Main(string[] args){

            int digConta, escolha;
            double saldoIni, itensC, limiteC, newSald, saldoAtual, totalCA, crediIM;
            string senha; 
            var crediIMSN = "";
            var totalCASN = "";
            
            
            itensC = 3 * 100;
            limiteC =  1000.00;
            saldoIni = 500.00;
            Console.WriteLine("Seja bem vindo(a) a loja de departamentos Tchurusbango!");
            Console.Write("Digite o dígito de sua conta para continuar: ");
            digConta = Int32.Parse(Console.ReadLine());
            
            //Define uma chave aleatória para que o usuário digite como forma de validar o loign.
            string chars = "abcdefghjkmnpqrstuvwxyz023456789";
            string pass = "";
            Random random = new Random();
            for (int f = 0; f < 6; f++) {
                pass = pass + chars.Substring(random.Next(0, chars.Length-1), 1);
            }
            Console.WriteLine($"A sua chave de acesso é: {pass}");
            Console.Write("Insira a chave para acessar a conta: ");
            senha = Console.ReadLine();
            if(senha != pass){
                Console.WriteLine("Acesso negado!");
                Environment.Exit(0);
            }else{
                Console.WriteLine("Acesso à sua conta concedido!");
            }
            Console.WriteLine("[1] Saldo início do mês\n[2] Itens cobrados do cliente\n[3] Créditos aplicados no mês\n[4] Limite de crédito permitido\n[5] Sair da sua conta");
            Console.Write("Qual a sua opção? ");
            escolha = Int32.Parse(Console.ReadLine());

            switch(escolha){

                case 1:
                    Console.Write($"Saldo início do mês: R${saldoIni}\n");
                    Console.Write("Adicionou crédito no início do mês? (Digite S ou N): ");
                    crediIMSN = Console.ReadLine();
                    if(crediIMSN == "S"){
                        Console.Write("Quantos reais? R$ ");
                        crediIM = Double.Parse(Console.ReadLine());
                        newSald = crediIM + saldoIni;
                        Console.WriteLine($"Seu saldo atual do início do mês é de: R${newSald}");
                    }else{  
                        Console.WriteLine($"Ok! Seu saldo do início do mês continua de: R${saldoIni}");
                    }
                    break;
                case 2:
                    Console.WriteLine($"Foram cobrados R${itensC} ao longo do mês!");
                    break;
                case 3:
                    Console.Write("Foram aplicados créditos ao longo do mês? (Digite S ou N): ");
                    totalCASN = Console.ReadLine();
                    if(totalCASN == "S"){
                        Console.Write($"Quanto foi aplicado? R$ ");
                        totalCA = Double.Parse(Console.ReadLine());
                        saldoAtual = totalCA + saldoIni - itensC;
                        Console.WriteLine($"Seu saldo ao longo do mês foi de: R${saldoAtual}");
                        Console.WriteLine("PS: Saldo atual = saldo do inicio do mês + total de créditos aplicados - total descontado.");  
                    }else{
                        Console.WriteLine("OK! Saldo mantido.");
                    }
                    break;
                case 4:
                    Console.Write($"Limite de crédito disponível é de: R${limiteC}");
                    break;
                default:
                    Console.Clear();
                    Console.Write("Saindo da sua conta......");
                    break;
            }
        }
    }
}
