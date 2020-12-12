using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta2 = new ContaCorrente(867, 86712540);

            conta2.Numero = 86712540;
            //conta.Agencia = -10;

            Console.WriteLine(conta2.Agencia);
            Console.WriteLine(conta2.Numero);

            conta2.Titular = new Cliente();

            conta2.Titular.nome = "Anderson";
            conta2.Sacar(100);

            Console.WriteLine("A conta de {0} tem como saldo {1}!", conta2.Titular.nome, conta2.Saldo);
            Console.ReadLine();

        }
    }
}
