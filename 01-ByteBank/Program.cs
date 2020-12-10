using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;
            contaGabriela.saldo = 100;


            Console.WriteLine("Titular: " + contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Número: " + contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            
            //-------------------------------------------------------
            Console.WriteLine("")
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            primeiraContaCorrente.saldo = 200;
            Console.WriteLine(primeiraContaCorrente.saldo);

            primeiraContaCorrente.saldo += 100;
            Console.WriteLine(primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.saldo = 50;

            Console.WriteLine("Exercício 1: primeira conta tem " + primeiraContaCorrente.saldo);
            Console.WriteLine("Exercício 1: segunda conta tem " + segundaContaCorrente.saldo);


            //Console.WriteLine("Saldo: " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
