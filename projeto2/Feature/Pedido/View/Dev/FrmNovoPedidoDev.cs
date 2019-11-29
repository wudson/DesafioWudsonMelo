using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using projeto2.Feature.Cliente.Model;
using projeto2.Feature.Pedido.Controller;
using projeto2.Feature.Pedido.Model;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projeto2.Feature.Pedido.View.Dev
{
    public partial class FrmNovoPedidoDev : XtraForm
    {
        private readonly NovoPedidoController _novoPedidoController;
        private List<PromocaoModel> _promocoes;

        public FrmNovoPedidoDev(NovoPedidoController controller)
        {
            InitializeComponent();
            _novoPedidoController = controller;
            _promocoes = new List<PromocaoModel>();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            grpTipoFiltro.EditValue = @"P";

            PreencherListaDeProdutos();
            PreencherComboClientes();
            BuscarPromocoes();
        }

        private void PreencherListaDeProdutos() =>
            lstProdutos.DataSource = _novoPedidoController.ListarProdutos();

        private void PreencherComboClientes()
        {
            txtCliente.Properties.DataSource = _novoPedidoController.ListarClientes();
            txtCliente.Properties.NullText = string.Empty;
        }

        private void BuscarPromocoes() =>
            _promocoes = _novoPedidoController.BuscarPromocoesAtivas(FiltrarPromocao()).ToList();

        private static FiltrosPromocaoModel FiltrarPromocao() =>
            new FiltrosPromocaoModel
            {
                Ativas = true,
                Inativas = false
            };

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            switch ((string) grpTipoFiltro.EditValue)
            {
                case "P":
                    lstProdutos.DataSource =
                        AtribuirListaProdutos().Where(p => p.NomeProduto.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                            .ToList();
                    break;
                case "G":
                    lstProdutos.DataSource =
                        AtribuirListaProdutos().Where(p =>
                                p.GrupoProduto.Grupo.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                            .ToList();
                    break;
                case "M":
                    lstProdutos.DataSource =
                        AtribuirListaProdutos().Where(p =>
                                p.MarcaProduto.Marca.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                            .ToList();
                    break;
                default:
                    lstProdutos.DataSource =
                        AtribuirListaProdutos()
                            .Where(p => p.CodigoDeBarras.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                            .ToList();
                    break;
            }
        }

        private IEnumerable<Produto.Produto> AtribuirListaProdutos() =>
            _novoPedidoController.ListarProdutos();

        private void BtnAdicionarSelecionados_Click(object sender, EventArgs e)
        {
            if (lsProdutos.SelectedRowsCount == 0) return;

            btnSalvar.Enabled = true;

            var produtos = lsProdutos.GetSelectedRows().Select(linha => new Produto.Produto
            {
                NomeProduto = lsProdutos.GetRowCellValue(linha, colNomeProduto1).ToString(),
                IdProduto = (int) lsProdutos.GetRowCellValue(linha, colIdProduto1),
                ValorVendaProduto = double.Parse(lsProdutos.GetRowCellValue(linha, colValorVendaProduto1).ToString()),
                ValorComDesconto = double.Parse(lsProdutos.GetRowCellValue(linha, colValorComDesconto1).ToString()),
                QuantidadeProdutoPedido = 1
            }).ToList();

            dgvProdutos.DataSource = produtos;
        }

        private void BtnLimpar_Click(object sender, EventArgs e) =>
            dgvProdutos.DataSource = new List<Produto.Produto>();

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (gvProdutos.RowCount <= 0) return;

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
            dgvProdutos.DataSource = new List<Produto.Produto>();
            txtCliente.Text = string.Empty;
        }

        private PedidoModel PreencherModelDePedido() =>
            new PedidoModel
            {
                DataPedido = DateTime.Now,
                PrecoTotalPedido = Convert.ToDouble(gvProdutos.Columns
                    .FirstOrDefault(c => "coltotal".Equals(c.Name))
                    ?.SummaryItem.SummaryValue),
                Produtos = dgvProdutos.DataSource as List<Produto.Produto>,
                Cliente = new ClienteModel
                {
                    IdCliente = int.Parse(txtCliente.EditValue.ToString())
                }
            };

        private void FrmNovoPedidoDev_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnAdicionarSelecionados_Click(sender, e);
                    break;
                case Keys.F10:
                    BtnLimpar_Click(sender, e);
                    break;
                case Keys.F5:
                    BtnSalvar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void LstProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) txtCliente.Focus();
        }

        private void LsProdutos_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            var nomeProduto = lsProdutos.GetRowCellValue(e.RowHandle, lsProdutos.Columns[colNomeProduto1.FieldName]).ToString();
            if(_promocoes.Any(p => p.Produtos.Any(pr => pr.NomeProduto == nomeProduto)))
                e.Appearance.ForeColor = Color.Green;
        }

        private void GvProdutos_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            var nomeProduto = lsProdutos.GetRowCellValue(e.RowHandle, lsProdutos.Columns[colNomeProduto.FieldName]).ToString();
            if (_promocoes.Any(p => p.Produtos.Any(pr => pr.NomeProduto == nomeProduto)))
                e.Appearance.ForeColor = Color.Green;
        }

        private void DgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) btnSalvar.Focus();
        }
    }
}