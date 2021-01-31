using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        //DEPOIS QUE ESSA EXCEÇÃO FOI LANÇADA NÃO É MAIS NECESSÁRIO
        //EXECUTAR NOVAMENTE
        public double Saldo { get;  }
        //COMO NÃO FOI COLOCADO O SETTER ELE 
        //AUTOMATICAMENTE COLOCA ESSE ATRIBUTO COMO READONLY
        public double ValorSaque { get; }

        //CONTRUTOR QUE LANÇA A EXCESSÃO, SEM PRECISAR PERSONALIZAR A MENSAGEM
        public SaldoInsuficienteException()
        {

        }

        //
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de" + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;


        }

        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {

        }


    }
}
