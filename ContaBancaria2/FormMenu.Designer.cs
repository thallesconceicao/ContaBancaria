namespace ContaBancaria2
{
    partial class FormMenu
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
            this.btnCadastroContas = new System.Windows.Forms.Button();
            this.btnCaixaEletronico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroContas
            // 
            this.btnCadastroContas.Location = new System.Drawing.Point(29, 76);
            this.btnCadastroContas.Name = "btnCadastroContas";
            this.btnCadastroContas.Size = new System.Drawing.Size(93, 66);
            this.btnCadastroContas.TabIndex = 0;
            this.btnCadastroContas.Text = "Cadastro de Contas";
            this.btnCadastroContas.UseVisualStyleBackColor = true;
            this.btnCadastroContas.Click += new System.EventHandler(this.btnCadastroContas_Click);
            // 
            // btnCaixaEletronico
            // 
            this.btnCaixaEletronico.Location = new System.Drawing.Point(159, 76);
            this.btnCaixaEletronico.Name = "btnCaixaEletronico";
            this.btnCaixaEletronico.Size = new System.Drawing.Size(93, 66);
            this.btnCaixaEletronico.TabIndex = 1;
            this.btnCaixaEletronico.Text = "Caixa Eletrônico";
            this.btnCaixaEletronico.UseVisualStyleBackColor = true;
            this.btnCaixaEletronico.Click += new System.EventHandler(this.btnCaixaEletronico_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 223);
            this.Controls.Add(this.btnCaixaEletronico);
            this.Controls.Add(this.btnCadastroContas);
            this.Name = "FormMenu";
            this.Text = "Banco Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroContas;
        private System.Windows.Forms.Button btnCaixaEletronico;
    }
}