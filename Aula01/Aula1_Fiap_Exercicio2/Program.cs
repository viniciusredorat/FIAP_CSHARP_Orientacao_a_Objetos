using System;
using Aula1_Fiap_Exercicio2.Models;


namespace Aula1_Fiap_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Projeto de sistema para revenda de veículos


            //Leitura dos dados da cor
            Console.WriteLine("Digite o nome da cor:");
            string nomeCor = Console.ReadLine();

            Console.WriteLine("Digite o R da cor com valores de 0 a 255");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o G da cor com valores de 0 a 255");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o B da cor com valores de 0 a 255");
            int b = int.Parse(Console.ReadLine());

            // Instanciando uma Cor
            Cor cor = new Cor();

            cor.Nome = nomeCor;
            cor.R = r;
            cor.G = g;
            cor.B = b;

            Console.WriteLine("Digite o fabricante do carro:");
            string fabricante = Console.ReadLine();

            Console.WriteLine("Digite o Ano do carro:");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o modelo do carro:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Digite a placa do carro:");
            string placa = Console.ReadLine();

            Console.WriteLine("Informe se o carro tem ar condiconado (true/false):");
            bool arCondicionado = bool.Parse(Console.ReadLine());

            Console.WriteLine("Informe se o carro tem estepe (true/false):");
            bool estepe = bool.Parse(Console.ReadLine());


            Carro carro = new Carro();

            carro.Ano = ano;
            carro.Placa = placa;
            carro.Modelo = modelo;
            carro.Fabricante = fabricante;
            carro.ArCondicionado = arCondicionado;
            carro.Cor = cor;
            carro.Estepe = estepe;

            //Exibindo os valores

            Console.WriteLine($"Modelo: {carro.Modelo}\nAno: {carro.Ano}\nPlaca: {carro.Placa}\nFabricante: {carro.Fabricante}" +
                $"\nAr Condicionado: {carro.ArCondicionado} \nEstepe: {carro.Estepe} \nCor: {carro.Cor.Nome}");

            // Instanciar um avião
            Console.WriteLine("Digite o fabricante do Avião: ");
            string modeloJato = Console.ReadLine();

            Console.WriteLine("Digite o ano do avião:");
            int anoJato = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do fabricante do jato:");
            string fabricanteJato = Console.ReadLine();

            Console.WriteLine("Digite o valor do avião:");
            decimal valorJato = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o prefixo do avião:");
            string prefixo = Console.ReadLine();

            Console.WriteLine("Digite as horas-voo do avião:");
            double horasVoo = double.Parse(Console.ReadLine());

            Aviao jato = new Aviao();

            jato.Modelo = modeloJato;
            jato.Ano = anoJato;
            jato.Valor = valorJato;
            jato.Prefixo = prefixo;
            jato.HorasVoo = horasVoo;
            jato.Fabricante = fabricanteJato;

            Console.WriteLine($"Modelo: {jato.Modelo}\nAno: {jato.Ano}\nPrefixo: {jato.Prefixo}\nFabricante: {jato.Fabricante}" +
                $"Horas-voo: {jato.HorasVoo} \nValor: {jato.Valor}");

        }
    }
}
