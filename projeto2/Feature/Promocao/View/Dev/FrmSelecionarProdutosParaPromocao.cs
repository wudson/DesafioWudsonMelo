using DevExpress.XtraEditors;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View.Dev
{
    public partial class FrmSelecionarProdutosParaPromocao : XtraForm
    {
        private static ProdutosAdicionadosNaPromocaoController _produtosAdicionadosNaPromocaoController;
        private readonly IList<PromocaoModel> _promocao;

        public FrmSelecionarProdutosParaPromocao(ProdutosAdicionadosNaPromocaoController controller)
        {
            InitializeComponent();
            _produtosAdicionadosNaPromocaoController = controller;
            _promocao = new List<PromocaoModel>();
        }

        private void FrmProdutosDaPromocaoComDesconto_Load(object sender, EventArgs e)
        {
            grpTipoFiltro.EditValue = @"P";

            lstDeProdutos.DataSource = AtribuirListaProdutos();
            lstDeProdutos.DisplayMember = "NomeProduto";

            if (_promocao.Count <= 0) return;
            dgvProdutosPromocao.DataSource = _promocao[0].Produtos;

            if (lstDeProdutos.CheckedItems.Count == 0) return;
            MudarEnabledDoBotaoSelecionarProdutos(true);
        }
        private static IList<Produto.Produto> AtribuirListaProdutos() =>
            _produtosAdicionadosNaPromocaoController.ListarProdutos(new Produto.Produto());

        private void MudarEnabledDoBotaoSelecionarProdutos(bool enabled) => btnAdicionarSelecionados.Enabled = enabled;

        private void BtnAdicionarProdutosSelecionadosNaPromocao_Click(object sender, EventArgs e)
        {
            if (lstDeProdutos.CheckedItems.Count == 0) return;

            btnSalvar.Enabled = true;

            switch ((string) grpTipoFiltro.EditValue)
            {
                case "P":
                {
                    var produtosSelecionados = lstDeProdutos.CheckedItems.Cast<Produto.Produto>().ToList();
                    VerificarProdutosComPromocaoAtiva(produtosSelecionados);
                    break;
                }
                case "G":
                {
                    var grupos = lstDeProdutos.CheckedItems.Cast<GrupoModel>().ToList();

                    var produtos = new List<Produto.Produto>();

                    foreach (var grupo in grupos)
                        produtos.AddRange(
                            AtribuirListaProdutos().Where(p => p.GrupoProduto.Grupo.Equals(grupo.Grupo)).ToList());

                    VerificarProdutosComPromocaoAtiva(produtos);
                    break;
                }
                default:
                {
                    var marcas = lstDeProdutos.CheckedItems.Cast<MarcaModel>().ToList();

                    var produtos = new List<Produto.Produto>();

                    foreach (var marca in marcas)
                        produtos.AddRange(
                            AtribuirListaProdutos().Where(p => p.MarcaProduto.Marca.Equals(marca.Marca)).ToList());

                    VerificarProdutosComPromocaoAtiva(produtos);
                    break;
                }
            }
        }

        private void VerificarProdutosComPromocaoAtiva(IReadOnlyCollection<Produto.Produto> produtos)
        {
            var produtosComPromocao = new List<Produto.Produto>();
            var produtosAdicionados = (List<Produto.Produto>)dgvProdutosPromocao.DataSource;

            foreach (var produto in produtos.Where(produto =>
                !produto.ValorComDesconto.Equals(produto.ValorVendaProduto)))
            {
                MessageBox.Show($@"O produto '{produto.NomeProduto}' já está em outra promoção ativa.");
                produtosComPromocao.Add(produto);
            }

            var produtosSemPromocao = produtos.Except(produtosComPromocao);

            if (produtosAdicionados == null) return;

            foreach (var produto in produtosSemPromocao)
            {
                if (produtosAdicionados.Any(pa => pa.IdProduto == produto.IdProduto)) continue;

                produtosAdicionados.Add(produto);
            }
            dgvProdutosPromocao.DataSource = produtosAdicionados.ToList();
        }

        private void GrpTipoFiltro_Properties_EditValueChanged(object sender, EventArgs e)
        {
            switch ((string) grpTipoFiltro.EditValue)
            {
                case "P":
                    FrmProdutosDaPromocaoComDesconto_Load(sender, e);
                    break;
                case "G":
                    lstDeProdutos.DataSource = AtribuirListaGrupos();
                    lstDeProdutos.DisplayMember = "Grupo";
                    break;
                default:
                    lstDeProdutos.DataSource = AtribuirListaMarcas();
                    lstDeProdutos.DisplayMember = "Marca";
                    break;
            }
        }

        private static IEnumerable<GrupoModel> AtribuirListaGrupos() =>
            _produtosAdicionadosNaPromocaoController.ListarGrupos();

        private static IEnumerable<MarcaModel> AtribuirListaMarcas() =>
            _produtosAdicionadosNaPromocaoController.ListarMarcas();

        private void BtnLimpar_Click(object sender, EventArgs e) =>
            dgvProdutosPromocao.DataSource = new List<Produto.Produto>();

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            switch ((string) grpTipoFiltro.EditValue)
            {
                case "P":
                    lstDeProdutos.DataSource =
                        AtribuirListaProdutos().Where(p => p.NomeProduto.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                            .ToList();

                    lstDeProdutos.DisplayMember = "NomeProduto";
                    break;
                case "G":
                    lstDeProdutos.DataSource =
                        AtribuirListaGrupos().Where(g => g.Grupo.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                            .ToList();

                    lstDeProdutos.DisplayMember = "Grupo";
                    break;
                default:
                    lstDeProdutos.DataSource =
                        AtribuirListaMarcas().Where(m => m.Marca.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                            .ToList();

                    lstDeProdutos.DisplayMember = "Marca";
                    break;
            }
        }

        private void BtnProdutosSelecionados_Click(object sender, EventArgs e)
        {
            if (gvProdutosPromocao.RowCount <= 0) return;

            var produtos = (List<Produto.Produto>)dgvProdutosPromocao.DataSource;

            _promocao.Add(new PromocaoModel
            {
                Produtos = produtos
            });
        }

        public IList<PromocaoModel> RetornarProdutos(List<Produto.Produto> produtos)
        {
            //if (int.TryParse("2", out var aaa))
            //{
            //    //converteu pra inteiro e o valor convertido tá em aaa
            //}
            //else
            //{
            //    //não converteu pra inteiro e o valor convertido tá em aaa
            //}

            dgvProdutosPromocao.DataSource = produtos;
            return ShowDialog() == DialogResult.OK
                ? _promocao
                : new List<PromocaoModel> { new PromocaoModel { Produtos = produtos } };
        }

        private void DgvProdutosPromocao_DataSourceChanged(object sender, EventArgs e) => 
            btnSalvar.Enabled = gvProdutosPromocao.RowCount > 0;

        private void FrmProdutosDaPromocaoComDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnAdicionarProdutosSelecionadosNaPromocao_Click(sender, e);
                    break;
                case Keys.F10:
                    BtnLimpar_Click(sender, e);
                    break;
                case Keys.Enter:
                    BtnProdutosSelecionados_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}