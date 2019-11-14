using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Produto.Controller;
using System;
using System.Windows.Forms;
using projeto2.Feature.Estoque.Controller;

namespace projeto2.Feature.Estoque.View
{
    public partial class FrmEstoque : Form
    {
        private readonly EstoqueDeProdutoController _estoqueDeProdutoController;

        public FrmEstoque(EstoqueDeProdutoController controller)
        {
            InitializeComponent();
            _estoqueDeProdutoController = controller;
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            dgvEstoque.DataSource = _estoqueDeProdutoController.ListarDados(new Produto.Produto());
            PreencherGrupos();
            PreencherTipos();
        }

        private void PreencherGrupos()
        {
            txtGrupo.DataSource = new GrupoController().ListarGrupos();
            txtGrupo.DisplayMember = "Grupo";
            txtGrupo.ValueMember = "IdGrupo";
            txtGrupo.Text = string.Empty;
        }

        private void PreencherTipos()
        {
            txtTipo.Items.Clear();
            txtTipo.Items.Add("Unidade");
            txtTipo.Items.Add("Caixa");
            txtTipo.Items.Add("Peso");
        }

        private void BtnFiltrar_Click(object sender, EventArgs e) => 
            dgvEstoque.DataSource = _estoqueDeProdutoController.ListarDados(Filtrar());

        private Produto.Produto Filtrar() =>
            new Produto.Produto
            {
                NomeProduto = txtPesquisa.Text.Trim(),
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
            txtGrupo.Text = string.Empty;
            txtPesquisa.Text = string.Empty;
            txtTipo.Text = string.Empty;
            FrmEstoque_Load(sender, e);
        }

        private void DgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) =>
            e.Value = Propriedade.BuscarPropriedadeComPonto(dgvEstoque, e);
    }
}
