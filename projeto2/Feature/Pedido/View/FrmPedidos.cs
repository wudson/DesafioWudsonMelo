using System;
using System.Windows.Forms;

namespace projeto2.Feature.Pedido.View
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            new FrmNovoPedido().ShowDialog();
        }

        private void FrmPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnCadastrar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
