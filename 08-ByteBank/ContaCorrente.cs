﻿using System;


namespace _08_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; set; }

        public static int TotalContasCriadas { get; private set; }

        // -----------------------------------

        public int Numero { get; set; }       
        private int _agencia;

        private double _saldo = 100;

        // -----------------------------------
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

        //MÉTODO CONSTRUTOR
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalContasCriadas;
            
            //A CADA NOVA INSTANCIA, SERÁ INCREMENTADO MAIS 1
            ContaCorrente.TotalContasCriadas++;


        }

        //MÉTODO DESTRUTOR
        ~ContaCorrente()
        {
            Console.WriteLine("Objeto da conta {0}-{1} foi destruído com sucesso");
        }


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
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contadestino)
        {
            if (Saldo < valor)
            {
                return false;
            }


            Saldo -= valor;
            contadestino.Depositar(valor);
            return true;

        }
    
    }
}