using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        private int numero_Agencia;
        public int Numero_Agencia
        {
            get { return this.numero_Agencia; }
            set
            {
                if (value < 0) { return; }
                else { this.numero_Agencia = value; }
            }
        }
        //private string conta;

        public string Conta { get; set; }
        private double saldo = 100;
        public Cliente Titular { get; set; };



        public void Depositar(double valor)
        {
            saldo += valor;

        }

        /*public void Sacar(double valor)
        {
            if (valor <= this.saldo)
                this.saldo -= valor;
            else
                Console.WriteLine("Saque não autorizado pois excede o limite disponível para saque.");
        }*/

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
                return false;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }

        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void ExibirInfoConta()
        {
            Console.WriteLine($"Conta:            {conta}");
            Console.WriteLine($"Agência:          {numero_Agencia}");
            Console.WriteLine($"Titular:          {titular}");
            Console.WriteLine($"Saldo atualizado: {saldo}\n\n");
        }

    }
}
