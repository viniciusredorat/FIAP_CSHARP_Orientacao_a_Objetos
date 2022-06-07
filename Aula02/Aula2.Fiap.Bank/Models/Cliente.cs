using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Fiap.Bank.Models
{
    class Cliente
    {
        //Propriedades 

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        // Construtor
        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }


    }
}
