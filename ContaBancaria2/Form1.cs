﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            //adiciona as combos carregadas do arquivo a combobox
            this.adicionarContas();

            //importa os dados de um arquivo para a combobox no formulário
            this.importaDadosDeArquivo();

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
                MessageBox.Show("Por favor informe um valor inteiro para as operações");
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

                    conta.sacar(Convert.ToDouble(this.txtValor.Text));//validar o deposito dps

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
                MessageBox.Show("Por favor informe um valor inteiro para as operações");
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

        /*
         * Importa o texto de um arquivo txt para a textbox no formulário
         * 
         * 
         */
        private void importaDadosDeArquivo()
        {

            string nomeArquivo = "texto.txt";

            if (File.Exists(nomeArquivo))
            {

                Stream entrada = File.Open(nomeArquivo, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);

                string linha = leitor.ReadLine();
                while (linha != null)
                {

                    this.txtExportar.Text += (linha+"\r\n");
                    linha = leitor.ReadLine();

                }

                leitor.Close();
                entrada.Close();

            }
            else {
                MessageBox.Show("Arquivo "+ nomeArquivo + " não encontrado");
            }

        }

        private void gravarDadosEmArquivo() {

            try
            {
                string arquivo = "texto.txt";
                Stream saida;

                if (File.Exists(arquivo)){
                    saida = File.Open(arquivo, FileMode.Create);
                }
                else{
                    saida = File.Open(arquivo, FileMode.Append);
                }

                StreamWriter escritor = new StreamWriter(saida);

                escritor.Write(this.txtExportar.Text);

                escritor.Close();
                saida.Close();

                MessageBox.Show("gravado com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao gravar texto em arquivo "+e.Message);
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            this.gravarDadosEmArquivo();
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
