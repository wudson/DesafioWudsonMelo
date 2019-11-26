﻿using System;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Controller;

namespace projeto2.Feature.Pedido.View.WinForms
{
    public partial class FrmPedidos : Form
    {
        private readonly PedidoController _pedidoController;

        public FrmPedidos(PedidoController controller)
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

            _pedidoController.AbrirTelaParaExibirItensDoPedido(pedido);
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

            AtualizarGridPedidos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

            AtualizarGridPedidos();
        }

        private void FrmPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnCadastrar_Click(sender, e);
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

        private void DgvPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) => 
            e.Value = Propriedade.BuscarPropriedadeComPonto(dgvPedidos, e);
    }
}