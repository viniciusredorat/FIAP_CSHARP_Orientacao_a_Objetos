using Aula2.Fiap.Bank.Models;
using Aula2.Fiap.Bank.Exceptions;
using System;

namespace Aula2.Fiap.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados imputados pelo usuário

            Console.WriteLine("Digite seu nome completo:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF:");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite o telefone do cliente:");
            var tel = Console.ReadLine();

            
            // Ler o input dos dados da conta corrente

            Console.WriteLine("Digite o número da conta:");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("É uma conta especial?");
            bool especial = bool.Parse(Console.ReadLine());

            decimal limite = 0;
            double juros = 0;

            if (especial)
            {
                //Caso a conta seja especial, o usuário deve realizar o input conforme abaixo
                Console.WriteLine("Digite o limite da conta:");
                limite = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite os juros da conta:");
                juros = double.Parse(Console.ReadLine());
            }

            // Ler os dados da conta poupança

            Console.WriteLine("Digite o número da conta poupança:");
            double numeroPoupanca = double.Parse(Console.ReadLine());

            // Instanciar Cliente
            Cliente cliente = new Cliente(nome, cpf, tel);

            // Instanciar Conta Poupança
            ContaPoupanca contaPoupanca = new ContaPoupanca(numeroPoupanca);

            // Instanciar Conta Corrente
            ContaCorrente contaCorrente = new ContaCorrente(numero: numeroConta, cliente: cliente,
                juros: juros, especial: especial, limite: limite , contaPoupanca: contaPoupanca);



            int opcao;

            do
            {
                Console.WriteLine("Escolha uma opção: \n1-Depositar \n2-Retirar \n3-Transferir \n4-Calcular \n0-Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor para o depósito:");
                        try
                        {
                            // Ler o valor para depósito
                            var valor = decimal.Parse(Console.ReadLine());
                            contaCorrente.Depositar(valor);
                            Console.WriteLine($"O Saldo da conta é {contaCorrente.Saldo} e o total {contaCorrente.RetornarSaldoTotal()}");
                        }
                        catch (ArgumentException e)
                        {
                            //Tratamento de exceções
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite um valor para retirar:");
                        try
                        {
                            //Realiza a operação de retirada, utilizando o método da classe
                            var valor = decimal.Parse(Console.ReadLine());
                            contaCorrente.Retirar(valor);
                            Console.WriteLine($"O Saldo da conta é {contaCorrente.Saldo} e o total {contaCorrente.RetornarSaldoTotal()}");
                        }
                        catch (SaldoInsuficienteException e)
                        {
                            //Tratamento de exceções
                            Console.WriteLine(e);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor para transferir:");
                        try
                        {
                            //Realiza a transferência de valores da CC para a Conta Poupança, considerando o valor do cheque especial
                            var valor2 = decimal.Parse(Console.ReadLine());
                            contaCorrente.TransferirParaPoupanca(valor2);
                            Console.WriteLine($"O Saldo da conta corrente é {contaCorrente.Saldo} e o total {contaCorrente.RetornarSaldoTotal()}");
                            Console.WriteLine($"O saldo de conta poupança é {contaPoupanca.Saldo}");
                        }
                        catch (Exception e)
                        {
                            //Tratamento de exceções
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        //Caso haja saldo devedor no cheque especial, os juros serão calculados
                        if (contaCorrente.Saldo < 0)
                        {
                            Console.WriteLine("Digite a quantidade de dias:");
                            int dias = int.Parse(Console.ReadLine());
                            decimal valorJuros = contaCorrente.CalcularValorTaxaJuros(dias);
                            Console.WriteLine($"O valor dos juros é: {valorJuros}");
                        }
                        else
                        {
                            //Caso não haja valor devedor, não realiza o calculo e retorna a mensagem ao usuário
                            Console.WriteLine("Não há cálculo de juros quando não há valor devedor.");
                        }
                        
                        break;
                    case 0:
                        // Finaliza o programa
                        Console.WriteLine("Finalizando o sistema...");
                        break;
                    default:
                        //Caso o input do usuário não atenda nenhum dos CASES acima, retorna uma mensagem por padrão
                        Console.WriteLine("Opção inválida!");
                        break;

                }
                // Enquanto a opção escolhida não for = 0 , o loop se mantém
            } while (opcao != 0);

        }
    }
}
