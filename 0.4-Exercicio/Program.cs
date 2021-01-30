using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._4_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo_1();
            Console.WriteLine("Pressione Enter para finalizar!");
            Console.ReadLine();

        }
        private static void Metodo_1()
        {
            Console.WriteLine("M1: Início");

            try
            {
                Metodo_2();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("catch(DivideByZeroException)");
            }
            Console.WriteLine("M1: Fim");
        }

        private static void Metodo_2()
        {
            Console.WriteLine("M2: Início");
            Metodo_3();
            Console.WriteLine("M2: Fim");
        }

        private static void Metodo_3()
        {
            Console.WriteLine("M3: Início");

            int numero = 10;
            int divisor = 0;
            int resultado = numero / divisor;

            Console.WriteLine("M3: Fim");
        }
    }
}
