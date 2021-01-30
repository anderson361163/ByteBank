using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._5_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            M1();
            Console.ReadLine();
        }

        static void M1()
        {
            try
            {
                M2();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção capturada em M1");
            }
        }

        static void M2()
        {
            try
            {
                LancaExcecao();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção capturada em M2");
            }
        }

        static void LancaExcecao()
        {
            int divisor = 0;
            int resultado = 1 / divisor;
        }
    }
}
