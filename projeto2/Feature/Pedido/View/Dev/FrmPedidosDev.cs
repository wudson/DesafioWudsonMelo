using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Controller;

namespace projeto2.Feature.Pedido.View.Dev
{
    public partial class FrmPedidosDev : XtraForm
    {
        private readonly PedidoController _pedidoController;

        public FrmPedidosDev(PedidoController controller)
        {
            InitializeComponent();
            _pedidoController = controller;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            _pedidoController.AbrirTelaDeNovoPedido();
            AtualizarGridPedidos();
        }

        private void FrmPedidos_Load(object sender, EventArgs e) => AtualizarGridPedidos();

        private void AtualizarGridPedidos()
        {
            dgvPedidos.DataSource = _pedidoController.BuscarTodosOsDados();
            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnVerProdutos.Enabled = enabled;
        }

        private void BtnVerProdutos_Click(object sender, EventArgs e)
        {
            var pedido =
                _pedidoController.BuscarProdutosPedido(Convert.ToInt32(gvPedidos.GetFocusedRowCellValue("IdPedido")));

            _pedidoController.AbrirTelaParaExibirItensDoPedido(pedido);
            AtualizarGridPedidos();
        }

        private void FrmPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnCadastrar_Click(sender, e);
                    break;
                case Keys.I:
                    BtnVerProdutos_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void GvPedidos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            ModificarEnabledDosBotoes(true);
        }
    }
}