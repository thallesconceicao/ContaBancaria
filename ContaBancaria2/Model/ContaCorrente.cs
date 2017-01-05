using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class ContaCorrente : Conta
    {

        public ContaCorrente(int n, double s)
        {

            this.numero = n;
            this. saldo = s;

        }

        public override string ToString()
        {
            return "Conta Corrente: nº" + numero;
        }

    }
}
