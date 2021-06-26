using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancária
{
    class Conta
    {
        public string NumeroConta { get; set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; private set; }

        public Conta() { }

        public Conta(string conta, string titular, double saldo)
        {
            this.NumeroConta = conta;
            this.TitularConta = titular;
            this.SaldoConta = saldo;
        }

        public string InserirConta()
        {
            return NumeroConta;
        }

        public double Deposito(double valor)
        {
            return SaldoConta = SaldoConta + valor;
        }

        public double Saque(double valor)
        {
            double saldoAtual = SaldoConta - valor - 5.00;
            if (saldoAtual <= 0)
            {
                Console.WriteLine("Saque não permitido");
                return SaldoConta;
            }
            else
                return SaldoConta = SaldoConta - valor - 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta 
                + ", Titular: " + TitularConta 
                + ", Saldo: R$" + SaldoConta;
        }
    }
}
