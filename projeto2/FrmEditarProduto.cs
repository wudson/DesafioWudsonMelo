using projeto2.Models;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace projeto2
{
    public partial class FrmEditarProduto : Form
    {
        private readonly Produto _produto;

        public FrmEditarProduto()
        {
            InitializeComponent();
        }

        public FrmEditarProduto(Produto produto)
        {
            InitializeComponent();
            _produto = produto;

        }


        private void FormEditarProduto_Load(object sender, EventArgs e)
        {
            idProduto.Text = _produto.IdProduto.ToString();
            nomeProduto.Text = _produto.NomeProduto;
            marcaProduto.Text = _produto.MarcaProduto;
            grupoProduto.Text = _produto.GrupoProduto;
            fornecedorProduto.Text = _produto.FornecedorProduto;
            compraProduto.Text = _produto.ValorCompraProduto.ToString(CultureInfo.InvariantCulture);
            txtValorDeVenda.Text = _produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture);
            estoqueProduto.Text = _produto.QuantidadeEstoqueProduto.ToString();
        }

        private void btnCancelarEdicaoProduto_Click(object sender, EventArgs e) => Close();

        private void btnSalvarEdicaoProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto
            {
                IdProduto = int.Parse(idProduto.Text),
                NomeProduto = nomeProduto.Text,
                MarcaProduto = marcaProduto.Text,
                GrupoProduto = grupoProduto.Text,
                FornecedorProduto = fornecedorProduto.Text,
                QuantidadeEstoqueProduto = int.Parse(estoqueProduto.Text),
                ValorCompraProduto = double.Parse(compraProduto.Text),
                ValorVendaProduto = double.Parse(txtValorDeVenda.Text)
            };

            MessageBox.Show(produto.Alterar(produto)
                ? "Produto alterado com sucesso"
                : "Problema ao alterar Produto");

            Close();

        }
    }
}
