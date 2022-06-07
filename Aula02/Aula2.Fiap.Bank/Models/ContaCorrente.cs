using Aula2.Fiap.Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Fiap.Bank.Models
{
    class ContaCorrente : Conta
    {
        //Propriedades da conta corrente

        public bool Especial { get; set; }

        public decimal Limite { get; set; }

        public Cliente Cliente { get; set; }

        public ContaPoupanca ContaPoupanca { get; set; }

        public double Juros { get; set; }

        //Construtor
        public ContaCorrente(double numero, bool especial, decimal limite,
            Cliente cliente, ContaPoupanca contaPoupanca,double juros)
        {
            Numero = numero;
            Limite = limite;
            Cliente = cliente;
            Especial = especial;
            Juros = juros;
            ContaPoupanca = contaPoupanca;
                
        }

        public void Retirar(decimal valor)
        {
            if (! ((Especial && valor <= Saldo + Limite) || (valor <= Saldo)))
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para realizar a operação.");
            }
            Saldo -= valor;
        }

        public decimal RetornarSaldoTotal()
        {
            if (Especial)
            {
                return Saldo + Limite;
            }
            return Saldo;
        }

        public void TransferirParaPoupanca(decimal valor)
        {
            Retirar(valor); // Chama um método da própria classe
            ContaPoupanca.Depositar(valor);
        }

        public decimal CalcularValorTaxaJuros(int dias)
        {
            if( Saldo < 0)
            {
                return Convert.ToDecimal(Juros) * dias * Saldo;
            }
            else
            {
                return 0;
            
            }
        }


    }
}
