using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria2
{
    public partial class Form2 : Form
    {

        public const string CONTA_CORRENTE = "conta_corrente";
        public const string CONTA_POUPANCA = "conta_poupanca";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoConta = "";

                if (rdContaCorrente.Checked)
                    tipoConta = CONTA_CORRENTE;
                if (rdContaPoupanca.Checked)
                    tipoConta = CONTA_POUPANCA;

                this.verificaDadosInseridos(tipoConta);

                //mandar salvar a conta em algum lugar
                MessageBox.Show("Tipo conta " + tipoConta + " Número: " + txtNumero.Text);
            }
            catch (Exception excecao) {
                MessageBox.Show(excecao.Message);
            }

        }

        private void verificaDadosInseridos(string tipoConta) {

            if (string.IsNullOrEmpty(tipoConta))
                throw new Exception("Por favor informe o tipo de conta desejado");

            if (string.IsNullOrEmpty(txtNumero.Text))
                throw new Exception("Por favor informe o número da conta");

        }

    }
}
