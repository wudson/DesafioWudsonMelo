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
            lstDeProdutos.DataSource = new List<Produto.Produto>
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

            lstDeProdutos.DisplayMember = "NomeProduto";
        }

        private void BtnAdicionarProdutosSelecionadosNaPromocao_Click(object sender, System.EventArgs e)
        {
            if (lstDeProdutos.CheckedItems.Count == 0) return;
            if (rdbProduto.Checked)
            {
                var produtos = lstDeProdutos.CheckedItems.Cast<Produto.Produto>().ToList();

                dgvProdutosDaPromocao.DataSource = produtos;
            }
            else if (rdbGrupo.Checked)
            {
                var produtos = new List<Produto.Produto>
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

                dgvProdutosDaPromocao.DataSource = produtos;
            }
            else
            {
                var produtos = new List<Produto.Produto>
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

                dgvProdutosDaPromocao.DataSource = produtos;
            }

        }

        private void DgvProdutosDaPromocao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.Value = Propriedade.BuscarPropriedadeComPonto(dgvProdutosDaPromocao, e);
        }

        private void RdbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            lstDeProdutos.DataSource = new List<GrupoModel>
            {
                new GrupoModel
                {
                    Grupo = "Bebidas"
                }
            };

            lstDeProdutos.DisplayMember = "Grupo";
        }

        private void RdbProduto_CheckedChanged(object sender, EventArgs e)
        {
            FrmProdutosDaPromocaoComDesconto_Load(sender, e);
        }

        private void RdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            lstDeProdutos.DataSource = new List<MarcaModel>
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

            lstDeProdutos.DisplayMember = "Marca";
        }

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

        private void btnVoltar_Click(object sender, EventArgs e)
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
    }
}
