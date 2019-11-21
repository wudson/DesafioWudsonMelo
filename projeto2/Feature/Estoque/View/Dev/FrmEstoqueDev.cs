using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using projeto2.Feature.Estoque.Controller;

namespace projeto2.Feature.Estoque.View.Dev
{
    public partial class FrmEstoqueDev : XtraForm
    {
        private readonly EstoqueDeProdutoController _estoqueDeProdutoController;

        public FrmEstoqueDev(EstoqueDeProdutoController controller)
        {
            InitializeComponent();
            _estoqueDeProdutoController = controller;
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            dgvEstoque.DataSource = _estoqueDeProdutoController.ListarDados(new Produto.Produto());
            PreencherGrupos();
        }

        private void PreencherGrupos()
        {
            txtGrupo.Properties.DataSource = _estoqueDeProdutoController.ListarGrupos();
            txtGrupo.Properties.NullText = string.Empty;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e) =>
            dgvEstoque.DataSource = _estoqueDeProdutoController.ListarDados(Filtrar());

        private Produto.Produto Filtrar() =>
            new Produto.Produto
            {
                NomeProduto = txtNome.Text.Trim(),
                GrupoProduto = { Grupo = txtGrupo.Text.Trim() },
                TipoProduto = txtTipo.Text.Trim()
            };

        private void FrmEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BtnFiltrar_Click(sender, e);
                    break;
                case Keys.F10:
                    BtnLimpar_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtGrupo.EditValue = null;
            txtNome.Text = string.Empty;
            txtTipo.Text = string.Empty;
            FrmEstoque_Load(sender, e);
        }
    }
}