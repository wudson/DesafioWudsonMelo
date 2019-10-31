using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Marca.Controller;
using projeto2.Feature.Produto.Controller;

namespace projeto2.Feature.Produto.View
{
    public partial class FrmCadastroDeProduto : Form
    {
        private readonly Produto _produto;
        private int _codigoProduto;

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
                IdProduto = _codigoProduto,
                NomeProduto = txtNome.Text.Trim(),
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
        }

        private static bool DeveLimpar(IDisposable item) =>
            item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox);

        private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e) => Close();

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {
            PreencherGruposEMarcas();

            if (_produto == null) return;
            _codigoProduto = _produto.IdProduto;
            txtNome.Text = _produto.NomeProduto;
            txtMarca.Text = _produto.MarcaProduto.Marca;
            txtGrupo.Text = _produto.GrupoProduto.Grupo;
            txtFornecedor.Text = _produto.FornecedorProduto;
            txtTipo.Text = _produto.TipoProduto;
            txtValorDeCompra.Text = _produto.ValorCompraProduto.ToString(CultureInfo.InvariantCulture);
            txtValorDeVenda.Text = _produto.ValorVendaProduto.ToString(CultureInfo.InvariantCulture);
            txtQuantidadeEmEstoque.Text = _produto.QuantidadeEstoqueProduto.ToString();
        }

        private void PreencherGruposEMarcas()
        {
            txtGrupo.DataSource = new GrupoController().ListarGrupos();
            txtGrupo.DisplayMember = "Grupo";
            txtGrupo.ValueMember = "IdGrupo";
            txtGrupo.Text = string.Empty;

            txtMarca.DataSource = new MarcaController().ListarMarcas();
            txtMarca.DisplayMember = "Marca";
            txtMarca.ValueMember = "IdMarca";
            txtMarca.Text = string.Empty;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(pnlControl.Controls)) return;
            var produto = AtribuirCamposParaModel();

            if (new ProdutoController().Alterar(produto))
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
    }
}