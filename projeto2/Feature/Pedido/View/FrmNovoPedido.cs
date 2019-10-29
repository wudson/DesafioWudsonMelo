using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using projeto2.Feature.Pedido.Controller;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Pedido.View
{
    public partial class FrmNovoPedido : Form
    {
        public FrmNovoPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            var produtos = new ProdutoController().BuscarTodosOsDados();

            lstProdutos.DisplayMember = "NomeProduto";

            foreach (var prod in produtos)
            {
                lstProdutos.Items.Add(prod);
            }
        }

        private void LstProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = lstProdutos.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            var produtoAdicionado = (Produto.Produto)lstProdutos.SelectedItems[0];
            txtProduto.Text = produtoAdicionado.NomeProduto;
            txtIdProduto.Text = produtoAdicionado.IdProduto.ToString();
            txtPreco.Text = produtoAdicionado.ValorVendaProduto.ToString(CultureInfo.InvariantCulture);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text)) return;

            var precoProduto = int.Parse(txtPreco.Text) * int.Parse(txtQuantidade.Text);
            dgvPedido.Rows.Add(txtIdProduto.Text, txtProduto.Text, txtQuantidade.Text, precoProduto);
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

            var pedido = new PedidoModel
            {
                DataPedido = DateTime.Now,
                PrecoTotalPedido = Convert.ToDouble(txtTotalPedido.Text),
                Produtos = PreencherProdutosDoPedido()
            };

            if (!new PedidoController().SalvarPedido(pedido)) return;
            dgvPedido.Rows.Clear();
            txtTotalPedido.Text = string.Empty;
        }

        private List<Produto.Produto> PreencherProdutosDoPedido()
        {
            var produtos = new List<Produto.Produto>();
            var quantidadeDeProdutos = dgvPedido.RowCount;
            for (var i = 0; i < quantidadeDeProdutos; i++)
            {
                var prod = new Produto.Produto
                {
                    IdProduto = Convert.ToInt32(dgvPedido.Rows[i].Cells[0].Value.ToString())
                };

                produtos.Add(prod);
            }

            return produtos;
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
