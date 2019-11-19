﻿using System;
using System.Windows.Forms;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Produto.View.WinForms
{
    public partial class FrmCadastroDeProduto : Form
    {
        private readonly CadastroDeProdutoController _cadastroDeProdutoController;
        private Produto _produto;

        public FrmCadastroDeProduto(CadastroDeProdutoController controller)
        {
            InitializeComponent();
            _cadastroDeProdutoController = controller;
            btnEditar.Visible = false;
            btnSalvarCadastroProduto.Visible = true;
        }

        public void RecebeProdutoParaAlterar(Produto produto)
        {
            _produto = produto;
            btnEditar.Visible = true;
            btnSalvarCadastroProduto.Visible = false;

            ShowDialog();
        }

        private void BtnSalvarCadastroProduto_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios()) return;

            if (!_cadastroDeProdutoController.CadastrarDado(AtribuirCamposParaModel(0))) return;
            LimpaCampos(pnlControl.Controls);
            txtNome.Focus();
        }

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Produto' obrigatório.");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoDeBarras.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Código de barras' obrigatório.");
                txtCodigoDeBarras.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtGrupo.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Grupo' obrigatório.");
                txtGrupo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTipo.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Tipo' obrigatório.");
                txtTipo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtValorDeCompra.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Compra' obrigatório.");
                txtValorDeCompra.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtValorDeVenda.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Venda' obrigatório.");
                txtValorDeVenda.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtFornecedor.Text.Trim())) return true;
            MessageBox.Show(@"Campo 'Fornecedor' obrigatório.");
            txtFornecedor.Focus();
            return false;
        }

        private Produto AtribuirCamposParaModel(int id) =>
            new Produto
            {
                IdProduto = id,
                NomeProduto = txtNome.Text.Trim(),
                CodigoDeBarras = txtCodigoDeBarras.Text.Trim(),
                MarcaProduto =
                {
                    IdMarca = int.Parse(txtMarca.SelectedValue.ToString()),
                },
                GrupoProduto =
                {
                    IdGrupo = int.Parse(txtGrupo.SelectedValue.ToString()),
                },
                FornecedorProduto = txtFornecedor.Text.Trim(),
                TipoProduto = txtTipo.Text.Trim(),
                QuantidadeEstoqueProduto = int.Parse(txtQuantidadeEmEstoque.Text.Trim()),
                ValorCompraProduto = double.Parse(txtValorDeCompra.Text.Trim()),
                ValorVendaProduto = double.Parse(txtValorDeVenda.Text.Trim())
            };

        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
                if (DeveLimpar(item))
                    item.Text = string.Empty;
        }

        private static bool DeveLimpar(IDisposable item) =>
            item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox);

        private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e) => Close();

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {
            PreencherGrupos();
            PreencherMarcas();
            CarregarDadosDoProduto();
        }

        private void PreencherGrupos()
        {
            txtGrupo.DataSource = _cadastroDeProdutoController.ListarGrupos();
            txtGrupo.DisplayMember = "Grupo";
            txtGrupo.ValueMember = "IdGrupo";
            txtGrupo.Text = string.Empty;
        }

        private void PreencherMarcas()
        {
            txtMarca.DataSource = _cadastroDeProdutoController.ListarMarcas();
            txtMarca.DisplayMember = "Marca";
            txtMarca.ValueMember = "IdMarca";
            txtMarca.Text = string.Empty;
        }

        private void CarregarDadosDoProduto()
        {
            if (_produto == null) return;
            txtNome.Text = _produto.NomeProduto;
            txtMarca.Text = _produto.MarcaProduto.Marca;
            txtGrupo.Text = _produto.GrupoProduto.Grupo;
            txtCodigoDeBarras.Text = _produto.CodigoDeBarras;
            txtFornecedor.Text = _produto.FornecedorProduto;
            txtTipo.Text = _produto.TipoProduto;
            txtValorDeCompra.Value = (decimal) _produto.ValorCompraProduto;
            txtValorDeVenda.Value = (decimal)_produto.ValorVendaProduto;
            txtQuantidadeEmEstoque.Text = _produto.QuantidadeEstoqueProduto.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObrigatorios()) return;

            if (_cadastroDeProdutoController.AlterarDado(AtribuirCamposParaModel(_produto.IdProduto)))
                Close();
        }

        private void FrmCadastroDeProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    CadastrarOuAlterar(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void CadastrarOuAlterar(object sender, EventArgs e)
        {
            if (btnSalvarCadastroProduto.Visible)
                BtnSalvarCadastroProduto_Click(sender, e);
            else
                BtnEditar_Click(sender, e);
        }

        private void TxtValorDeVenda_Enter(object sender, EventArgs e) =>
            txtValorDeVenda.Select(0, txtValorDeVenda.Text.Length);

        private void TxtValorDeCompra_Enter(object sender, EventArgs e) => 
            txtValorDeCompra.Select(0, txtValorDeCompra.Text.Length);

        private void TxtValorDeCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == '-') e.Handled = true;
        }

        private void BtnNovoGrupo_Click(object sender, EventArgs e)
        {
            _cadastroDeProdutoController.AbrirCadastroDeGrupo();
            PreencherGrupos();
        }

        private void BtnNovaMarca_Click(object sender, EventArgs e)
        {
            _cadastroDeProdutoController.AbrirCadastroDeMarca();
            PreencherMarcas();
        }

        private void BtnNovoGrupo_MouseHover(object sender, EventArgs e) => 
            new ToolTip().SetToolTip(btnNovoGrupo, "Cadastrar novo grupo.");

        private void BtnNovaMarca_MouseHover(object sender, EventArgs e) => 
            new ToolTip().SetToolTip(btnNovaMarca, "Cadastrar nova marca.");
    }
}