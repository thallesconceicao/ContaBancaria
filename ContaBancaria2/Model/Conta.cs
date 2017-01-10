using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaBancaria2.Dao;

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

        /*
         * Lista todas as contas cadastradas
         */
        public static List<Conta> listarContas() {

            List<Dictionary<string, string>> listaContas = new List<Dictionary<string, string>>();

            TxtDao txtDao = new TxtDao("contas.txt");

            listaContas = txtDao.listar();

            return formatarListagemContas(listaContas);

        }

        /*
         * Formata os dados vindos do arquivo no padrão List<Conta>
         * para ser retornado a controller
         */
        private static List<Conta> formatarListagemContas(List<Dictionary<string, string>> listaContas)
        {

            List<Conta> listaFormatada = new List<Conta>();

            foreach (Dictionary<string, string> conta in listaContas)
            {

                Conta cont;
                int numeroDaConta = Convert.ToInt32(conta["numero"]);
                double saldo = Convert.ToDouble(conta["saldo"]);

                switch (conta["tipo"])
                {
                    case "corrente":
                        cont = new ContaCorrente(numeroDaConta, saldo);
                        break;
                    case "poupanca":
                        cont = new ContaPoupanca(numeroDaConta, saldo);
                        break;
                    default: throw new Exception("Tipo de conta desconhecido");
                }

                listaFormatada.Add(cont);

            }

            return listaFormatada;

        }

    }
}
