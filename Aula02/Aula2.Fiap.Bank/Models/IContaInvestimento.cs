using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Fiap.Bank.Models
{
    interface IContaInvestimento
    {
        decimal CalcularRetornoInvestimento(decimal taxa);
    }
}
