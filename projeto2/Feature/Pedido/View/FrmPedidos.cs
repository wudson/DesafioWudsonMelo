﻿using System;
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

        private void BtnListar_Click(object sender, EventArgs e)
        {
            AtualizarGridPedidos();
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

        private void DgvPedidos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnExcluir.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!btnEditar.Enabled) return;

            var idPedidoLinhaAtual = int.Parse(dgvPedidos.CurrentRow?.Cells[0].Value.ToString() ?? "0");
            var produto = new PedidoController().BuscarDado(idPedidoLinhaAtual);

            new FrmNovoPedido().ShowDialog();
            AtualizarGridPedidos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!btnExcluir.Enabled) return;

            var resultado = MessageBox.Show(@"Deseja cancelar esse pedido?", @"Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            var idPedidoLinhaAtual = int.Parse(dgvPedidos.CurrentRow?.Cells[0].Value.ToString() ?? "0");
            if (new PedidoController().ExcluirDado(idPedidoLinhaAtual))
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
