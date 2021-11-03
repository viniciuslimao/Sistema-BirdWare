using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Integrador_Construção_do_Sistema
{
    public partial class NewProdutos : Form
    {
        public NewProdutos()
        {
            InitializeComponent();
        }

        private void linkCadastrodeFornecedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CadastroFornecedor f = new CadastroFornecedor();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
