using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Controller;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Pedido.View.WinForms
{
    public partial class FrmNovoPedido : Form
    {
        private readonly NovoPedidoController _novoPedidoController;
        private List<PromocaoModel> _promocoes;

        public FrmNovoPedido(NovoPedidoController controller)
        {
            InitializeComponent();
            _novoPedidoController = controller;
            _promocoes = new List<PromocaoModel>();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            PreencherListaDeProdutos();
            PreencherComboClientes();
            BuscarPromocoes();
        }

        private void PreencherListaDeProdutos()
        {
            lstProdutos.DataSource = _novoPedidoController.ListarProdutos();
            lstProdutos.DisplayMember = "NomeProduto";
        }

        private void PreencherComboClientes()
        {
            txtCliente.DataSource = _novoPedidoController.ListarClientes();
            txtCliente.DisplayMember = "NomePessoa";
            txtCliente.ValueMember = "IdCliente";
            txtCliente.Text = string.Empty;
        }

        private void BuscarPromocoes() =>
            _promocoes = _novoPedidoController.BuscarPromocoesAtivas(FiltrarPromocao()).ToList();

        private static FiltrosPromocaoModel FiltrarPromocao() =>
            new FiltrosPromocaoModel
            {
                Ativas = true,
                Inativas = false
            };

        private void LstProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = lstProdutos.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches) return;

            ProdutoSelecionado((Produto.Produto)lstProdutos.SelectedItems[0]);
        }

        private void ProdutoSelecionado(Produto.Produto produtoAdicionado)
        {
            txtProduto.Text = produtoAdicionado.NomeProduto;
            txtIdProduto.Text = produtoAdicionado.IdProduto.ToString();

            if (_promocoes.Any(pr => pr.Produtos.Any(p => p.NomeProduto.Equals(produtoAdicionado.NomeProduto))))
            {
                txtPreco.Text = produtoAdicionado.ValorComDesconto.ToString("c2");
                grpTextoPromocao.Visible = true;
                lblPrecoComDesconto.Text = produtoAdicionado.ValorComDesconto.ToString("c2");
                lblPrecoDeVenda.Text = produtoAdicionado.ValorVendaProduto.ToString("c2");
            }
            else
            {
                txtPreco.Text = produtoAdicionado.ValorVendaProduto.ToString("c2");
                grpTextoPromocao.Visible = false;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text)) return;

            dgvPedido.Rows.Add(txtIdProduto.Text, txtProduto.Text, txtQuantidade.Text,
                decimal.Parse(txtPreco.Text.Replace("R$", "")) * decimal.Parse(txtQuantidade.Text));
            txtPreco.Text = string.Empty;
            txtProduto.Text = string.Empty;
            txtQuantidade.Text = @"1";
            grpTextoPromocao.Visible = false;

            CalcularTotalAPagar();
        }

        private void CalcularTotalAPagar() =>
            txtTotalPedido.Text = dgvPedido.Rows
                .Cast<DataGridViewRow>()
                .Sum(r => Convert.ToDecimal(r.Cells["preco"].Value))
                .ToString("C2");

        private void BtnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedido.RowCount <= 0) return;

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show(@"Informe o cliente.");
                txtCliente.Focus();
                return;
            }

            SalvarPedido();
        }

        private void SalvarPedido()
        {
            var pedido = PreencherModelDePedido();

            if (!_novoPedidoController.SalvarPedido(pedido)) return;
            dgvPedido.Rows.Clear();
            txtTotalPedido.Text = string.Empty;
            txtCliente.Text = string.Empty;
        }

        private PedidoModel PreencherModelDePedido() =>
            new PedidoModel
            {
                DataPedido = DateTime.Now,
                PrecoTotalPedido = Convert.ToDouble(txtTotalPedido.Text.Replace("R$", "")),
                Produtos = PreencherProdutosDoPedido(),
                Cliente = new ClienteModel
                {
                    IdCliente = int.Parse(txtCliente.SelectedValue.ToString())
                }
            };

        private IList<Produto.Produto> PreencherProdutosDoPedido() =>
            dgvPedido.Rows
                .Cast<DataGridViewRow>()
                .Select(r => new Produto.Produto
                {
                    IdProduto = Convert.ToInt32(r.Cells[0].Value.ToString()),
                    QuantidadeProdutoPedido = Convert.ToInt32(r.Cells["quantidade"].Value.ToString())
                })
                .ToList();

        private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e) => Close();

        private void DgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var resultado = MessageBox.Show(@"Deseja remover esse item do pedido?", @"Pedido",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!resultado.Equals(DialogResult.OK)) return;

            if (e.RowIndex < 0) return;
            dgvPedido.Rows.Remove(dgvPedido.Rows[e.RowIndex]);

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

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                PreencherListaDeProdutos();
                return;
            }

            lstProdutos.DataSource = new ProdutoController().ListarDados(Filtrar());
        }

        private Produto.Produto Filtrar() =>
            new Produto.Produto
            {
                CodigoDeBarras = txtBuscar.Text.Trim()
            };

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (string.IsNullOrWhiteSpace(txtBuscar.Text)) return;

            var produtos = (List<Produto.Produto>)lstProdutos.DataSource;
            var produtoSelecionado = produtos.Where(p => p.CodigoDeBarras.Equals(txtBuscar.Text)).ToList();

            if (produtoSelecionado.Count <= 0) return;
            ProdutoSelecionado(produtoSelecionado[0]);
        }
    }
}
