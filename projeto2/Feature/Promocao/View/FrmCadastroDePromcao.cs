using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmCadastroDePromcao : Form
    {
        private IList<PromocaoModel> _promocao;

        public FrmCadastroDePromcao()
        {
            InitializeComponent();
            _promocao = new List<PromocaoModel>();
        }

        private void BtnSelecionarProdutosDaPromocao_Click(object sender, EventArgs e)
        {
            _promocao = new FrmProdutosDaPromocaoComDesconto().RetornarProdutos();

            if (_promocao.Count <= 0) return;
            dgvProdutosDaPromocao.DataSource = _promocao[0].Produtos;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            AplicarDescontoNosProdutosSelecionados();
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
        }

        public IList<PromocaoModel> RetornarPromocao() => 
            ShowDialog() == DialogResult.OK ? _promocao : new List<PromocaoModel>();

        private void DgvProdutosDaPromocao_DataSourceChanged(object sender, EventArgs e) => 
            AplicarDescontoNosProdutosSelecionados();

        private void BtnSalvarPromocao_Click(object sender, EventArgs e)
        {
            if (_promocao.Count <= 0) return;
            _promocao[0].NomePromocao = txtNome.Text.Trim();
            _promocao[0].DataInicio = DateTime.Parse(txtDataInicio.Text);
            _promocao[0].DataFim = DateTime.Parse(txtDataFim.Text);
            _promocao[0].TipoPromocao = txtTipoPromocao.Text;
            _promocao[0].StatusPromocao = _promocao[0].DataFim >= DateTime.Today ? "Ativa" : "Inativa";
        }

        private void FrmCadastroDePromcao_Load(object sender, EventArgs e)
        {
            txtTipoPromocao.Text = txtTipoPromocao.Items[0].ToString();
        }

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
    }
}
