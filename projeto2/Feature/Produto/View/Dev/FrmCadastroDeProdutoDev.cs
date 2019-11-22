using DevExpress.XtraEditors;
using projeto2.Feature.Produto.Controller;
using System;
using System.Windows.Forms;

namespace projeto2.Feature.Produto.View.Dev
{
    public partial class FrmCadastroDeProdutoDev : XtraForm
    {
        private readonly CadastroDeProdutoController _cadastroDeProdutoController;
        private Produto _produto;

        public FrmCadastroDeProdutoDev(CadastroDeProdutoController controller)
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
            LimpaCampos(pnlCampos.Controls);
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

            if (string.IsNullOrWhiteSpace(txtGrupo.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Grupo' obrigatório.");
                txtGrupo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text.Trim()))
            {
                MessageBox.Show(@"Campo 'Marca' obrigatório.");
                txtMarca.Focus();
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
                    IdMarca = int.Parse(txtMarca.EditValue.ToString())
                },
                GrupoProduto =
                {
                    IdGrupo = int.Parse(txtGrupo.EditValue.ToString())
                },
                FornecedorProduto = txtFornecedor.Text.Trim(),
                TipoProduto = txtTipo.Text.Trim(),
                QuantidadeEstoqueProduto = string.IsNullOrWhiteSpace(txtQuantidadeEmEstoque.Text) ? 0 : int.Parse(txtQuantidadeEmEstoque.Text),
                ValorCompraProduto = double.Parse(txtValorDeCompra.Text.Replace("R$", "")),
                ValorVendaProduto = double.Parse(txtValorDeVenda.Text.Replace("R$", ""))
            };

        public void LimpaCampos(Control.ControlCollection campos)
        {
            foreach (Control item in campos)
            {
                if (item.Name.StartsWith("txt"))
                    item.Text = string.Empty;
                txtGrupo.EditValue = null;
                txtMarca.EditValue = null;
            }
        }

        private void BtnCancelarCadastroProduto_Click(object sender, EventArgs e) => Close();

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {
            PreencherGrupos();
            PreencherMarcas();
            CarregarDadosDoProduto();
        }

        private void PreencherGrupos()
        {
            txtGrupo.Properties.DataSource = _cadastroDeProdutoController.ListarGrupos();
            txtGrupo.Properties.NullText = string.Empty;
        }

        private void PreencherMarcas()
        {
            txtMarca.Properties.DataSource = _cadastroDeProdutoController.ListarMarcas();
            txtMarca.Properties.NullText = string.Empty;
        }

        private void CarregarDadosDoProduto()
        {
            if (_produto == null) return;
            txtNome.Text = _produto.NomeProduto;
            txtMarca.EditValue = _produto.MarcaProduto.IdMarca;
            txtGrupo.EditValue = _produto.GrupoProduto.IdGrupo;
            txtCodigoDeBarras.Text = _produto.CodigoDeBarras;
            txtFornecedor.Text = _produto.FornecedorProduto;
            txtTipo.Text = _produto.TipoProduto;
            txtValorDeCompra.Text = _produto.ValorCompraProduto.ToString("c2");
            txtValorDeVenda.Text = _produto.ValorVendaProduto.ToString("c2");
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
    }
}