﻿using System;
using System.Globalization;
using System.Windows.Forms;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Pedido.View
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            var produtos = new ProdutoController().BuscarTodosOsDados();

            lstProdutos.DisplayMember = "NomeProduto";

            foreach (Produto.Produto prod in produtos)
            {
                lstProdutos.Items.Add(prod);
            }
        }

        private void LstProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = this.lstProdutos.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;
            var produtoAdicionado = (Produto.Produto)lstProdutos.SelectedItems[0];
            txtProduto.Text = produtoAdicionado.NomeProduto;
            txtPreco.Text = produtoAdicionado.ValorVendaProduto.ToString(CultureInfo.InvariantCulture);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text)) return;
            var precoProduto = int.Parse(txtPreco.Text) * int.Parse(txtQuantidade.Text);
            dgvPedido.Rows.Add(txtProduto.Text, txtQuantidade.Text, precoProduto);
            txtPreco.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtQuantidade.Text = @"1";


            CalcularTotalAPagar();
        }

        private void CalcularTotalAPagar()
        {
            decimal total = 0;

            for (var i = 0; i < dgvPedido.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvPedido.Rows[i].Cells["preco"].Value);
            }

            txtTotalPedido.Text = total.ToString(CultureInfo.InvariantCulture);
        }

        private void BtnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedido.RowCount <= 0) return;
            dgvPedido.Rows.Clear();
            txtTotalPedido.Text = string.Empty;
            MessageBox.Show(@"Pedido efetuado com sucesso");
        }

        private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var resultado = MessageBox.Show(@"Deseja remover esse item do pedido?", @"Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;
            var indice = e.RowIndex;
            if (indice < 0) return;
            var linha = dgvPedido.Rows[indice];
            dgvPedido.Rows.Remove(linha);
            CalcularTotalAPagar();
        }

        private void FrmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnAdicionar_Click(sender, e);
                    break;
                case Keys.Enter:
                    BtnSalvarPedido_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
