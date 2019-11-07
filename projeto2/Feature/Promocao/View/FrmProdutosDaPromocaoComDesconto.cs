using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;
using projeto2.Feature.Promocao.Model;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmProdutosDaPromocaoComDesconto : Form
    {
        private readonly IList<PromocaoModel> _promocao;

        public FrmProdutosDaPromocaoComDesconto()
        {
            InitializeComponent();
            _promocao = new List<PromocaoModel>();
        }

        private void FrmProdutosDaPromocaoComDesconto_Load(object sender, EventArgs e)
        {
            lstDeProdutos.DataSource = AtribuirListaProdutos();

            lstDeProdutos.DisplayMember = "NomeProduto";
        }

        private static List<Produto.Produto> AtribuirListaProdutos() =>
            new List<Produto.Produto>
            {
                new Produto.Produto
                {
                    IdProduto = 1,
                    NomeProduto = "Coca cola",
                    ValorVendaProduto = 10,
                    ValorCompraProduto = 5,
                    GrupoProduto = new GrupoModel
                    {
                        Grupo = "Bebidas",
                    },
                    MarcaProduto = new MarcaModel
                    {
                        Marca = "Coca-Cola",
                    }
                },
                new Produto.Produto
                {
                    IdProduto = 2,
                    NomeProduto = "Cerveja",
                    ValorVendaProduto = 4.80,
                    ValorCompraProduto = 2.75,
                    GrupoProduto = new GrupoModel
                    {
                        Grupo = "Bebidas",
                    },
                    MarcaProduto = new MarcaModel
                    {
                        Marca = "Skol",
                    }
                },
                new Produto.Produto
                {
                    IdProduto = 3,
                    NomeProduto = "Sprite",
                    ValorVendaProduto = 8,
                    ValorCompraProduto = 4.25,
                    GrupoProduto = new GrupoModel
                    {
                        Grupo = "Bebidas",
                    },
                    MarcaProduto = new MarcaModel
                    {
                        Marca = "Coca-Cola",
                    }
                }
            };

        private void BtnAdicionarProdutosSelecionadosNaPromocao_Click(object sender, EventArgs e)
        {
            if (lstDeProdutos.CheckedItems.Count == 0) return;

            if (rdbProduto.Checked)
                dgvProdutosDaPromocao.DataSource = lstDeProdutos.CheckedItems.Cast<Produto.Produto>().ToList();

            else if (rdbGrupo.Checked)
            {
                var grupos = lstDeProdutos.CheckedItems.Cast<GrupoModel>().ToList();

                var produtos = new List<Produto.Produto>();

                foreach (var grupo in grupos)
                    produtos.AddRange(
                        AtribuirListaProdutos().Where(p => p.GrupoProduto.Grupo.Equals(grupo.Grupo)).ToList());
                dgvProdutosDaPromocao.DataSource = produtos;
            }
            else
            {
                var marcas = lstDeProdutos.CheckedItems.Cast<MarcaModel>().ToList();

                var produtos = new List<Produto.Produto>();

                foreach (var marca in marcas)
                    produtos.AddRange(
                        AtribuirListaProdutos().Where(p => p.MarcaProduto.Marca.Equals(marca.Marca)).ToList());
                dgvProdutosDaPromocao.DataSource = produtos;

            }

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

        private static List<GrupoModel> AtribuirListaGrupos() =>
            new List<GrupoModel>
            {
                new GrupoModel
                {
                    Grupo = "Bebidas"
                }
            };

        private void RdbProduto_CheckedChanged(object sender, EventArgs e)
        {
            FrmProdutosDaPromocaoComDesconto_Load(sender, e);
        }

        private void RdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            lstDeProdutos.DataSource = AtribuirListaMarcas();

            lstDeProdutos.DisplayMember = "Marca";
        }

        private static List<MarcaModel> AtribuirListaMarcas() =>
            new List<MarcaModel>
            {
                new MarcaModel
                {
                    Marca = "Coca-Cola"
                },
                new MarcaModel
                {
                    Marca = "Skol"
                }
            };

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
            if (dgvProdutosDaPromocao.RowCount <= 0)
            {
                MessageBox.Show(@"Nenhum produto selecionado");
                return;
            }
            var produtos = (List<Produto.Produto>) dgvProdutosDaPromocao.DataSource;

            _promocao.Add(new PromocaoModel
            {
                Produtos = produtos
            });
        }

        public IList<PromocaoModel> RetornarProdutos() => 
            ShowDialog() == DialogResult.OK ? _promocao : new List<PromocaoModel>();
    }
}
