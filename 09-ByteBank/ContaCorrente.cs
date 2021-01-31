using _09_ByteBank;
using System;


namespace _09_ByteBank
{
    public class ContaCorrente
    {
        //campo readonly(acho)
        public static int TaxaOperacao; //{ get; set; }

        public static int TotalContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermetidos { get; private set; }
        public int ContadorTransferenciasNaoPermetidos { get; private set; }
        // -----------------------------------

        public int Numero { get; }
        public int Agencia { get; }


        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }



        // -----------------------------------
        /*
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        */
        // -----------------------------------

        //MÉTODO CONSTRUTOR
        public ContaCorrente(int agencia, int numero)
        {

            /*
             * Fortemente recomendado a 
             */

            /* Nameof é um operador do CSharp que
             * converte conteudo de variaveis em string
             * isso permite que as mensagens de erro 
             * abaixo sigam a estrutura do código mesmo
             * com mudanças
             */
            // nameof()


            if (agencia <= 0)
            {
                //PRIMEIRO PARAMETRO É A MENSAGEM DO ERRO E O SEGUNDO É RAIZ DO PROBLEMA
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }


            if (numero <= 0)
            {
                //PRIMEIRO PARAMETRO É A MENSAGEM DO ERRO E O SEGUNDO É RAIZ DO PROBLEMA
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }


            Agencia = agencia;
            Numero = numero;

            //A CADA NOVA INSTANCIA, SERÁ INCREMENTADO MAIS 1
            ContaCorrente.TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;

        }

        //MÉTODO DESTRUTOR
        ~ContaCorrente()
        {
            Console.WriteLine("Objeto da conta {0}-{1} foi destruído com sucesso");
        }


        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                //nameof converte o nome da variavel para string 
                throw new ArgumentException("Valor inválido para o saque.",nameof(valor));
            }


            if (_saldo < valor)
            {
                ContadorSaquesNaoPermetidos++;
                // throw new SaldoInsuficienteException("Saldo insuficiente para o saque no valor de " + valor);
                throw new SaldoInsuficienteException("" + valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contadestino)
        {

            if (valor < 0)
            {
                //nameof converte o nome da variavel para string 
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            /*
            if (Saldo < valor)
            {


                //return false;
            }
            */

            //comenta várias linhas simultaneamente
            //ctrl+k+c

            //throw sozinho precisa de parametro para lançar a excessão
            //em um catch pode ser lançado a exceção 


            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex) 
            {
                ContadorTransferenciasNaoPermetidos++;

                //CASO TIVESSE MANTIDO O THROW FAZENDO REFERENCIA AO OBJETO DO CATH
                //SERIA PERDIDA A PILHA DO CATCH DO SACAR (A CLR IRIA SUBSTITUIR SEU VALOR)
                throw;
                //
                //MOSTRA TODA PILHA DE ERRO ATÉ AGORA
                //throw;
            }

            //Saldo -= valor;
            contadestino.Depositar(valor);
            //return true;
        }
    
    }
}