using System;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Controller;

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
            AtualizarGridPedidos();
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

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            AtualizarGridPedidos();
        }

        private void AtualizarGridPedidos()
        {

            var pedidos = new PedidoController().BuscarTodosOsDados();
            dgvPedidos.DataSource = pedidos;
            if (dgvPedidos.CurrentRow != null) dgvPedidos.CurrentRow.Selected = false;

            DesativarBotoes();
        }

        private void DesativarBotoes()
        {
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void DgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var idPedidoLinhaAtual = int.Parse(dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
            var pedido = new PedidoController().BuscarProdutosPedido(idPedidoLinhaAtual);

            new FrmItensPedido(pedido).ShowDialog();
            AtualizarGridPedidos();
        }
    }
}
