using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
          //Cliente gabriela = new Cliente();

          //gabriela.nome = "Gabriela";
          //gabriela.profissao = "Desenvolvimento C#";
          //gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();

          //conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            conta.titular.nome = "Gabriela Costa";
            conta.titular.profissao = "Desenvolvimento C#";
            conta.titular.cpf = "434.562.878-20";

            //Console.WriteLine("O nome da titular da conta (acessando o objeto Cliente): {0}", gabriela.nome);
            Console.WriteLine("Nome da titular da conta (acessando o objeto Cliente dentro ContaCorrente):", conta.titular.nome);

            Console.WriteLine("Pressione a tecla enter para finalizar o programa . . .");
            Console.ReadLine();


        }
    }
}
