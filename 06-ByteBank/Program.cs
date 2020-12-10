using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();

            /*Ele está alterando diretamente o atributo
             *Com o atributo privado ele
             */
            //conta.saldo = -10;

            Console.WriteLine("O seu saldo é de {0}", conta.ObterSaldo().ToString("C"));

            Console.WriteLine("Pressione enter para finalizar o programa . . .");
            Console.ReadLine();


        }
    }
}
