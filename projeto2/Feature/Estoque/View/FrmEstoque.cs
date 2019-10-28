using System;
using System.Windows.Forms;
using projeto2.Feature.Grupo.Controller;
using projeto2.Feature.Produto.Controller;
using projeto2.Feature.Produto.View;

namespace projeto2.Feature.Estoque.View
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            dgvEstoque.DataSource = new ProdutoController().BuscarTodosOsDados();

            PreencherGrupos();
            txtTipo.Items.Add("Unidade");
            txtTipo.Items.Add("Caixa");
            txtTipo.Items.Add("Peso");

            CalculaPrecoTotal();
        }

        private void PreencherGrupos()
        {
            txtGrupo.DataSource = new GrupoController().ListarGrupos();
            txtGrupo.DisplayMember = "Grupo";
            txtGrupo.ValueMember = "IdGrupo";
            txtGrupo.Text = string.Empty;
        }

        private void CalculaPrecoTotal()
        {
            for (var i = 0; i < dgvEstoque.Rows.Count; i++)
            {
                var total = Convert.ToDecimal(dgvEstoque.Rows[i].Cells["valorVendaProduto"].Value) * Convert.ToDecimal(dgvEstoque.Rows[i].Cells["quantidadeEstoqueProduto"].Value);
                dgvEstoque.Rows[i].Cells["valorTotal"].Value = total;
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text) && string.IsNullOrWhiteSpace(txtGrupo.Text) && string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                FrmEstoque_Load(sender, e);
                return;
            }
            dgvEstoque.DataSource = new ProdutoController().BuscarDadosComFiltros(txtPesquisa.Text.Trim().ToLower(), txtGrupo.Text.Trim().ToLower(), txtTipo.Text.Trim().ToLower());
            CalculaPrecoTotal();
        }

        private void FrmEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    BtnFiltrar_Click(sender,e);
                    break;
                case Keys.R:
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

        private void DgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvEstoque.Rows[e.RowIndex].DataBoundItem != null) && (dgvEstoque.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = new FrmProdutos().BindProperty(dgvEstoque.Rows[e.RowIndex].DataBoundItem, dgvEstoque.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
    }
}
