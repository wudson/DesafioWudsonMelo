using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View.Dev
{
    public partial class FrmCadastroDePromocaoDev : XtraForm
    {
        private readonly CadastroDePromocaoController _cadastroDePromocoesController;
        private IList<PromocaoModel> _promocao;

        public FrmCadastroDePromocaoDev(CadastroDePromocaoController controller)
        {
            InitializeComponent();
            _cadastroDePromocoesController = controller;
            _promocao = new List<PromocaoModel>();
        }

        private void BtnSelecionarProdutosDaPromocao_Click(object sender, EventArgs e)
        {
            if (btnSelecionarProdutos.Enabled == false) return;

            _promocao = _cadastroDePromocoesController.RetornarProdutos(TemProdutos());

            if (_promocao.Count <= 0) return;
            dgvProdutosPromocao.DataSource = _promocao[0].Produtos;

            grpDesconto.Enabled = true;
            txtValor.Focus();
        }

        private List<Produto.Produto> TemProdutos() =>
            _promocao.Count <= 0 ? new List<Produto.Produto>() : _promocao[0].Produtos;

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (btnAplicar.Enabled == false) return;
            if ((string) grpTipoDesconto.EditValue == "F")
                AplicarDescontoFixoNosProdutosSelecionados();
            else
                AplicarDescontoPorcentagemNosProdutosSelecionados();

            dgvProdutosPromocao.DataSource = null;
            dgvProdutosPromocao.DataSource = _promocao[0].Produtos;
            grpDadosPromocao.Enabled = true;
        }

        private void AplicarDescontoFixoNosProdutosSelecionados()
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text)) return;

            foreach (var produto in _promocao[0].Produtos)
            {
                produto.ValorComDesconto =
                    double.Parse(produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture)) -
                    double.Parse(txtValor.Text.Replace("R$", ""));
            }
        }

        private void AplicarDescontoPorcentagemNosProdutosSelecionados()
        {
            if (string.IsNullOrWhiteSpace(txtPorcentagem.Text)) return;

            foreach (var produto in _promocao[0].Produtos)
            {
                produto.ValorComDesconto =
                    double.Parse(produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture)) -
                    double.Parse(produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture)) *
                    double.Parse(txtPorcentagem.Text.Replace("%", "")) / 100;
            }
        }

        private void BtnSalvarPromocao_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled == false) return;

            if (DateTime.Parse(txtDataInicio.Text) > DateTime.Parse(txtDataFim.Text))
            {
                MessageBox.Show(@"A data de início da promoção não pode ser posterior à data de término.");
                return;
            }

            _cadastroDePromocoesController.CadastrarDado(AtribuirPromocaoParaModel());

            DesabilitarCampos();
        }

        private PromocaoModel AtribuirPromocaoParaModel()
        {
            _promocao[0].NomePromocao = txtNome.Text.Trim();
            _promocao[0].DataInicio = DateTime.Parse(txtDataInicio.Text);
            _promocao[0].DataFim = DateTime.Parse(txtDataFim.Text);
            _promocao[0].TipoPromocao = txtTipo.Text;
            _promocao[0].StatusPromocao =
                _promocao[0].DataInicio <= DateTime.Today && _promocao[0].DataFim >= DateTime.Today
                    ? "Ativa"
                    : "Inativa";
            return _promocao[0];
        }

        private void DesabilitarCampos()
        {
            grpDadosPromocao.Enabled = false;
            grpDesconto.Enabled = false;
            btnSalvar.Enabled = false;
            dgvProdutosPromocao.DataSource = null;
            txtTipo.EditValue = null;
            _promocao[0].Produtos.Clear();
            btnSelecionarProdutos.Enabled = false;
            txtValor.Text = string.Empty;
        }


        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                btnSalvar.Enabled = false;
                return;
            }
            btnSalvar.Enabled = true;
        }

        private void FrmCadastroDePromcao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F9:
                    BtnSelecionarProdutosDaPromocao_Click(sender, e);
                    break;
                case Keys.F5:
                    BtnSalvarPromocao_Click(sender, e);
                    break;
                case Keys.F7:
                    BtnAplicar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void TxtTipo_SelectedIndexChanged(object sender, EventArgs e) =>
            btnSelecionarProdutos.Enabled = true;

        private void FrmCadastroDePromocaoDev_Load(object sender, EventArgs e) =>
            grpTipoDesconto.EditValue = @"F";

        private void GvProdutosPromocao_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            var precoCompra = double.Parse(gvProdutosPromocao.GetRowCellValue(e.RowHandle, gvProdutosPromocao.Columns[colValorCompraProduto.FieldName]).ToString());
            var precoDesconto = double.Parse(gvProdutosPromocao.GetRowCellValue(e.RowHandle, gvProdutosPromocao.Columns[colDesconto.FieldName]).ToString());

            if(precoDesconto < precoCompra)
                e.Appearance.ForeColor = Color.Red;
        }

        private void TxtPorcentagem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPorcentagem.Text)) return;
            if (int.Parse(txtPorcentagem.Text.Replace("%", "")) > 100)
                txtPorcentagem.Text = @"100%";
        }

        private void GrpTipoDesconto_EditValueChanged(object sender, EventArgs e)
        {
            if ((string) grpTipoDesconto.EditValue == "F")
            {
                txtPorcentagem.Visible = false;
                txtValor.Visible = true;
                txtPorcentagem.Text = string.Empty;
            }
            else
            {
                txtPorcentagem.Visible = true;
                txtValor.Visible = false;
                txtValor.EditValue = null;
            }
        }
    }
}