using System;
using System.Globalization;
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

            if (produto.IdProduto >= 1)
            {
                MessageBox.Show(new ProdutoController().AlterarDado(produto)
                    ? "Produto alterado com sucesso"
                    : "Problema ao alterar Produto");

                Close();
            }
            else
            {
                MessageBox.Show(new ProdutoController().CadastrarDado(produto)
                    ? "Produto cadastrado com sucesso"
                    : "Problema ao cadastrar Produto");

                LimpaCampos(pnlControl.Controls);
            }
        }

        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox))
                {
                    item.Text = string.Empty;
                }
            }
        }

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