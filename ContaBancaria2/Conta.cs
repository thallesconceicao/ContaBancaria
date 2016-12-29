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
        protected int saldo;

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

        public abstract void sacar(int valor);

        public abstract void depositar(int valor);

        public int obterSaldo() {

            return this.saldo;

        }

    }
}
