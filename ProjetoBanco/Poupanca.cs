using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBanco
{
    class Poupanca : Conta
    {
        // Atributos
        private double PercLucro;

        // Construtores
        public Poupanca() { }
        public Poupanca(string nome, string numero, double saldo, double PercLucro)
        {
            this.nome = nome;
            this.numero = numero;
            this.SetSaldo(saldo);
            this.PercLucro = PercLucro;
        }

        // Sets e Gets
        public void SetPercLucro(double PercLucro)
        {
            this.PercLucro = PercLucro;
        }
        public double GetPercLucro()
        {
            return PercLucro;
        }

        // Métodos
        public void depositaL(double valor)
        {
            
        }
    }
}
