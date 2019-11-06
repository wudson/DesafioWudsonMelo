using System;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmPeriodoPromocao : Form
    {
        public FrmPeriodoPromocao()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            new FrmProdutosDaPromocaoComDesconto().ShowDialog();
        }

        private void btnCancelarCadastroProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
