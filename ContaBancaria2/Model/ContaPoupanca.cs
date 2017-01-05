using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class ContaPoupanca : Conta
    {

        public ContaPoupanca(int n, double s)
        {

            this.numero = n;
            this.saldo = s;

        }

        public override string ToString()
        {
            return "Conta Poupanca: nº" + numero;
        }

    }
}
