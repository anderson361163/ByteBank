
namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 100;

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            
            this.saldo = valor;
            
        }


        public double GetSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contadestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }


            this.saldo -= valor;
            contadestino.Depositar(valor);
            return true;

        }
    }
}