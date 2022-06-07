using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Fiap.Models
{
    class Produto
    {
        //Propriedades - Informações que o objeto armazena

        public string IdProduto { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public string Marca { get; set; }

        //Métodos - Ações que o objeto pode executar
        public void ExibirDados()
        {
            Console.WriteLine($"Id do produto: {IdProduto}\nNome: {Nome}\nPreço: {Preco}\nEstoque: {Estoque}\nMarca: {Marca}");
        }

        public decimal CalcularDesconto(decimal ValorDesconto)
        {
            decimal valorFinal = Preco - ValorDesconto;
            return valorFinal;
        }

    }
}
