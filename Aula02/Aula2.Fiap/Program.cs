using System;
using Aula2.Fiap.Models;


namespace Aula2.Fiap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados do input do usuário
            // var -> declara uma variável do tipo do valor associado a ela 
            Console.WriteLine("Digite o ID do produto:");
            var idProduto = Console.ReadLine();

            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a marca do produto:");
            string marca = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade em estoque do produto:");
            int estoque = int.Parse(Console.ReadLine());

            //Instanciando um produto à partir da classe Produto
            Produto p = new Produto(); 

            // Atribuir as informações ao objeto produto
            p.Nome = nome;
            p.Marca = marca;
            p.Preco = preco;
            p.Estoque = estoque;
            p.IdProduto = idProduto;

            //Chama o método ExibirDados() da classe Produtos
            p.ExibirDados();

            //Calcular o desconto
            Console.WriteLine("Digite o desconto:");
            var desconto = decimal.Parse(Console.ReadLine());
            decimal valor = p.CalcularDesconto(desconto);
            Console.WriteLine($"Valor do produto com desconto aplicado: {valor}");



            


        }
    }
}
