using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência (objeto - após a atribuição): " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor (inteiro - variavel): " + (idade == idadeMaisUmaVez));

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine("Igualdade por tipo de referência 2 (objeto - após a atribuição): " + (contaDaGabriela == contaDaGabrielaCosta));

            Console.WriteLine("Saldo da Gabriela Costa: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Pressione enter para finalizar o programa . . .");
            Console.ReadLine();

        }
    }
}
