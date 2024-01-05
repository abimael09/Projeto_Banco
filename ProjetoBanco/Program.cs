using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando
            Cliente cli1 = new Cliente();
            cli1.nome = "Maria";
            cli1.cpf = "1234";

            Conta conta1 = new Conta();
            conta1.numero = "111";
            conta1.SetSaldo(300);
            conta1.deposita(500);
            conta1.titular = cli1; // Composição

            Console.WriteLine("Número: "+conta1.numero+" Nome: "+conta1.titular.nome+" Saldo = "+conta1.GetSaldo()+"R$.");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Corrente c1 = new Corrente();
            //c1.nome = "Sandro";
            c1.SetSaldo(200);
            Corrente c2 = new Corrente();
            c2.Transfere(100, c2);
            
            Console.ReadKey();
            
        }
    }
}
