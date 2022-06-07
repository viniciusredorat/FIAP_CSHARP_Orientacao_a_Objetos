using System;


namespace Aula2.Fiap.Bank.Exceptions
{
    class SaldoInsuficienteException : Exception
    {
        //Construtor que recebe mensagem

        public SaldoInsuficienteException(string msg) : base(msg)
        {

        }

    }
}
