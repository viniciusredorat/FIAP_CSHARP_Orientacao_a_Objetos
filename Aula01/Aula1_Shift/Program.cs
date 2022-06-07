using System;

namespace Aula1_Shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando (instanciando) objetos à partir da classe Cliente
            
            Cliente cliente = new Cliente();

            cliente.Nome = "Cleber"; //set
            cliente.Idade = 25; //set
            cliente.Altura = 1.90F;

            Console.WriteLine($"Idade {cliente.Idade}");

            Cliente cliente2 = new Cliente();

            cliente2.Nome = "Vanessa";
            cliente2.Idade = 20;
            cliente2.Altura = 1.67F;

            // Criando o objeto a partir de Endereço

            Endereco end = new Endereco();

            end.Logradouro = "Av São João";
            end.Cep = "12345-678";
            end.Cidade = "São Paulo";
            end.Numero = "228";


            //Atribuindo um endereço a um cliente

            cliente2.Endereco = end;

            // Imprimir no console os dados do cliente

            Console.WriteLine($"Nome do cliente: {cliente2.Nome}, Idade {cliente2.Idade}" +
                $" Cidade : {cliente2.Endereco.Cidade}"); //Get

        }
    }
}
