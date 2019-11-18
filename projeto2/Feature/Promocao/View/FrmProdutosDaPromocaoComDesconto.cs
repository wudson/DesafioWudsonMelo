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
        private static ProdutosAdicionadosNaPromocaoController _produtosAdicionadosNaPromocaoController;
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

        private static IList<Produto.Produto> AtribuirListaProdutos() =>
            _produtosAdicionadosNaPromocaoController.ListarProdutos(new Produto.Produto());

        private void BtnAdicionarProdutosSelecionadosNaPromocao_Click(object sender, EventArgs e)
        {
            if (lstDeProdutos.CheckedItems.Count == 0) return;

            AtivarBotaoDeProdutosSelecionados();

            if (rdbProduto.Checked)
            {
                var produtosSelecionados = lstDeProdutos.CheckedItems.Cast<Produto.Produto>().ToList();
                VerificarProdutosComPromocaoAtiva(produtosSelecionados);
            }

            else if (rdbGrupo.Checked)
            {
                var grupos = lstDeProdutos.CheckedItems.Cast<GrupoModel>().ToList();

                var produtos = new List<Produto.Produto>();

                foreach (var grupo in grupos)
                    produtos.AddRange(
                        AtribuirListaProdutos().Where(p => p.GrupoProduto.Grupo.Equals(grupo.Grupo)).ToList());

                VerificarProdutosComPromocaoAtiva(produtos);
            }
            else
            {
                var marcas = lstDeProdutos.CheckedItems.Cast<MarcaModel>().ToList();

                var produtos = new List<Produto.Produto>();

                foreach (var marca in marcas)
                    produtos.AddRange(
                        AtribuirListaProdutos().Where(p => p.MarcaProduto.Marca.Equals(marca.Marca)).ToList());

                VerificarProdutosComPromocaoAtiva(produtos);
            }
        }

        private void VerificarProdutosComPromocaoAtiva(IReadOnlyCollection<Produto.Produto> produtos)
        {
            var produtosComPromocao = new List<Produto.Produto>();
            var produtosAdicionados = (List<Produto.Produto>)dgvProdutosDaPromocao.DataSource;

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
            dgvProdutosDaPromocao.DataSource = produtosAdicionados.ToList();
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

        private static IEnumerable<GrupoModel> AtribuirListaGrupos() =>
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

        private static IEnumerable<MarcaModel> AtribuirListaMarcas() =>
            _produtosAdicionadosNaPromocaoController.ListarMarcas();

        private void BtnLimpar_Click(object sender, EventArgs e) =>
            dgvProdutosDaPromocao.DataSource = new List<Produto.Produto>();

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (rdbProduto.Checked)
            {
                lstDeProdutos.DataSource =
                    AtribuirListaProdutos().Where(p => p.NomeProduto.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                        .ToList();

                lstDeProdutos.DisplayMember = "NomeProduto";
            }
            else if (rdbGrupo.Checked)
            {
                lstDeProdutos.DataSource =
                    AtribuirListaGrupos().Where(g => g.Grupo.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                        .ToList();

                lstDeProdutos.DisplayMember = "Grupo";
            }
            else
            {
                lstDeProdutos.DataSource =
                    AtribuirListaMarcas().Where(m => m.Marca.ToLower().StartsWith(txtBuscar.Text.ToLower()))
                        .ToList();

                lstDeProdutos.DisplayMember = "Marca";
            }
        }

        private void BtnProdutosSelecionados_Click(object sender, EventArgs e)
        {
            if (dgvProdutosDaPromocao.RowCount <= 0) return;
            
            var produtos = (List<Produto.Produto>)dgvProdutosDaPromocao.DataSource;

            _promocao.Add(new PromocaoModel
            {
                Produtos = produtos
            });
        }

        public IList<PromocaoModel> RetornarProdutos(List<Produto.Produto> produtos)
        {
            dgvProdutosDaPromocao.DataSource = produtos;
            return ShowDialog() == DialogResult.OK
                ? _promocao
                : new List<PromocaoModel> {new PromocaoModel {Produtos = produtos}};
        }

        private void DgvProdutosDaPromocao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvProdutosDaPromocao.RowCount > 0)
                AtivarBotaoDeProdutosSelecionados();
            else
                DesativarBotaoDeProdutosSelecionados();
        }

        private void DesativarBotaoDeProdutosSelecionados()
        {
            btnProdutosSelecionados.Enabled = false;
            btnProdutosSelecionados.BackColor = Color.DarkGray;
        }

        private void FrmProdutosDaPromocaoComDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    BtnAdicionarProdutosSelecionadosNaPromocao_Click(sender, e);
                    break;
                case Keys.Delete:
                   BtnLimpar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
