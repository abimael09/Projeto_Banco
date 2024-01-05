using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBanco
{
    class Conta
    {
        // Atributos
        public Cliente titular;
        public string numero;
        private double saldo;

        // Sets e Gets
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }

        // Cosntrutor
        public Conta() { }
        public Conta(string nome, string numero, double saldo)
        {
            this.nome = nome;
            this.numero = numero;
            this.saldo = saldo;
        }

        // Métodos
        public void deposita(double valor)
        {
            saldo += valor;
        }

        public void saca(double valor)
        {
            if (valor <= saldo)
            {
                valor -= saldo;   
            }
            else
            {
                Console.WriteLine("Não exite valor disponvel para Saque. ");
                Console.ReadLine();
            }
        }

        public double Transfere(double valor, Conta contaDestino)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                contaDestino.saldo += valor;
            }
            return contaDestino.saldo;
        }
    }
}
