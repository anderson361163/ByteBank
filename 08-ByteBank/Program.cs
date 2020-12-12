using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Total de Contas criadas: " + ContaCorrente.TotalContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine("Agência da conta: " + conta.Agencia);
            Console.WriteLine("Número da conta: " + conta.Numero);
            Console.WriteLine("Total de Contas criadas: " + ContaCorrente.TotalContasCriadas);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745840);

            Console.WriteLine("Total de Contas criadas: " + ContaCorrente.TotalContasCriadas);

            Console.ReadLine();

        }
    }
}
