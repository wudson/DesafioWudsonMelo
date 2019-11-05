using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Grupo.Model;
using projeto2.Feature.Marca.Model;

namespace projeto2.Feature.Promocao.View
{
    public partial class FrmProdutosDaPromocaoComDesconto : Form
    {
        public FrmProdutosDaPromocaoComDesconto()
        {
            InitializeComponent();
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
                    NomeProduto = "Coca cola",
                    ValorVendaProduto = 10,
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
                    NomeProduto = "Cerveja",
                    ValorVendaProduto = 5,
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
                    NomeProduto = "Sprite",
                    ValorVendaProduto = 8,
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

                var zéGotinha = new List<Produto.Produto>();

                foreach (var grupo in grupos)
                    zéGotinha.AddRange(
                        AtribuirListaProdutos().Where(p => p.GrupoProduto.Grupo.Equals(grupo.Grupo)).ToList());
                dgvProdutosDaPromocao.DataSource = zéGotinha;
            }
            else
            {
                var marcas = lstDeProdutos.CheckedItems.Cast<MarcaModel>().ToList();

                var zéGotinha = new List<Produto.Produto>();

                foreach (var marca in marcas)
                    zéGotinha.AddRange(
                        AtribuirListaProdutos().Where(p => p.MarcaProduto.Marca.Equals(marca.Marca)).ToList());
                dgvProdutosDaPromocao.DataSource = zéGotinha;

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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            dgvProdutosDaPromocao.DataSource = new List<Produto.Produto>();
        }

        private void DgvProdutosDaPromocao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            for (var i = 0; i < dgvProdutosDaPromocao.RowCount; i++)
            {
                if (rdbValorFixo.Checked)
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) - double.Parse(txtDesconto.Text);
                else
                {
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) - double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) * double.Parse(txtDesconto.Text)/100;
                }
            }

        }

        private void DgvProdutosDaPromocao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutosDaPromocao.CurrentRow != null) dgvProdutosDaPromocao.Rows.Remove(dgvProdutosDaPromocao.Rows[e.RowIndex]);
        }

        private void BtnCancelarPromocao_Click(object sender, EventArgs e)
        {
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dgvProdutosDaPromocao.RowCount; i++)
            {
                if (rdbValorFixo.Checked)
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) - double.Parse(txtDesconto.Text);
                else
                {
                    dgvProdutosDaPromocao.Rows[i].Cells["PreçoComDesconto"].Value =
                        double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) - double.Parse(dgvProdutosDaPromocao.Rows[i].Cells["valorVendaProduto"].Value.ToString()) * double.Parse(txtDesconto.Text) / 100;
                }
            }
        }

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

        private void BtnSalvarPromocao_Click(object sender, EventArgs e)
        {
            new FrmFinalizarCadastroPromocao().ShowDialog();
        }
    }
}
