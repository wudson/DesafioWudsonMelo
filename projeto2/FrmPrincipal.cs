using System;
using System.Windows.Forms;
using projeto2.Feature.Cliente.View;
using projeto2.Feature.Produto.View;

namespace projeto2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            new FrmProdutos().ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            new FrmClientes().ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Hide();
            var login = new FrmEntrar();
            login.Closed += (s, args) => Close();
            login.Show();
        }
    }
}