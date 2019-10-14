using System;
using System.Windows.Forms;
using projeto2.novonomedepois.Cliente.View;
using projeto2.novonomedepois.Produto.View;

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
    }
}
