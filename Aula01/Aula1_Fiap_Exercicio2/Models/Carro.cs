using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1_Fiap_Exercicio2.Models
{
    class Carro
    {
        public string Modelo { get; set; }

        public string Fabricante { get; set; }

        public int Ano { get; set; }

        public Cor Cor { get; set; }

        public string Placa { get; set; }

        public decimal Valor { get; set; }

        public bool ArCondicionado { get; set; }

        public bool Estepe { get; set; }
    }
}
