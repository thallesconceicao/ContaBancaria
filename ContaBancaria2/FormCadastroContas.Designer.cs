﻿namespace ContaBancaria2
{
    partial class FormCadastroContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdContaCorrente = new System.Windows.Forms.RadioButton();
            this.rdContaPoupanca = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo da conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(139, 82);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(85, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdContaCorrente
            // 
            this.rdContaCorrente.AutoSize = true;
            this.rdContaCorrente.Location = new System.Drawing.Point(139, 26);
            this.rdContaCorrente.Name = "rdContaCorrente";
            this.rdContaCorrente.Size = new System.Drawing.Size(65, 17);
            this.rdContaCorrente.TabIndex = 5;
            this.rdContaCorrente.TabStop = true;
            this.rdContaCorrente.Text = "Corrente";
            this.rdContaCorrente.UseVisualStyleBackColor = true;
            // 
            // rdContaPoupanca
            // 
            this.rdContaPoupanca.AutoSize = true;
            this.rdContaPoupanca.Location = new System.Drawing.Point(139, 49);
            this.rdContaPoupanca.Name = "rdContaPoupanca";
            this.rdContaPoupanca.Size = new System.Drawing.Size(74, 17);
            this.rdContaPoupanca.TabIndex = 6;
            this.rdContaPoupanca.TabStop = true;
            this.rdContaPoupanca.Text = "Poupança";
            this.rdContaPoupanca.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 190);
            this.Controls.Add(this.rdContaPoupanca);
            this.Controls.Add(this.rdContaCorrente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Cadastro de contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdContaCorrente;
        private System.Windows.Forms.RadioButton rdContaPoupanca;
    }
}