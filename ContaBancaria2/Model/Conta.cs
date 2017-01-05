using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    abstract class Conta
    {
        protected int numero;
        protected double saldo;

        /*public Conta(int n) {

            numero = n;
            saldo = 0;

        }*/

        public override string ToString()
        {
            return "Conta: nº" + numero;
        }

        public int obterNumeroConta() {

            return numero;

        }

        public void sacar(double valor)
        {

            if (valor < 1)
            {
                throw new Exception("Por favor informe um valor positivo para o saque.");
            }
            if (valor > saldo)
            {
                throw new Exception("O valor a ser sacado não deve ser maior que o saldo.");
            }

            saldo -= valor;

        }

        public void depositar(double valor)
        {
            if (valor < 1)
            {
                throw new Exception("Por favor informe um valor positivo para o depósito.");
            }

            saldo += valor;

        }

        public double obterSaldo() {

            return this.saldo;

        }

    }
}
