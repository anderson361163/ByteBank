﻿using _09_ByteBank;
using System;


namespace _08_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; set; }

        public static int TotalContasCriadas { get; private set; }

        // -----------------------------------

        public int Numero { get; }       
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
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numeroConta));
            }


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

        public void Sacar(double valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }

            Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contadestino)
        {
            if (Saldo < valor)
            {
                //return false;
            }


            Saldo -= valor;
            contadestino.Depositar(valor);

        }
    
    }
}