using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 4578420);

                conta1.Depositar(50);
                Console.WriteLine(conta1.Saldo);
                conta1.Sacar(500);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message); //MESSAGE É UM MÉTODO PRIVADO
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Metodo();

            /*
              Console.WriteLine("Total de Contas criadas: " + ContaCorrente.TotalContasCriadas);

              ContaCorrente conta = new ContaCorrente(867, 86712540);




              Console.WriteLine("Agência da conta: " + conta.Agencia);
              Console.WriteLine("Número da conta: " + conta.Numero);
              Console.WriteLine("Total de Contas criadas: " + ContaCorrente.TotalContasCriadas);

              ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745840);

              Console.WriteLine("Total de Contas criadas: " + ContaCorrente.TotalContasCriadas);


            */
            Console.ReadLine();
        }
    }
}
