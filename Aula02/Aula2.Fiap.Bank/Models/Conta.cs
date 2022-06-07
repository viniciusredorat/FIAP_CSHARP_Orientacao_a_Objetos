using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Fiap.Bank.Models
{
    class Conta
    {
        //Propriedades da conta

        public decimal Saldo { get; protected set; }

        public double Numero { get; set; }

       public void Depositar(decimal valor)
        {
            // Verifica se o valor do depósito é positivo
            if (valor < 0)
            {
                throw new ArgumentException("O valor não pode ser negativo");
            }
            Saldo += valor; // Saldo = Saldo + valor;
        }

    }
}
