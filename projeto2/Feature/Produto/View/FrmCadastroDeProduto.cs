using System;
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
            btnEditar.Visible = true;
            btnSalvarCadastroProduto.Visible = false;
        }
        public FrmCadastroDeProduto()
        {
            InitializeComponent();
            btnEditar.Visible = false;
            btnSalvarCadastroProduto.Visible = true;
        }

        private void BtnSalvarCadastroProduto_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(pnlControl.Controls)) return;
            var produto = AtribuirCamposParaModel();
            if (!new ProdutoController().Cadastrar(produto)) return;
            LimpaCampos(pnlControl.Controls);
            txtNome.Focus();
        }

        private Produto AtribuirCamposParaModel() =>
            new Produto
            {
                IdProduto = int.Parse(txtIdProduto.Text),
                NomeProduto = txtNome.Text,
                MarcaProduto = txtMarca.Text,
                GrupoProduto = txtGrupo.Text,
                FornecedorProduto = txtFornecedor.Text,
                TipoProduto = txtTipo.Text,
                QuantidadeEstoqueProduto = int.Parse(txtQuantidadeEmEstoque.Text),
                ValorCompraProduto = double.Parse(txtValorDeCompra.Text),
                ValorVendaProduto = double.Parse(txtValorDeVenda.Text)
            };

        private static bool ValidarCampos(IEnumerable controles)
        {
            if (!controles.Cast<Control>().Any(item => string.IsNullOrWhiteSpace(item.Text))) return true;
            MessageBox.Show(@"Por favor preencha todos os campos", @"Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        public void LimpaCampos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
                if (DeveLimpar(item))
                    item.Text = string.Empty;

            txtIdProduto.Text = @"0";
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
            txtTipo.Text = _produto.TipoProduto;
            txtValorDeCompra.Text = _produto.ValorCompraProduto.ToString(CultureInfo.InvariantCulture);
            txtValorDeVenda.Text = _produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture);
            txtQuantidadeEmEstoque.Text = _produto.QuantidadeEstoqueProduto.ToString();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(pnlControl.Controls)) return;
            var produto = AtribuirCamposParaModel();

            if(new ProdutoController().Alterar(produto))
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

        private void CadastrarOuAlterar(object sender, KeyEventArgs e)
        {
            if (btnSalvarCadastroProduto.Visible)
                BtnSalvarCadastroProduto_Click(sender, e);
            else
                BtnEditar_Click(sender, e);
        }
    }
}