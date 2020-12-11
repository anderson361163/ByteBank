
namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
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