﻿using System;


namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;
        private int _agencia;

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
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

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