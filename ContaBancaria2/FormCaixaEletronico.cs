using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ContaBancaria2.Controller;

namespace ContaBancaria2
{
    public partial class FormCaixaEletronico : Form
    {
        public FormCaixaEletronico()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            //adiciona as combos carregadas do arquivo a combobox
            this.adicionarContas();

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = (Conta)this.cmbConta.SelectedItem;//validar se uma conta foi selecionada

                if (true)
                {

                    conta.depositar(Convert.ToDouble(this.txtValor.Text));//validar o deposito dps

                    this.exibirSaldoAtualizado(conta);
                    MessageBox.Show("Depósito realizado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Por favor selecione a conta bancária!");
                }
            }
            catch (FormatException excecao) {
                MessageBox.Show("Por favor informe um valor inteiro para as operações" + excecao.Message);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = (Conta)this.cmbConta.SelectedItem;

                if (true)//validar se uma conta foi selecionada
                {

                    conta.sacar(Convert.ToDouble(this.txtValor.Text));//validar o saque dps

                    this.exibirSaldoAtualizado(conta);
                    MessageBox.Show("Saque realizado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Por favor selecione a conta bancária!");
                }
            }
            catch (FormatException excecao)
            {
                MessageBox.Show("Por favor informe um valor inteiro para as operações" + excecao.Message);
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
        }

        private void contaSelecionada(object sender, EventArgs e) {

            Conta conta = (Conta)this.cmbConta.SelectedItem;

            this.exibirSaldoAtualizado(conta);

        }

        private void exibirSaldoAtualizado(Conta conta) {
            this.txtSaldo.Text = Convert.ToString(conta.obterSaldo());
        }

        private void adicionarContas() {

            ContaController controladora = new ContaController();
            List<Conta> listaContasCombo = controladora.listarContas();

            foreach (Conta conta in listaContasCombo)
            {
                cmbConta.Items.Add(conta);
            }

        }

    }
}
