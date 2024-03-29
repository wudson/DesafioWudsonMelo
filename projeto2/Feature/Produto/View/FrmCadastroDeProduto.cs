﻿using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Produto.View
{
    public partial class FrmCadastroDeProduto : Form
    {
        private readonly Produto _produto;

        public FrmCadastroDeProduto(Produto produto)
        {
            InitializeComponent();
            _produto = produto;
        }
        public FrmCadastroDeProduto()
        {
            InitializeComponent();
        }

        private void BtnSalvarCadastroProduto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(pnlControl.Controls)) return;
            var produto = new Produto
            {
                IdProduto = int.Parse(txtIdProduto.Text),
                NomeProduto = txtNome.Text,
                MarcaProduto = txtMarca.Text,
                GrupoProduto = txtGrupo.Text,
                FornecedorProduto = txtFornecedor.Text,
                QuantidadeEstoqueProduto = int.Parse(txtQuantidadeEmEstoque.Text),
                ValorCompraProduto = double.Parse(txtValorDeCompra.Text),
                ValorVendaProduto = double.Parse(txtValorDeVenda.Text)
            };

            CadastraOuAltera(produto);
        }

        private static bool ValidarCampos(IEnumerable controles)
        {
            if (!controles.Cast<Control>().Any(item => string.IsNullOrWhiteSpace(item.Text))) return true;
            MessageBox.Show(@"Porfavor preencha todos os campos", @"Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;

        }

        private void CadastraOuAltera(Produto produto)
        {
            if (produto.IdProduto >= 1)
            {
                DeveAlterar(produto);
            }
            else
            {
                DeveCadastrar(produto);
            }
        }

        private void DeveAlterar(Produto produto)
        {
            if (new ProdutoController().AlterarDado(produto))
                Close();
        }

        private void DeveCadastrar(Produto produto)
        {
            if (new ProdutoController().CadastrarDado(produto))
                LimpaCampos(pnlControl.Controls);
        }

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
            if (_produto == null) return;
            txtIdProduto.Text = _produto.IdProduto.ToString();
            txtNome.Text = _produto.NomeProduto;
            txtMarca.Text = _produto.MarcaProduto;
            txtGrupo.Text = _produto.GrupoProduto;
            txtFornecedor.Text = _produto.FornecedorProduto;
            txtValorDeCompra.Text = _produto.ValorCompraProduto.ToString(CultureInfo.InvariantCulture);
            txtValorDeVenda.Text = _produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture);
            txtQuantidadeEmEstoque.Text = _produto.QuantidadeEstoqueProduto.ToString();
        }

    }
}