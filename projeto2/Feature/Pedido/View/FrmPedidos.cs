using System;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Controller;

namespace projeto2.Feature.Pedido.View
{
    public partial class FrmPedidos : Form
    {
        private readonly PedidoController _pedidoController;

        public FrmPedidos()
        {
            InitializeComponent();
            _pedidoController = new PedidoController();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            new FrmNovoPedido().ShowDialog();
            AtualizarGridPedidos();
        }

        private void BtnListar_Click(object sender, EventArgs e) => AtualizarGridPedidos();

        private void FrmPedidos_Load(object sender, EventArgs e) => AtualizarGridPedidos();

        private void AtualizarGridPedidos()
        {
            dgvPedidos.DataSource = _pedidoController.BuscarTodosOsDados();
            if (dgvPedidos.CurrentRow != null) dgvPedidos.CurrentRow.Selected = false;

            ModificarEnabledDosBotoes(false);
        }

        private void ModificarEnabledDosBotoes(bool enabled)
        {
            btnExcluir.Enabled = enabled;
            btnEditar.Enabled = enabled;
        }

        private void DgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var pedido =
                _pedidoController.BuscarProdutosPedido(
                    int.Parse(dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString()));

            new FrmItensPedido(pedido).ShowDialog();
            AtualizarGridPedidos();
        }

        private void DgvPedidos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ModificarEnabledDosBotoes(true);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!btnEditar.Enabled) return;

            //var pedido =
            //    _pedidoController.BuscarDado(
            //        int.Parse(dgvPedidos.CurrentRow?.Cells[0].Value.ToString() ?? "-1"));

            AtualizarGridPedidos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

            var resultado = MessageBox.Show(@"Deseja cancelar esse pedido?", @"Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            if (_pedidoController.ExcluirDado(int.Parse(dgvPedidos.CurrentRow?.Cells[0].Value.ToString() ?? "-1")))
                AtualizarGridPedidos();
        }

        private void FrmPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnCadastrar_Click(sender, e);
                    break;
                case Keys.F5:
                    BtnListar_Click(sender, e);
                    break;
                case Keys.F4:
                    BtnEditar_Click(sender, e);
                    break;
                case Keys.Delete:
                    BtnExcluir_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
