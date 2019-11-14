using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Promocao.Controller;
using projeto2.Feature.Promocao.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmProdutosDaPromocaoComDesconto : Form
    {
        private readonly ProdutosAdicionadosNaPromocaoController _produtosAdicionadosNaPromocaoController;
        private readonly IList<PromocaoModel> _promocao;

        public FrmProdutosDaPromocaoComDesconto(ProdutosAdicionadosNaPromocaoController controller)
        {
            InitializeComponent();
            _produtosAdicionadosNaPromocaoController = controller;
            _promocao = new List<PromocaoModel>();
        }

        private void FrmProdutosDaPromocaoComDesconto_Load(object sender, EventArgs e)
        {
            lstDeProdutos.DataSource = AtribuirListaProdutos();
            lstDeProdutos.DisplayMember = "NomeProduto";

            if (_promocao.Count <= 0) return;
            dgvProdutosDaPromocao.DataSource = _promocao[0].Produtos;

            if (lstDeProdutos.CheckedItems.Count == 0) return;
            AtivarBotaoDeProdutosSelecionados();
        }

        private void AtivarBotaoDeProdutosSelecionados()
        {
            btnProdutosSelecionados.Enabled = true;
            btnProdutosSelecionados.BackColor = Color.LimeGreen;
        }

        private IList<Produto.Produto> AtribuirListaProdutos() =>
            _produtosAdicionadosNaPromocaoController.ListarProdutos(new Produto.Produto());

        private void BtnAdicionarProdutosSelecionadosNaPromocao_Click(object sender, EventArgs e)
        {
            if (lstDeProdutos.CheckedItems.Count == 0) return;

            AtivarBotaoDeProdutosSelecionados();

            if (rdbProduto.Checked)
                AdicionarProdutos();

            else if (rdbGrupo.Checked)
                AdicionarProdutosDeUmGrupo();

            else
                AdicionarProdutosDeUmaMarca();
        }

        private void AdicionarProdutos()
        {
            var produtosSelecionados = lstDeProdutos.CheckedItems.Cast<Produto.Produto>().ToList();
            AdicionarSelecionadosNaGrid(produtosSelecionados);
        }

        private void AdicionarProdutosDeUmGrupo()
        {
            var grupos = lstDeProdutos.CheckedItems.Cast<GrupoModel>().ToList();
            var produtos = new List<Produto.Produto>();

            foreach (var grupo in grupos)
                produtos.AddRange(
                    AtribuirListaProdutos().Where(p => p.GrupoProduto.Grupo.Equals(grupo.Grupo)).ToList());

            AdicionarSelecionadosNaGrid(produtos);
        }

        private void AdicionarProdutosDeUmaMarca()
        {
            var marcas = lstDeProdutos.CheckedItems.Cast<MarcaModel>().ToList();
            var produtos = new List<Produto.Produto>();

            foreach (var marca in marcas)
                produtos.AddRange(
                    AtribuirListaProdutos().Where(p => p.MarcaProduto.Marca.Equals(marca.Marca)).ToList());

            AdicionarSelecionadosNaGrid(produtos);
        }

        private void AdicionarSelecionadosNaGrid(IReadOnlyCollection<Produto.Produto> produtos)
        {
            

            var produtosComPromocao = VerificaProdutosComPromocaoAtiva(produtos);
            var produtosSemPromocao = produtos.Except(produtosComPromocao);

            dgvProdutosDaPromocao.DataSource = RetornaProdutosAdicionadosSemDuplicidade(produtosSemPromocao);
        }

        private static IEnumerable<Produto.Produto> VerificaProdutosComPromocaoAtiva(IEnumerable<Produto.Produto> produtos)
        {
            var produtosComPromocao = new List<Produto.Produto>();

            foreach (var produto in produtos.Where(produto =>
                !produto.ValorComDesconto.Equals(produto.ValorVendaProduto)))
            {
                MessageBox.Show($@"O produto '{produto.NomeProduto}' já está em outra promoção ativa.");
                produtosComPromocao.Add(produto);
            }

            return produtosComPromocao;
        }

        private List<Produto.Produto> RetornaProdutosAdicionadosSemDuplicidade(IEnumerable<Produto.Produto> produtosSemPromocao)
        {
            var produtosAdicionados = (List<Produto.Produto>)dgvProdutosDaPromocao.DataSource;

            if (produtosAdicionados == null) return;
            foreach (var produto in produtosSemPromocao)
            {
                if (produtosAdicionados.Any(pa => pa.IdProduto == produto.IdProduto)) continue;

                produtosAdicionados.Add(produto);
            }

            return produtosAdicionados;
        }

        private void DgvProdutosDaPromocao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.Value = Propriedade.BuscarPropriedadeComPonto(dgvProdutosDaPromocao, e);
        }

        private void RdbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            lstDeProdutos.DataSource = AtribuirListaGrupos();

            lstDeProdutos.DisplayMember = "Grupo";
        }

        private IEnumerable<GrupoModel> AtribuirListaGrupos() =>
            _produtosAdicionadosNaPromocaoController.ListarGrupos();

        private void RdbProduto_CheckedChanged(object sender, EventArgs e)
        {
            FrmProdutosDaPromocaoComDesconto_Load(sender, e);
        }

        private void RdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            lstDeProdutos.DataSource = AtribuirListaMarcas();

            lstDeProdutos.DisplayMember = "Marca";
        }

        private IEnumerable<MarcaModel> AtribuirListaMarcas() =>
            _produtosAdicionadosNaPromocaoController.ListarMarcas();

        private void BtnLimpar_Click(object sender, EventArgs e) =>
            dgvProdutosDaPromocao.DataSource = new List<Produto.Produto>();

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rdbProduto.Checked)
            {
                FiltrarPorProduto();
            }
            else if (rdbGrupo.Checked)
            {
                FiltrarPorGrupo();
            }
            else
            {
                FiltrarPorMarca();
            }
        }

        private void FiltrarPorProduto()
        {
            lstDeProdutos.DataSource =
                AtribuirListaProdutos().Where(p => p.NomeProduto.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                    .ToList();

            lstDeProdutos.DisplayMember = "NomeProduto";
        }

        private void FiltrarPorGrupo()
        {
            lstDeProdutos.DataSource =
                AtribuirListaGrupos().Where(g => g.Grupo.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                    .ToList();

            lstDeProdutos.DisplayMember = "Grupo";
        }

        private void FiltrarPorMarca()
        {
            lstDeProdutos.DataSource =
                AtribuirListaMarcas().Where(m => m.Marca.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                    .ToList();

            lstDeProdutos.DisplayMember = "Marca";
        }

        private void BtnProdutosSelecionados_Click(object sender, EventArgs e)
        {
            if (dgvProdutosDaPromocao.RowCount <= 0)
            {
                MessageBox.Show(@"Nenhum produto selecionado");
                return;
            }

            AtribuiListaDeProdutosAPromocao();
        }

        private void AtribuiListaDeProdutosAPromocao()
        {
            var produtos = (List<Produto.Produto>) dgvProdutosDaPromocao.DataSource;

            _promocao.Add(new PromocaoModel
            {
                Produtos = produtos
            });
        }

        public IList<PromocaoModel> RetornarProdutos(List<Produto.Produto> produtos)
        {
            dgvProdutosDaPromocao.DataSource = produtos;
            return ShowDialog() == DialogResult.OK ? _promocao : new List<PromocaoModel>();
        }

    }
}
