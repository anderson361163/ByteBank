using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._3_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();

            contaDaCamila.titular.nome = "Camila";

            Console.WriteLine("O nome do titular da conta é: {0}", contaDaCamila.titular.nome);

            Console.WriteLine("Pressione enter para finalizar o programa . . .");
            Console.ReadLine();

        }
    }
}
