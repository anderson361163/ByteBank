using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Saldo da conta do Bruno: " + contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine("Bruno tem saldo suficiente para o saque: " + resultadoSaque);

            Console.WriteLine("Saldo na conta de Bruno: " + contaDoBruno.saldo);

            contaDoBruno.Depositar(500);

            Console.WriteLine("Saldo na conta de Bruno: " + contaDoBruno.saldo);

            Console.WriteLine("------------------------");

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("(Antes) O saldo do Bruno é de {0} \n O saldo da Gabriela é {1}", contaDoBruno.saldo, contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("(Depois) O saldo do Bruno é de {0}\n O saldo da Gabriela é {1}", contaDoBruno.saldo, contaDaGabriela.saldo);

            Console.WriteLine("A transação foi realizada com sucesso: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
