using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBanco
{
    class Corrente : Conta
    {
        // Atributos
        private double valorTaxa;

        // Construtor
        public Corrente() { }
        public Corrente(string nome, string numero, double saldo, double valorTaxa)
        {
            this.nome = nome;
            this.numero = numero;
            this.SetSaldo(saldo);
            this.valorTaxa = valorTaxa;
        }

        // Sets e Gets
        public void SetValorTaxa(double valorTaxa)
        {
            this.valorTaxa = valorTaxa;
        }

        public double GetValorTaxa()
        {
            return valorTaxa;
        }

        public void sacaValor(double valor)
        {
            if (valor <= GetSaldo())
            {
                valor -= GetSaldo();
                valor -= valorTaxa;
            }
            else
            {
                Console.WriteLine("Não exite valor disponvel para Saque. ");
                Console.ReadLine();
            }
        }
    }
}
