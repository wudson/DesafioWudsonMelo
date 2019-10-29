using System.Collections.Generic;
using System.Windows.Forms;

namespace projeto2.Feature.Pedido.View
{
    public partial class FrmItensPedido : Form
    {
        private readonly IList<Produto.Produto> _produtosPedido;

        public FrmItensPedido(IList<Produto.Produto> produtosPedido)
        {
            InitializeComponent();
            _produtosPedido = produtosPedido;
        }

        public FrmItensPedido()
        {
            InitializeComponent();
        }

        private void FrmItensPedido_Load(object sender, System.EventArgs e)
        {
            dgvItensPedido.DataSource = _produtosPedido;
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FrmItensPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BtnOk_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
