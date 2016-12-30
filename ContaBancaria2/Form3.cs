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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCadastroContas_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btnCaixaEletronico_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
