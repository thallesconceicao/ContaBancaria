using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2.Controller
{
    class ContaController
    {

        public List<Conta> listarContas() {

            return Conta.listarContas();

        }

    }
}
