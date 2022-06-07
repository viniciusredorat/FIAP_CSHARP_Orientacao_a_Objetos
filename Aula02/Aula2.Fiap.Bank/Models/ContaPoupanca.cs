using System;
using Aula2.Fiap.Bank.Exceptions;

namespace Aula2.Fiap.Bank.Models
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Propriedades
        public decimal Rendimentos { get; set; }

        public ContaPoupanca(double numero)
        {
            Numero = numero;
        }

        //Métodos
        public void Retirar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException($"Valor mávimo para saque {Saldo}");
            }
            Saldo -= valor; // Saldo = Saldo - valor;
        }

        public decimal CalcularRetornoInvestimento(decimal taxa)
        {
            return Saldo * taxa;
        }

    }
}
