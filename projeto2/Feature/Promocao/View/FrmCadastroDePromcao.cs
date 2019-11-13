using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmCadastroDePromcao : Form
    {
        private readonly PromocoesController _cadastroDePromocoesController;
        private IList<PromocaoModel> _promocao;
        private IList<PromocaoModel> _promocoesAtivas;

        public FrmCadastroDePromcao()
        {
            InitializeComponent();
            _cadastroDePromocoesController = new PromocoesController();
            _promocao = new List<PromocaoModel>();
            _promocoesAtivas = new List<PromocaoModel>();
        }

        private void BtnSelecionarProdutosDaPromocao_Click(object sender, EventArgs e)
        {
            _promocao = new FrmProdutosDaPromocaoComDesconto().RetornarProdutos();

            if (_promocao.Count <= 0) return;
            dgvProdutosDaPromocao.DataSource = _promocao[0].Produtos;

            grupoDesconto.Enabled = true;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            AplicarDescontoNosProdutosSelecionados();

            grupoPeriodoENome.Enabled = true;
        }

        private void AplicarDescontoNosProdutosSelecionados()
        {
            for (var i = 0; i < dgvProdutosDaPromocao.RowCount; i++)
                if (rdbValorFixo.Checked)
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) -
                        double.Parse(txtDesconto.Text);
                else
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) -
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) *
                        double.Parse(txtDesconto.Text) / 100;

            MudarCorValorComDesconto();
        }

        private void MudarCorValorComDesconto()
        {
            for (var i = 0; i < dgvProdutosDaPromocao.RowCount; i++)
                dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Style.ForeColor =
                    double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value.ToString()) >=
                    double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorCompraProduto"].Value.ToString())
                        ? Color.Green
                        : Color.Red;
        }

        private void DgvProdutosDaPromocao_DataSourceChanged(object sender, EventArgs e) =>
            AplicarDescontoNosProdutosSelecionados();

        private void BtnSalvarPromocao_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(txtDataInicio.Text) > DateTime.Parse(txtDataFim.Text))
            {
                MessageBox.Show(@"A data de início da promoção não pode ser posterior à data de término.");
                return;
            }

            var promocao = AtribuirPromocaoParaModel();
            _cadastroDePromocoesController.CadastrarDado(promocao);

            DesabilitarCampos();
        }

        private PromocaoModel AtribuirPromocaoParaModel()
        {
            _promocao[0].NomePromocao = txtNome.Text.Trim();
            _promocao[0].DataInicio = DateTime.Parse(txtDataInicio.Text);
            _promocao[0].DataFim = DateTime.Parse(txtDataFim.Text);
            _promocao[0].TipoPromocao = txtTipoPromocao.Text;
            _promocao[0].Produtos = PreencherProdutosDaPromocao();
            _promocao[0].StatusPromocao =
                _promocao[0].DataInicio <= DateTime.Today && _promocao[0].DataFim >= DateTime.Today
                    ? "Ativa"
                    : "Inativa";
            return _promocao[0];
        }

        private List<Produto.Produto> PreencherProdutosDaPromocao() =>
                dgvProdutosDaPromocao.Rows
                    .Cast<DataGridViewRow>()
                    .Select(r => new Produto.Produto
                    {
                        IdProduto = Convert.ToInt32(r.Cells[0].Value.ToString()),
                        ValorComDesconto = Convert.ToDouble(r.Cells["PreçoComDesconto"].Value.ToString())
                    })
                    .ToList();

        private void DesabilitarCampos()
        {
            grupoPeriodoENome.Enabled = false;
            grupoDesconto.Enabled = false;
            btnSalvarPromocao.Enabled = false;
            dgvProdutosDaPromocao.DataSource = null;
        }

        private void FrmCadastroDePromcao_Load(object sender, EventArgs e)
        {
            txtTipoPromocao.Text = txtTipoPromocao.Items[0].ToString();
            BuscarPromocoes();
        }

        private void BuscarPromocoes() => _promocoesAtivas = _cadastroDePromocoesController.BuscarPromocoesAtivas(FiltrarPromocao()).ToList();

        private static FiltrosPromocaoModel FiltrarPromocao() =>
            new FiltrosPromocaoModel
            {
                Ativas = true,
                Inativas = false
            };

        private void TxtTipoPromocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTipoPromocao.SelectedIndex == 0)
            {
                dgvProdutosDaPromocao.Visible = true;
                grupoDesconto.Visible = true;
                dgvProdutosPromocaoItemGratis.Visible = false;
                grupoItemGratis.Visible = false;
                return;
            }
            dgvProdutosDaPromocao.Visible = false;
            grupoDesconto.Visible = false;
            dgvProdutosPromocaoItemGratis.Visible = true;
            grupoItemGratis.Visible = true;
        }

        private void RdbItemDeBrinde_CheckedChanged(object sender, EventArgs e)
        {
            txtCompreMenosLeveMais.Enabled = false;
            txtBrinde.Enabled = true;
            btnBrinde.Enabled = true;

            btnBrinde.BackColor = Color.LimeGreen;
            btnBrinde.ForeColor = Color.White;
        }

        private void RdbCompreMenosLeveMais_CheckedChanged(object sender, EventArgs e)
        {
            txtCompreMenosLeveMais.Enabled = true;
            txtBrinde.Enabled = false;
            btnBrinde.Enabled = false;

            btnBrinde.BackColor = Color.DarkGray;
            btnBrinde.ForeColor = Color.White;

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                btnSalvarPromocao.Enabled = false;
                return;
            }
            btnSalvarPromocao.Enabled = true;
        }
    }
}
