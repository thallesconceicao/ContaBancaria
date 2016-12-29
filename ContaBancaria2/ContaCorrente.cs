using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class ContaCorrente : Conta
    {

        public ContaCorrente(int n)
        {

            numero = n;
            saldo = 0;

        }

        public override string ToString()
        {
            return "Conta Corrente: nº" + numero;
        }

        public override void sacar(int valor)
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

        public override void depositar(int valor)
        {
            if (valor < 1)
            {
                throw new Exception("Por favor informe um valor positivo para o depósito.");
            }

            saldo += valor;

        }

    }
}
